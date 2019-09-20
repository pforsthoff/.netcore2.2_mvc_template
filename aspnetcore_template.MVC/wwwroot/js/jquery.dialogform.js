$(function () {

    // Don't allow browser caching of forms
    $.ajaxSetup({ cache: false });

    // Wire up the click event of any current or future dialog links
    $(document).on('click', '.dialogLink', function () {
        var element = $(this);
        // Retrieve values from the HTML5 data attributes of the link        
        var dialogTitle = element.data('dialogTitle');
        var updateTargetId = '#' + element.attr('data-update-target-id');
        var updateUrl = element.data('updateUrl');
        var reloadSource = (element.data('update-reloadsource') === true);
        var height = element.data('dialog-height');
        var width = element.data('dialog-width');
        var updateMethod = element.data('dialog-update-method');
        var removeElement = element.data('dialog-remove-element');
        var useElementId = element.data('dialog-use-id');
        // Generate a unique id for the dialog div
        var dialogId = 'uniqueName-' + Math.floor(Math.random() * 1000);
        var dialogDiv = "<div id='" + dialogId + "'></div>";

        var elementId = this.id;
        if (typeof width === 'undefined') {
            width = "auto";
        }


        // Load the form into the dialog div
        $(dialogDiv).load(this.href, function () {
            $(this).dialog({
                modal: true,
                resizable: false,
                title: dialogTitle,
                height: height,
                width: width,
                buttons: [
                        {
                            text: "Submit",
                            icons: { primary: "ui-icon-check" },
                            click: function () {
                                // Manually submit the form                        
                                var form = $('form', this);
                                if (form.valid()) {
                                    //$(".ui-dialog-content").dialog("close");
                                    //$('.ui-dialog-content').filter(":visible").addClass('dialog-isOpen');
                                    //$('.dialog-isOpen').dialog('close');
                                    if (removeElement) {
                                        $(form).submit();
                                        $(this).dialog('close').remove();
                                    } else {
                                        $(form).submit();
                                    }

                                }
                            }
                        },
                        {
                            text: "Cancel",
                            icons: { primary: "ui-icon-close" },
                            click: function () {
                                if (removeElement) {
                                    $(this).dialog('close').remove();
                                } else {
                                    $(this).dialog('close');
                                }
                            }
                        }
                ]
            });

            // Enable client side validation
            $.validator.unobtrusive.parse(this);

            // Setup the ajax submit logic
            wireUpForm(this, updateTargetId, updateUrl, reloadSource, updateMethod, useElementId, elementId);
        });
        return false;
    });
});

function wireUpForm(dialog, updateTargetId, updateUrl, reloadSource, updateMethod, useElementId, elementId) {
    $('form', dialog).submit(function () {

        // Do not submit if the form
        // does not pass client side validation
        if (!$(this).valid())
            return false;

        // Client side validation passed, submit the form
        // using the jQuery.ajax form
        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            success: function (result) {
                //console.log(result);
                //console.log('Current Tab Focus ' + currentTabFocus);
                // Check whether the post was successful
                if (result.success) {

                    // Close the dialog(s) 
                    $(".ui-dialog-content").dialog("close");
                    toastr.success(result.Message, "Success");

                    if (result.redirect) {
                        window.location.href = result.redirectUrl;
                    }

                    if (typeof result.id !== 'undefined') {
                        elementId = result.id;
                    }

                    if (reloadSource) {
                        // Reload the updated data in the target div
                        $(updateTargetId).load(updateUrl);
                    } else if (typeof updateMethod !== 'undefined') {
                        updateMethod = ensureCorrectUpdateMethod(updateMethod);
                        if (useElementId) {
                            window[updateMethod].apply(null, [elementId]);
                        } else {
                            window[updateMethod]();
                        }
                    }

                    // Reload the dialog to show model errors                    
                    $(dialog).html(result);

                    // Enable client side validation
                    $.validator.unobtrusive.parse(dialog);

                    // Setup the ajax submit logic
                    wireUpForm(this, updateTargetId, updateUrl, reloadSource, updateMethod);
                } else {
                    toastr.error(result.Message, "Error");
                }
            }
        });
        return false;
    });
}

function ensureCorrectUpdateMethod(updateMethod) {

    if (updateMethod === 'loadCoursesByCompetency')
        switch (currentTabFocus) {
            case 2:
                return 'loadTrackProgress';
        }
    return updateMethod;
}
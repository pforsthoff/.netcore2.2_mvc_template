using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcore_template.ServiceModel.Messaging
{
    public class JsonResultMessage
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public static class ResultMessages
    {
        public static JsonResultMessage JsonResultMessage()
        {
            return new JsonResultMessage
            {
                Success = true,
                Message = ""
            };
        }
    }
}

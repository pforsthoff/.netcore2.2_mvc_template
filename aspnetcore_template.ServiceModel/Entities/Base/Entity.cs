using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace aspnetcore_template.ServiceModel.Entities.Base
{
    [DataContract]
    public abstract class Entity<TId> : EntityBase<TId>
       where TId : struct
    {
    }
}

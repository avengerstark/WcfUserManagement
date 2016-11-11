using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WcfCrudUsers.Infrastructure
{
    [DataContract]
    public class WcfExceptionFault
    {
        public WcfExceptionFault(string message, string prop, bool succ)
        {
            Message = message;
            Property = prop;
            Succeed = succ;
        }

        [DataMember]
        public bool Succeed { get; protected set; }

        [DataMember]
        public string Property { get; protected set; }

        [DataMember]
        public string Message { get; protected set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfCrudUsers.Entities
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [DataMember]
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }

        [DataMember]
        [Required]
        public bool Gender { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime? VisitDate { get; set; }
    }
}
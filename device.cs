using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CordovaSPA.Dal
{
    public class Device
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Platform { get; set; }

        public string RegistryId { get; set; }

        public DateTime RegistryDate { get; set; }

        public string UserId { get; set; }

    }
}
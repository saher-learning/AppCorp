using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
    }
}

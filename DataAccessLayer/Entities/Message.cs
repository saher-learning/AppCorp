using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Profile")]
        public int ProfileId { get; set; }
        public string MessageSent { get; set; }
    }
}

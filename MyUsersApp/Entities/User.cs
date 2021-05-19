using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyUsersApp.Entities
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(12), MaxLength(15)]
        public string Phone { get; set; }
        [Required, StringLength(200), MaxLength(250)]
        public string Message { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string Address { get; set; }
        public short CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
    public class Country
    {
        [Key]
        public short CountryId { get; set; }
        public string CountryName { get; set; }
    }
}

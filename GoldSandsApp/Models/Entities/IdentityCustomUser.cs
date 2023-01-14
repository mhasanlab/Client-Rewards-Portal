using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Models.Entities
{
    public class IdentityCustomUser: IdentityUser
    {
        [Required(ErrorMessage = "Name should not be empty")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special character should not be entered")]
        public string FullName { get; set; }
    }
}

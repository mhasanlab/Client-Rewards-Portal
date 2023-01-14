using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Models.ViewModel
{
    public class LeadsVM
    {
        public int LeadsId { get; set; }

        [Required(ErrorMessage = "Client Name should not be empty")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        [DisplayName("Client Name")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Client Address should not be empty")]
        [DisplayName("Client Address")]
        public string ClientAddress { get; set; }

        [Required(ErrorMessage = "Phone Number should not be empty")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$", ErrorMessage = "Entered phone Number format is not valid.")]
        [DisplayName("Client Phone")]
        public string ClientPhone { get; set; }

        [Required(ErrorMessage = "Email should not be empty")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [DisplayName("Client Email")]
        public string ClientEmail { get; set; }

        [DisplayName("Client Occupation")]
        public int? OccupationId { get; set; }
        //[Required(ErrorMessage = "Client Designation should not be empty")]
        //[RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        [DisplayName("Client Designation")]
        public string Designation { get; set; }
        public string Prospect { get; set; }
        public string Nursing { get; set; }
        public string Sold { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Models.ViewModel
{
    public class BulkLeadsVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        [Required, Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Display(Name = "Upload Date")]
        public DateTime UploadDate { get; set; }
        [Display(Name = "Upload File")]
        public string FileUpload { get; set; }
        public IFormFile ExcleFile { get; set; }
    }
}

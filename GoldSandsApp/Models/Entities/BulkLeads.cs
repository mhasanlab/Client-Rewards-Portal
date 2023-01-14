using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Models.Entities
{
    public class BulkLeads
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime UploadDate { get; set; }
        public string FileUpload { get; set; }
    }
}

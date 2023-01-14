using GoldSandsApp.Models;
using GoldSandsApp.Models.Entities;
using GoldSandsApp.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GoldSandsApp.Controllers
{
    [Authorize]
    public class BulkLeadsController : Controller
    {

        private readonly ApplicationContext context;
        private readonly IWebHostEnvironment _hostEnv;
        private readonly UserManager<IdentityCustomUser> userManager;
        private readonly SignInManager<IdentityCustomUser> signInManager;

        public BulkLeadsController(ApplicationContext context, IWebHostEnvironment hostEnv, UserManager<IdentityCustomUser> userManager, SignInManager<IdentityCustomUser> signInManager)
        {
            this.context = context;
            this._hostEnv = hostEnv;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(context.BulkLeads.ToList());
        }


        // Upload Excle File And Export to Database

        public IActionResult Upload()
        {
            return View();
        }

        //HTTP Method Start here

        [HttpPost]

        public async Task<IActionResult> Upload(IFormFile FormFile)
        {

            //get excle file name

            var filename = ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');

            // get directory path

            var MainPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads");


            //Set directory "Uploads" in the wwwroot folder


            if (!Directory.Exists(MainPath))
            {
                Directory.CreateDirectory(MainPath);
            }


            //get the excle file path 

            var filePath = Path.Combine(MainPath, FormFile.FileName);
            using (System.IO.Stream stream = new FileStream(filePath, FileMode.Create))
            {
                await FormFile.CopyToAsync(stream);
            }



            //get the excle file extension

            string extension = Path.GetExtension(filename);


            string conString = string.Empty;

            switch (extension)
            {
                case ".xls": //Excel 97-03.
                    conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES'";
                    break;
                case ".xlsx": //Excel 07 and above.
                    conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES'";
                    break;
            }


            DataTable dt = new DataTable();
            conString = string.Format(conString, filePath);

            using (OleDbConnection connExcel = new OleDbConnection(conString))
            {
                using (OleDbCommand cmdExcel = new OleDbCommand())
                {
                    using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                    {
                        cmdExcel.Connection = connExcel;


                        //Get the First excle Sheet name.

                        connExcel.Open();
                        DataTable dtExcelSchema;
                        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        connExcel.Close();

                        //Read Data from First Sheet.
                        connExcel.Open();
                        cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                        odaExcel.SelectCommand = cmdExcel;
                        odaExcel.Fill(dt);
                        connExcel.Close();
                    }
                }
            }

            // This are database connection string

            conString = @"Data Source=.;Initial Catalog=GoldSandAppDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                {

                    // Here we set the database table wher we want to save data from Excle file.

                    sqlBulkCopy.DestinationTableName = "dbo.Leads";


                    //Map the Excel columns with the database table

                    sqlBulkCopy.ColumnMappings.Add("ClientName", "ClientName");
                    sqlBulkCopy.ColumnMappings.Add("ClientAddress", "ClientAddress");
                    sqlBulkCopy.ColumnMappings.Add("ClientPhone", "ClientPhone");
                    sqlBulkCopy.ColumnMappings.Add("ClientEmail", "ClientEmail");

                    con.Open();
                    sqlBulkCopy.WriteToServer(dt);
                    con.Close();
                }
            }


            //if the Excle file  data is imported into database successfuly

            ViewBag.Message = "File Uploded Successfully and Data saved into our database";


            return View("Upload");
        }

        // Excle File upload HTTP Controllercommand ended here.



        public IActionResult ClientUpload()
        {
            return View();
        }

        //HTTP Method Start here

        [HttpPost]

        public async Task<IActionResult> ClientUpload(IFormFile FormFile)
        {

            //get excle file name

            var filename = ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');

            // get directory path

            var MainPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads");


            //Set directory "Uploads" in the wwwroot folder


            if (!Directory.Exists(MainPath))
            {
                Directory.CreateDirectory(MainPath);
            }


            //get the excle file path 

            var filePath = Path.Combine(MainPath, FormFile.FileName);
            using (System.IO.Stream stream = new FileStream(filePath, FileMode.Create))
            {
                await FormFile.CopyToAsync(stream);
            }



            //get the excle file extension

            string extension = Path.GetExtension(filename);


            string conString = string.Empty;

            switch (extension)
            {
                case ".xls": //Excel 97-03.
                    conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES'";
                    break;
                case ".xlsx": //Excel 07 and above.
                    conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES'";
                    break;
            }


            DataTable dt = new DataTable();
            conString = string.Format(conString, filePath);

            using (OleDbConnection connExcel = new OleDbConnection(conString))
            {
                using (OleDbCommand cmdExcel = new OleDbCommand())
                {
                    using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                    {
                        cmdExcel.Connection = connExcel;


                        //Get the First excle Sheet name.

                        connExcel.Open();
                        DataTable dtExcelSchema;
                        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        connExcel.Close();

                        //Read Data from First Sheet.
                        connExcel.Open();
                        cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                        odaExcel.SelectCommand = cmdExcel;
                        odaExcel.Fill(dt);
                        connExcel.Close();
                    }
                }
            }

            // This are database connection string

            conString = @"Data Source=.;Initial Catalog=GoldSandAppDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                {

                    // Here we set the database table wher we want to save data from Excle file.

                    sqlBulkCopy.DestinationTableName = "dbo.Leads";


                    //Map the Excel columns with the database table

                    sqlBulkCopy.ColumnMappings.Add("ClientName", "ClientName");
                    sqlBulkCopy.ColumnMappings.Add("ClientAddress", "ClientAddress");
                    sqlBulkCopy.ColumnMappings.Add("ClientPhone", "ClientPhone");
                    sqlBulkCopy.ColumnMappings.Add("ClientEmail", "ClientEmail");

                    con.Open();
                    sqlBulkCopy.WriteToServer(dt);
                    con.Close();
                }
            }


            //if the Excle file  data is imported into database successfuly

            ViewBag.SuccessMessage = "File Uploded Successfully and Data saved into our database";


            return View("ClientUpload");
        }

        // Excle File upload HTTP Controllercommand ended here.






        // Uplada New Bulk Leads: This Code only Upload excle file into Database Data are not imported.

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BulkLeadsVM  vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.ExcleFile != null)
                {
                    string newFileName = Guid.NewGuid().ToString() + "_" + vm.ExcleFile.FileName;
                    string newFilePath = Path.Combine("Uploads", newFileName);
                    string file = Path.Combine(_hostEnv.WebRootPath, newFilePath);
                    vm.ExcleFile.CopyTo(new FileStream(file, FileMode.Create));

                    BulkLeads blds = new BulkLeads
                    {
                        UserName = vm.UserName,
                        UploadDate = vm.UploadDate,
                        FileUpload = newFileName
                    };

                    context.BulkLeads.Add(blds);
                    context.SaveChanges();
                    return PartialView("_Success");
                }
            }
            else
            {
                return PartialView("_Error");
            }
            return View();
        }


    }
}

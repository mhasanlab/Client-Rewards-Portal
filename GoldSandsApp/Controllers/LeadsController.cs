using GoldSandsApp.Models;
using GoldSandsApp.Models.Entities;
using GoldSandsApp.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Controllers
{
    public class LeadsController : Controller
    {
        private readonly ApplicationContext context;
        private readonly IWebHostEnvironment _hostEnv;
        private readonly UserManager<IdentityCustomUser> userManager;
        private readonly SignInManager<IdentityCustomUser> signInManager;

        public LeadsController(ApplicationContext context, IWebHostEnvironment hostEnv, UserManager<IdentityCustomUser> userManager, SignInManager<IdentityCustomUser> signInManager)
        {
            this.context = context;
            this._hostEnv = hostEnv;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        public IActionResult Index()
        {

            ViewBag.Occupations = context.Occupations.ToList();
            return View(context.Leads.ToList());
            
        }

        // Create New Occupations
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewBag.Occupations = context.Occupations.ToList();
            return View();
        }


        // Create New Leads HTTP POST METHOD

        [HttpPost]
        public IActionResult Create(LeadsVM vm)
        {
            if (ModelState.IsValid)
            {

                if (vm.ClientName != null)
                {

                    Leads lds = new Leads
                    {
                        ClientName = vm.ClientName,
                        ClientAddress = vm.ClientAddress,
                        ClientPhone = vm.ClientPhone,
                        ClientEmail = vm.ClientEmail,
                        OccupationId = vm.OccupationId,
                        Designation = vm.Designation,
                        Prospect = vm.Prospect,
                        Nursing = vm.Nursing,
                        Sold = vm.Sold
                    };
                    context.Leads.Add(lds);
                    context.SaveChanges();
                    return PartialView("_Success");
                }

            }
            else
            {
                
                return PartialView("_Error");
            }

            ViewBag.Occupations = context.Occupations.ToList();
            return View();

        }


        // Create New Occupations
        [Authorize]
        public IActionResult Add()
        {
            ViewBag.Occupations = context.Occupations.ToList();
            return View();
        }


        // Create New Leads HTTP POST METHOD

        [HttpPost]
        public IActionResult Add(LeadsVM vm)
        {
            if (ModelState.IsValid)
            {

                if (vm.ClientName != null)
                {

                    Leads lds = new Leads
                    {
                        ClientName = vm.ClientName,
                        ClientAddress = vm.ClientAddress,
                        ClientPhone = vm.ClientPhone,
                        ClientEmail = vm.ClientEmail,
                        OccupationId = vm.OccupationId,
                        Designation = vm.Designation,
                        Prospect = vm.Prospect,
                        Nursing = vm.Nursing,
                        Sold = vm.Sold
                    };
                    context.Leads.Add(lds);
                    context.SaveChanges();
                    return PartialView("_Success");
                }

            }
            else
            {

                return PartialView("_Error");
            }

            ViewBag.Occupations = context.Occupations.ToList();
            return View();

        }




        //View Details as Admin

        [Authorize(Roles = "Admin")]
        public IActionResult Details (int id)
        {
            Leads lds = context.Leads.Find(id);

            if (lds == null)
            {
                return HttpNotFound();
            }
            return View(lds);
        }


        // View Details As Clients

        [Authorize]
        public IActionResult View(int id)
        {
            Leads lds = context.Leads.Find(id);

            if (lds == null)
            {
                return HttpNotFound();
            }
            return View(lds);
        }


        // Edit  For Admin

        [Authorize(Roles = "Admin")]
        public IActionResult Update(int? id)
        {
            Leads ld = context.Leads.Find(id);

            LeadsVM vm = new LeadsVM
            {
                LeadsId = ld.LeadsId,
                ClientName = ld.ClientName,
                ClientAddress = ld.ClientAddress,
                ClientPhone = ld.ClientPhone,
                ClientEmail = ld.ClientEmail,
                OccupationId = ld.OccupationId,
                Designation = ld.Designation,
                Prospect = ld.Prospect,
                Nursing = ld.Nursing,
                Sold = ld.Sold
            };
            ViewBag.Occupations = context.Occupations.ToList();
            return View(vm);
        }


        // Admin Edit Http Post

        [HttpPost]
        public IActionResult Update(LeadsVM vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.ClientName != null)
                {
                    
                    Leads ld = new Leads
                    {
                        LeadsId = vm.LeadsId,
                        ClientName = vm.ClientName,
                        ClientAddress = vm.ClientAddress,
                        ClientPhone = vm.ClientPhone,
                        ClientEmail = vm.ClientEmail,
                        OccupationId = vm.OccupationId,
                        Designation = vm.Designation,
                        Prospect = vm.Prospect,
                        Nursing = vm.Nursing,
                        Sold = vm.Sold
                    };

                    context.Entry(ld).State = EntityState.Modified;
                    context.SaveChanges();
                    return PartialView("_UpdateSuccess");
                }
                else
                {
                    Leads ld = new Leads
                    {
                        LeadsId = vm.LeadsId,
                        ClientName = vm.ClientName,
                        ClientAddress = vm.ClientAddress,
                        ClientPhone = vm.ClientPhone,
                        ClientEmail = vm.ClientEmail,
                        OccupationId = vm.OccupationId,
                        Designation = vm.Designation,
                        Prospect = vm.Prospect,
                        Nursing = vm.Nursing,
                        Sold = vm.Sold
                    };
                    context.Entry(ld).State = EntityState.Modified;
                    context.SaveChanges();
                    return PartialView("_UpdateSuccess");
                }
            }
            ViewBag.Occupations = context.Occupations.ToList();
            return View();
        }



        // Edit As Client

        [Authorize]
        public IActionResult Edit(int? id)
        {
            Leads ld = context.Leads.Find(id);

            LeadsVM vm = new LeadsVM
            {
                LeadsId = ld.LeadsId,
                ClientName = ld.ClientName,
                ClientAddress = ld.ClientAddress,
                ClientPhone = ld.ClientPhone,
                ClientEmail = ld.ClientEmail,
                OccupationId = ld.OccupationId,
                Designation = ld.Designation,
                Prospect = ld.Prospect,
                Nursing = ld.Nursing,
                Sold = ld.Sold
            };
            ViewBag.Occupations = context.Occupations.ToList();
            return View(vm);
        }


        // Admin Edit Http Post

        [HttpPost]
        public IActionResult Edit(LeadsVM vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.ClientName != null)
                {

                    Leads ld = new Leads
                    {
                        LeadsId = vm.LeadsId,
                        ClientName = vm.ClientName,
                        ClientAddress = vm.ClientAddress,
                        ClientPhone = vm.ClientPhone,
                        ClientEmail = vm.ClientEmail,
                        OccupationId = vm.OccupationId,
                        Designation = vm.Designation,
                        Prospect = vm.Prospect,
                        Nursing = vm.Nursing,
                        Sold = vm.Sold
                    };

                    context.Entry(ld).State = EntityState.Modified;
                    context.SaveChanges();
                    return PartialView("_UpdateSuccess");
                }
                else
                {
                    Leads ld = new Leads
                    {
                        LeadsId = vm.LeadsId,
                        ClientName = vm.ClientName,
                        ClientAddress = vm.ClientAddress,
                        ClientPhone = vm.ClientPhone,
                        ClientEmail = vm.ClientEmail,
                        OccupationId = vm.OccupationId,
                        Designation = vm.Designation,
                        Prospect = vm.Prospect,
                        Nursing = vm.Nursing,
                        Sold = vm.Sold
                    };
                    context.Entry(ld).State = EntityState.Modified;
                    context.SaveChanges();
                    return PartialView("_UpdateSuccess");
                }
            }
            ViewBag.Occupations = context.Occupations.ToList();
            return View();
        }




        // Method For Not Found Exception
        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

    }
}

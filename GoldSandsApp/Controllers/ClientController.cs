using GoldSandsApp.Models;
using GoldSandsApp.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        private readonly ApplicationContext context;
        private readonly UserManager<IdentityCustomUser> userManager;
        private readonly SignInManager<IdentityCustomUser> signInManager;

        public ClientController(ApplicationContext context, UserManager<IdentityCustomUser> userManager, SignInManager<IdentityCustomUser> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        // Dashboard Controller

        public IActionResult Index()
        {
            CountClients();
            ViewBag.Occupations = context.Occupations.ToList();
            return View(context.Leads.ToList());
        }

        // Count Clients Method
        public void CountClients()
        {
            ViewBag.DisplayClients = context.Leads.ToList();
            ViewBag.Count = context.Leads.Count();
            ViewBag.ProspectCount = context.Leads.Count(x => x.Prospect == "Yes");
            ViewBag.NursingCount = context.Leads.Count(x => x.Nursing == "Yes");
            ViewBag.SoldCount = context.Leads.Count(x => x.Sold == "Yes");
        }


    }
}

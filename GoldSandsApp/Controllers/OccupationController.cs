using GoldSandsApp.Models;
using GoldSandsApp.Models.Entities;
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
    [Authorize(Roles = "Admin")]
    public class OccupationController : Controller
    {
        private readonly ApplicationContext context;
        private readonly IWebHostEnvironment _hostEnv;
        private readonly UserManager<IdentityCustomUser> userManager;
        private readonly SignInManager<IdentityCustomUser> signInManager;

        public OccupationController(ApplicationContext context, IWebHostEnvironment hostEnv, UserManager<IdentityCustomUser> userManager, SignInManager<IdentityCustomUser> signInManager)
        {
            this.context = context;
            this._hostEnv = hostEnv;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(context.Occupations.ToList());
        }

        // Create New Occupations

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Occupation ocp)
        {
            if (ModelState.IsValid)
            {
                context.Occupations.Add(ocp);
                context.SaveChanges();
                return PartialView("_Success");
            }
            else
            {
                return PartialView("_Error");
            }

        }
    }
}

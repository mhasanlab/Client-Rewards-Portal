using GoldSandsApp.Models;
using GoldSandsApp.Models.Entities;
using GoldSandsApp.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationContext context;
        private readonly UserManager<IdentityCustomUser> userManager;
        private readonly SignInManager<IdentityCustomUser> signInManager;

        public AccountController(ApplicationContext context, UserManager<IdentityCustomUser> userManager, SignInManager<IdentityCustomUser> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


        // Register Controller Start Here

        public IActionResult SignUp()
        {
            return View();
        }


        // Create New User

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp(SignUpUserViewModel model)
        {
            var Name = model.FullName;
            var check = context.Users.Where(x => x.FullName == Name).ToList();
            if (ModelState.IsValid)
            {

                if (check.Count > 0)
                {
                    ViewBag.Duplicate = "Enter Name" + " " + Name + " " + "is already exists in Database!";
                    return View(model);

                }
                else
                {
                    var user = new IdentityCustomUser()
                    {
                        FullName = model.FullName,
                        Email = model.Email,
                        PhoneNumber = model.Phone,
                        PasswordHash = model.Password,
                        UserName = model.Email
                    };

                    IdentityResult result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        //ModelState.Clear();
                        //ViewBag.message = "New User Created Successfully";
                        //return View();
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        foreach (var er in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, er.Description);
                        }
                        return View();
                    }
                }
            }
            else
            {
                return View(model);
            }
        }

        // Register Controller Ends Here



        // LogIn Controller Start Here

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        // Log In As User

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //success
                var user = context.Users.SingleOrDefault(e => e.UserName == model.Username);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Overview");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Password don't match our records!");
                        return View();
                    }
                }

            }
            else
            {
                return View(model);
            }
            return View();
        }

        // LogIn Controller Ends Here


        // Signout Controller Start Here

        [Authorize]
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        // Signout Controller Ends Here


    }
}

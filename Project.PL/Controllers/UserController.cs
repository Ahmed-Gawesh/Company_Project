using AutoMapper;
using MailKit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.BL.Interfaces;
using Project.BL.Repositoties;
using Project.DAL.Models;
using Project.PL.Helpers;
using Project.PL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.PL.Controllers
{
	public class UserController : Controller
	{
		private readonly UserManager<ApplicationUser> userManager;
		private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IMapper mapper;

        public UserController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager,IMapper mapper)
        {
			this.userManager = userManager;
			this.signInManager = signInManager;
            this.mapper = mapper;
        }
		public async Task<IActionResult> Index(string email)
		{
			
			if (string.IsNullOrEmpty(email))
			{
				var users =  userManager.Users.Select(  U => new UserViewModel()
				{
					Id= U.Id,
					FName=U.FName,
					LName=U.LName,
					Email=U.Email,
					PhoneNumber=U.PhoneNumber,
					Roles= userManager.GetRolesAsync(U).Result
				}).ToList();
				return View(users);
			}
			else
			{
				var user = await userManager.FindByEmailAsync(email);
				var MappedUser = new UserViewModel()
				{
					Id = user.Id,
					FName = user.FName,
					LName = user.LName,
					Email = user.Email,
					PhoneNumber = user.PhoneNumber,
					Roles = userManager.GetRolesAsync(user).Result,
				};
				return View(new List<UserViewModel> { MappedUser });
			}
			
				
		}

        public async Task<IActionResult> Details(string id, string viewName = "Details")
        {

            if (id is null)
                return BadRequest();
            var user=await userManager.FindByIdAsync(id);
            if (id != user.Id)
                return BadRequest();

            if (user is null)
                return NotFound();
            var MappedUser = mapper.Map<ApplicationUser, UserViewModel>(user);
            return View(viewName, MappedUser);

        }
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");


        }
        [HttpPost]
        [ValidateAntiForgeryToken] //بياخد ال id او الاسم من نفس المتصفح مش من حتة تانية 
        public async Task<IActionResult> Edit([FromRoute] string id, UserViewModel userVM)
        {
            if (id != userVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var user =await userManager.FindByIdAsync(id);  // يعملها manual علشان يتراك الاوبجكت 
                    user.FName = userVM.FName;
                    user.Email = userVM.Email;
                    user.LName= userVM.LName;
                    user.PhoneNumber= userVM.PhoneNumber;
                    user.SecurityStamp=Guid.NewGuid().ToString(); // علشان لما باجي اعدل علي الايميل يغيرلي التوكن معاه

                    await userManager.UpdateAsync(user);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(userVM);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] string id, UserViewModel userVM)
        {
            if (id != userVM.Id)
                return BadRequest();

            try
            {
                  var user=await userManager.FindByIdAsync(id);

                   await userManager.DeleteAsync(user);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(userVM);
        }
    }
}

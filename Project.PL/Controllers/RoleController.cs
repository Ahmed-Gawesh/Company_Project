using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;

        public RoleController(RoleManager<IdentityRole> roleManager,IMapper mapper)
        {
            this.roleManager = roleManager;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                var roles = roleManager.Roles.Select(R => new RoleViewModel()
                {
                   Id = R.Id,
                   RoleName=R.Name,

                }).ToList();
                return View(roles);
            }
            else
            {
                var role = await roleManager.FindByNameAsync(name);
                var MappedRole = new RoleViewModel()
                {
                    Id = role.Id,
                    RoleName = role.Name,
                };
                return View(new List<RoleViewModel> { MappedRole });
            }


        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleViewModel roleVM)
        {
            if (ModelState.IsValid) // server side validation
            {
                var Mappedrole = mapper.Map<RoleViewModel, IdentityRole>(roleVM);
                await roleManager.CreateAsync(Mappedrole);

                return RedirectToAction(nameof(Index));
            }
            return View(roleVM);
        }
        [HttpGet]


        public async Task<IActionResult> Details(string id, string viewName = "Details")
        {

            if (id is null)
                return BadRequest();
            var role = await roleManager.FindByIdAsync(id); 
            if (id != role.Id)
                return BadRequest();

            if (role is null)
                return NotFound();
            var MappedRole = mapper.Map<IdentityRole, RoleViewModel>(role);
            return View(viewName, MappedRole);

        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");


        }
        [HttpPost]
        [ValidateAntiForgeryToken] //بياخد ال id او الاسم من نفس المتصفح مش من حتة تانية 
        public async Task<IActionResult> Edit([FromRoute] string id, RoleViewModel roleVM)
        {
            if (id != roleVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                   var role=await roleManager.FindByIdAsync(id);
                    role.Name = roleVM.RoleName;

                    await roleManager.UpdateAsync(role);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(roleVM);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] string id, RoleViewModel roleVM)
        {
            if (id != roleVM.Id)
                return BadRequest();

            try
            {
                var role = await roleManager.FindByIdAsync(id);
                role.Name = roleVM.RoleName;

                await roleManager.DeleteAsync(role);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(roleVM);
        }
    }
}

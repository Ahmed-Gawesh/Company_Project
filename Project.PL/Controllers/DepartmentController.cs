using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Project.BL.Interfaces;
using Project.DAL.Models;
using Project.PL.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.PL.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DepartmentController(IUnitOfWork unitOfWork,IMapper mapper)
        {
        
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var departments = await unitOfWork.departmentRepository.GetAll();
            var MappedDept = mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View(MappedDept);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentViewModel department)
        {
            if(ModelState.IsValid)
            {
                var MappedDept = mapper.Map<DepartmentViewModel, Department>(department);
                await unitOfWork.departmentRepository.Add(MappedDept);
                int Result = await unitOfWork.Complete();
                if (Result>0)
                {
                    TempData["Message"] = "Department Is Created";
                }
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id,string viewName="Details")
        {
            if (id is null)
                return BadRequest();
            var department = await unitOfWork.departmentRepository.Get(id.Value);

            if(department is null)
                return NotFound();
            var MappedDept = mapper.Map<Department, DepartmentViewModel>(department);
            return View(viewName, MappedDept);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {


            return await Details(id, "Edit");

            
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //بياخد ال id او الاسم من نفس المتصفح مش من حتة تانية 
        public async Task<IActionResult> Edit([FromRoute]int? id,DepartmentViewModel department)
        {
            if(id!=department.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var MappedDept = mapper.Map<DepartmentViewModel, Department>(department);

                    unitOfWork.departmentRepository.Update(MappedDept);
                    int Result = await unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message); 
                }
            }
           return View(department);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id) 
        {
            
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int? id,DepartmentViewModel department)
        {
            if(id!=department.Id)
                return BadRequest();

            try
            {
                var MappedDept=mapper.Map<DepartmentViewModel,Department>(department);
                unitOfWork.departmentRepository.Delete(MappedDept);
                int Result = await unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(department);
        }
    }
}

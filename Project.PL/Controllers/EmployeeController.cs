using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BL.Interfaces;
using Project.BL.Repositoties;
using Project.DAL.Models;
using Project.PL.Helpers;
using Project.PL.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.PL.Controllers
{
	[Authorize]
	public class EmployeeController : Controller
    {
        
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public EmployeeController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index(string SearchValue)
        {
            IEnumerable<Employee> employees;
            if(string.IsNullOrEmpty(SearchValue))
                employees=await unitOfWork.employeeRepository.GetAll();
            else
                employees= unitOfWork.employeeRepository.GetEmployeeByName(SearchValue);

            var MappedEmp = mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
            return View(MappedEmp);
        }
        [HttpGet]
        public async  Task<IActionResult> Create()
        {
            ViewBag.Departments= await unitOfWork.departmentRepository.GetAll();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel emp)
        {
            if (ModelState.IsValid) // server side validation
            {
                var MappedEmp = mapper.Map<EmployeeViewModel, Employee>(emp);
                MappedEmp.ImageName = DocumentSettings.UploadImage(emp.Image,"Images");
                await unitOfWork.employeeRepository.Add(MappedEmp);
                int Result = await unitOfWork.Complete();
                if(Result>0)
                {
                    TempData["Message"] = "Employee Is Created"; // TempData= Data مؤقتة 
                }
                return RedirectToAction(nameof(Index));
            }
            return View(emp);
        }
        [HttpGet]

        
        public async Task<IActionResult> Details([FromRoute()] int? id , string viewName = "Details")
        {
            
            if (id is null)
                return BadRequest();
            var emp =await unitOfWork.employeeRepository.Get(id.Value);
            if(id!=emp.Id)
                return BadRequest();

            if (emp is null)
                return NotFound();
            var MappedEmp = mapper.Map<Employee, EmployeeViewModel>(emp);
            return View(viewName, MappedEmp);
            
        }
        [HttpGet]
        public async  Task<IActionResult> Edit(int? id)
        {
            ViewBag.Departments =await unitOfWork.departmentRepository.GetAll();
            return await Details(id, "Edit");


        }
        [HttpPost]
        [ValidateAntiForgeryToken] //بياخد ال id او الاسم من نفس المتصفح مش من حتة تانية 
        public async Task<IActionResult> Edit([FromRoute] int? id, EmployeeViewModel emp)
        {
            if (id != emp.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var MappedEmp = mapper.Map<EmployeeViewModel, Employee>(emp);
                    MappedEmp.ImageName = DocumentSettings.UploadImage(emp.Image, "Images");
                     unitOfWork.employeeRepository.Update(MappedEmp);
                    int Result =await unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(emp);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int? id, EmployeeViewModel emp)
        {
            if (id != emp.Id)
                return BadRequest();

            try
            {
                var MappedEmp = mapper.Map<EmployeeViewModel, Employee>(emp);
                if(MappedEmp.ImageName is not null)
                {
                    DocumentSettings.DeleteFile(MappedEmp.ImageName, "Images");
                }
                unitOfWork.employeeRepository.Delete(MappedEmp);
                
                int Result = await unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(emp);
        }
    }
}

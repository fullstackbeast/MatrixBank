using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MyBMS.Interface.Service;
using MyBMS.Models.Entities;
using MyBMS.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinancials.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IManagerService _managerService;

        public ManagerController(IManagerService managerService)
        {
            _managerService = managerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_managerService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Manager manager) 
        {
            ManagerValidation val = new ManagerValidation(_managerService);
            ValidationResult model = val.Validate(manager);

            if (model.IsValid)
            {
                _managerService.AddManager(manager);
                return RedirectToAction(nameof(Index));
            }
          
            else
            {
                foreach (ValidationFailure _error in model.Errors)
                {
                    ModelState.AddModelError(_error.PropertyName, _error.ErrorMessage);
                }
            }

            return View(manager);

        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manager = _managerService.GetManager(id.Value);
            if (manager == null)
            {
                return NotFound();
            }
            return View(manager);
        }
        [HttpPost]
        public IActionResult Edit(int id, Manager manager)
        {
            if (id != manager.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _managerService.UpdateManager(manager);
                return RedirectToAction(nameof(Index));
            }
            return View(manager);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manager = _managerService.GetManager(id.Value);
            if (manager == null)
            {
                return NotFound();
            }
            return View(manager);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            _managerService.DeleteManager(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            return View(_managerService.GetManager(id.Value));
        }
    }
}


using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MyBMS.Interface.Service;
using MyBMS.Models.Entities;
using MyBMS.Validations;

namespace MyBMS.Controllers
{
    public class AccountHolderController : Controller
    {
        private readonly IAccountHolderService _accountHolderService;

        public AccountHolderController(IAccountHolderService accountHolderService)
        {
            _accountHolderService = accountHolderService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_accountHolderService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AccountHolder accountHolder)
        {

            AccountHolderValidation val = new AccountHolderValidation(_accountHolderService);
            ValidationResult model = val.Validate(accountHolder);

            if (model.IsValid)
            {
                _accountHolderService.CreateAccountHolder(accountHolder);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (ValidationFailure _error in model.Errors)
                {
                    ModelState.AddModelError(_error.PropertyName, _error.ErrorMessage);
                }
            }
            return View(accountHolder);
        }
 
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountHolder = _accountHolderService.FindById(id.Value);
            if (accountHolder == null)
            {
                return NotFound();
            }
            return View(accountHolder);
        }


        [HttpPost]
        public IActionResult Edit(int id, AccountHolder accountHolder)
        {
            if (id != accountHolder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _accountHolderService.UpdateAccountHolder(accountHolder);
                return RedirectToAction(nameof(Index));
            }
            return View(accountHolder);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountHolder = _accountHolderService.FindById(id.Value);
            if (accountHolder == null)
            {
                return NotFound();
            }
            return View(accountHolder);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _accountHolderService.DeleteAccountHolder(id);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountHolder = _accountHolderService.GetDetails(id.Value);
            if (accountHolder == null)
            {
                return NotFound();
            }
            return View(accountHolder);
        }



    }



}
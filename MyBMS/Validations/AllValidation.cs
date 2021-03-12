using BMSEFDB.Models;
using FluentValidation;
using MyBMS.Domain.Repository;
using MyBMS.Domain.Service;
using MyBMS.Interface.Service;
using MyBMS.Models.Entities;

namespace MyBMS.Validations
{
    class AccountHolderValidation : AbstractValidator<AccountHolder>
    {
        private readonly IAccountHolderService _accountHolderService;

        public AccountHolderValidation(IAccountHolderService accountHolderService)
        {

            _accountHolderService = accountHolderService;

            RuleFor(ach => ach.FirstName).NotEmpty().WithMessage("First Name cannot be empty");

            RuleFor(ach => ach.LastName).NotEmpty().WithMessage("Last Name cannot be empty");

            RuleFor(ach => ach.Email)
            .NotEmpty().WithMessage("Please Enter your Email")
            .Must(ValidateEmail).WithMessage(x=> $"User with the email {x.Email} already exists");

            RuleFor(ach => ach.PhoneNumber)
            .Length(11).WithMessage("Your Phone Number Must Be 11 digits")
            .NotEmpty().WithMessage("Phone Number Cannot Be Empty");

            RuleFor(ach => ach.Address).NotEmpty().WithMessage("Please Enter Your Address");
            RuleFor(ach => ach.Password).NotEmpty().WithMessage("You definitely need a password");

        }

        public bool ValidateEmail(string email)
        {
            AccountHolder accountHolder = _accountHolderService.FindByEmail(email);
            return accountHolder == null;
        }
    }
    class ManagerValidation : AbstractValidator<Manager>
    {

        private readonly IManagerService _managerService;
        public ManagerValidation(IManagerService managerService)
        {
            _managerService = managerService;
            RuleFor(ach => ach.FirstName).NotEmpty().WithMessage("First Name cannot be empty");

            RuleFor(ach => ach.LastName).NotEmpty().WithMessage("Last Name cannot be empty");

            RuleFor(ach => ach.Email)
            .NotEmpty().WithMessage("Please Enter your Email")
            .Must(ValidateEmail).WithMessage("User with the email already exists");

            RuleFor(ach => ach.Password).NotEmpty().WithMessage("You definitely need a password");
        }

        public bool ValidateEmail(string email)
        {
            Manager manager = _managerService.GetManagerByEmail(email);
            return manager == null;
        }


    }
}
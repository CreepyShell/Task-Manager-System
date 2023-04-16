using FluentValidation;
using TMS_BLL.Models;

namespace Task_Manager_System.Services.Validators
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(c => c.Name).MinimumLength(5).WithMessage("Name must be less than 5 symbols");
            RuleFor(c => c.Name).MaximumLength(20).WithMessage("Name must be more than 30 symbols");
            RuleFor(c => c.Description).MaximumLength(200).WithMessage("Description must be less than 200 symbols");
            RuleFor(c => c.ExpectedCost).GreaterThan(0).WithMessage("Excepted cost must more than sero");
            RuleFor(c => c.StartDate).NotEmpty().WithMessage("Start date can not be null");
            RuleFor(c => c.EndDate).NotEmpty().WithMessage("Start date can not be null");
            RuleFor(c => c.StartDate).LessThan(c => c.EndDate).WithMessage("Start date must be less than end date");
            RuleFor(c => c.Status).NotEmpty().WithMessage("Status can not be null");
        }
    }
}

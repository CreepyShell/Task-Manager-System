using FluentValidation;
using TMS_BLL.Models;

namespace Task_Manager_System.Services.Validators
{
    //https://docs.fluentvalidation.net/en/latest/
    public class TaskValidator : AbstractValidator<Task>
    {
        //validation for a task entity
        public TaskValidator()
        {
            RuleFor(c => c.Name).MinimumLength(5).MaximumLength(30).WithMessage("Task name must be greater than 5 symbols and less than 20 symbols");
            RuleFor(c => c.Description).MaximumLength(100).WithMessage("Description must be less than 200 symblos");
            RuleFor(c => c.StartDate).NotEmpty().WithMessage("Start date must not be null");
            RuleFor(c => c.Hours).LessThan(72).GreaterThan(0).WithMessage("Task hours mush be greater than 0 and less than 72");
            RuleFor(c => c.Status).NotEmpty().WithMessage("Status must not be null");
            RuleFor(c => c.Priority).NotEmpty().WithMessage("Priority must not be null");
        }
    }
}

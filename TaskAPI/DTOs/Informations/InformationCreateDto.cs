﻿using FluentValidation;
using TaskAPI.DTOs.Sliders;

namespace TaskAPI.DTOs.Informations
{
    public class InformationCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class InformationCreateDtoValidator : AbstractValidator<InformationCreateDto>
    {
        public InformationCreateDtoValidator()
        {
            RuleFor(m => m.Title)
                .NotEmpty()
                .WithMessage("Title is required")
                .MaximumLength(50)
                .WithMessage("Title can be max 50 characters");

            RuleFor(m => m.Description)
                .NotEmpty()
                .WithMessage("Description is required")
                .MaximumLength(200)
                .WithMessage("Description can be max 200 characters");

            RuleFor(m => m.Icon)
                .NotEmpty()
                .WithMessage("Icon is required");
        }
    }
}

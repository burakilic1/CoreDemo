using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş bırakılmamalı.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini boş bırakılmamalı.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş bırakılmamalı.");
            RuleFor(x => x.BlogTitle).MaximumLength(250).WithMessage("Lütfen 250 karakterden daha az veri girişi"); 
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 4 karakterden daha fazla veri girişi yapınız.");
        }
    }
}

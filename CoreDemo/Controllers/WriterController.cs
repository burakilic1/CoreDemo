﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{

    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNabvarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var values = wm.TGetById(1);
            return View(values);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            var pas1 = Request.Form["pass1"];
            var pas2 = Request.Form["pass2"];
            if (pas1 == pas2)
            {
                writer.WriterPassword = pas2;
                WriterValidator validationRules = new WriterValidator();
                ValidationResult result = validationRules.Validate(writer);
                if (result.IsValid)
                {
                    wm.TUpdate(writer);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
            }
            else
            {
                ViewBag.hata = "Girdiğiniz Parolalar Uyuşmuyor!";
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.WriterImage !=null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream= new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;  
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}

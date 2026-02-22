using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OarabileMarwane_CV.Data;
using OarabileMarwane_CV.ViewModel;
using OarabileMarwane_CV.Models;


using System;


namespace OarabileMarwane_CV.Controllers
{
    public class CvController : Controller
    {
        //secret, protect and only acces a copy of DBconext not actual 
        private readonly AppDbContext _db;
        public CvController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var viewModel = new FullCvViewModel
            {
                ContactInfo = _db.ContactInfos.FirstOrDefault(),
                Experiences = _db.Experiences.ToList(),
                Projects = _db.Projects.ToList(),
                Skills = _db.Skills.ToList(),
                Educations = _db.Educations.ToList(),
                Certifications = _db.Certifications.ToList()
            };

            return View("FullCv", viewModel);
        }
    }
}

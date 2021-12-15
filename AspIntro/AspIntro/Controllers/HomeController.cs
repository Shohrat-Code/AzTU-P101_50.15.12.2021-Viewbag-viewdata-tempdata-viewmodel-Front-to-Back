using AspIntro.Models;
using AspIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspIntro.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Rasim",
                Surname = "Quliyev",
                Age = 25,
                Email = "rasim@gmail.com"
            };

            Student student2 = new Student()
            {
                Id = 2,
                Name = "Qasim",
                Surname = "Abbasov",
                Age = 22,
                Email = "qasim@gmail.com"
            };

            Student student3 = new Student()
            {
                Id = 3,
                Name = "Abbas",
                Surname = "Agayev",
                Age = 32,
                Email = "abbas@gmail.com"
            };

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);


            Group group1 = new Group()
            {
                Id = 1,
                Name = "AzTU-P101"
            };

            Group group2 = new Group()
            {
                Id = 2,
                Name = "P221"
            };

            List<Group> groups = new List<Group>();
            groups.Add(group1);
            groups.Add(group2);

            VmStuGroup model = new VmStuGroup();
            model.Students = students;
            model.Groups = groups;

            return View(model);
        }

        public IActionResult Create()
        {
            Group group1 = new Group()
            {
                Id = 1,
                Name = "AzTU-P101"
            };

            return View(group1);
        }


    }
}

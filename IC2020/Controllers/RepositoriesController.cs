﻿using IC2020.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IC2020.Controllers
{
    public class RepositoriesController : Controller
    {
        private AuxOperations _operations = new AuxOperations();

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult DashBoard(string usuario, string repositorio)
        {
            var url = "https://api.github.com/repos/" + usuario + "/" + repositorio + "/releases";
            var result = _operations.GetStrFromJson(url);
            var myRepos = JsonConvert.DeserializeObject<List<Item>>(result);
            return View(myRepos);
        }

        //public IActionResult GetNameRepo()
        //{
           
            
        //}


        public ActionResult Report()
        {
            return View();
        }
        public ActionResult ReportResult()
        {
            return View();
        }




    }
}
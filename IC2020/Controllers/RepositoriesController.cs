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
            var url = "https://api.github.com/repos/" + usuario + "/"+ repositorio + "/releases";
            var result = _operations.GetStrFromJson(url);
            var myRepos = JsonConvert.DeserializeObject<List<Item>>(result);
            return View();
        }
        public ActionResult Report()
        {
            return View();
        }
        public ActionResult ReportResult()
        {
            return View();
        }

        [DisableRequestSizeLimit]
        public IActionResult MyRepositories()
        {
            return View();
        }
        public IActionResult MyRepositoriesResult(string key)
        {
            var url = "https://api.github.com/users/" + key + "/repos";
            var result = _operations.GetStrFromJson(url);
            var myRepos = JsonConvert.DeserializeObject<List<Item>>(result);

            return View(myRepos);
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult SearchResult(string key)
        {
            var url = "https://api.github.com/search/repositories?q=" + key.ToLower();
            var searchResult = _operations.GetStrFromJson(url);
            var repos = JsonConvert.DeserializeObject<Repos>(searchResult);

            return View(repos);
        }     

        public IActionResult Favorites(Item fav)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Itens.InsertOne(fav);

            return View();
        }

        [DisableRequestSizeLimit]
        public IActionResult RepInfo(Item i)
        {
            var collabsUrl = i.contributors_url;
            var collabs = JsonConvert.DeserializeObject<List<Collabs>>(_operations.GetStrFromJson(collabsUrl));           
            var objs = new ObjStructure();
            objs.generalInfo = i;
            objs.collaborators = collabs;

            return View(objs);
        }
    }
}
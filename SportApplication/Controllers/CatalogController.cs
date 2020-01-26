using Microsoft.AspNetCore.Mvc;
using SportApplication.Models.Catalog;
using SportApplicationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportApplication.Controllers
{
    public class CatalogController:Controller
    {
        private readonly ISport _sport;

        public CatalogController(ISport sports)
        {
            _sport = sports;
        }

        public IActionResult Index()
        {
            var sportModels = _sport.GetAll();
            var listingResult = sportModels
                .Select(result => new SportIndexListModel 
                { 
                    Id = result.Id,
                    Name = result.Name,
                    Individual = result.Individual,
                    Category = result.Category
                });
            var model
                 = new SportIndexModel()
                 {
                     Sports = listingResult
                 };
            return View(model);
        }
    }
}

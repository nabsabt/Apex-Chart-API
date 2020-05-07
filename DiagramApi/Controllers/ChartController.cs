using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.UI.WebControls;
using DiagramApi.Models;
using DiagramApi.ViewModels;

namespace DiagramApi.Controllers
{
    public class ChartController : ApiController
    {

        private ApplicationDbContext _context;

        public ChartController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public ChartViewModel Index()
        {


            ChartViewModel viewModel = new ChartViewModel();

            foreach(var item in _context.Charts)
            {
                viewModel.Countries.Add(item.Countries);
                viewModel.Population.Add(item.Population);
            }



            return viewModel;
        }
    }
}

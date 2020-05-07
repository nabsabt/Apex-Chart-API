using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiagramApi.Models
{
    public class ChartModel

    {
        public int Id { get; set; }
        public String Countries { get; set; }
        public int Population { get; set; }

        /*
        public List<String> Countries = new List<String>();
        public List<int> Population = new List<int>();
        */
    }
}
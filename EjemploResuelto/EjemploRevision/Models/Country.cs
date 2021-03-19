using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploRevision.Models
{
    public class Country
    {
        [key]
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<double> Latlng { get; set; }
        public List<string> Timezones { get; set; }
        public string Flag { get; set; }
    }
}
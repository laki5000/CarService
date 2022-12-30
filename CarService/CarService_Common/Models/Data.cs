using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService_Common.Models
{
    public class Data
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string PlateNumber { get; set; }
        public int ManufactureYear { get; set; }
        public string WorkCategory { get; set; }
        public string Description { get; set; }
        public int Seriousness { get; set; }

        public string Status { get; set; }

        public double WorkHourEstimation { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Type} - {PlateNumber} - {ManufactureYear} - {WorkCategory} - {Description} - {Seriousness} - {Status} - ETA: {WorkHourEstimation}";
        }


    }
}
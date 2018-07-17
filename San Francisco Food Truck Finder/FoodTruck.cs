using System;
using System.Collections.Generic;
using System.Text;

namespace SanFranFoodTrucks
{
    class FoodTruck
    {
        //Models information associated with each food truck and food cart contained within JSON file
        public string DayOfWeekStr{ get; set; }
        public string Applicant { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public string Location { get; set; }
    }
}

using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class TimeFactory
    {
        public static Time create(int showId, DateTime date, bool avail)
        {
            Time newTime = new Time();
            newTime.ShowId = showId;
            newTime.ShowTime = date;
            newTime.Availablity = avail; 
            
            return newTime;
        }
    }
}
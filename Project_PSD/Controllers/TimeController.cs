using Project_PSD.Handlers;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controllers
{
    public class TimeController
    {
        public static List<Time> GetAvailableShowTimeListAndDate(int showId, DateTime date)
        {
            TimeHandler.CreateDefault(showId, date);
            TimeHandler.UpdateHourAvailability(showId, date);
            return TimeHandler.GetShowTimeListByShowIdAndDate(showId, date);   
        }

        public static bool TimeOrdered(int timeId)
        {
            return TimeHandler.TimeOrdered(timeId);
        }
        public static Time GetTimeById(int timeId)
        {
            return TimeHandler.GetTimeById(timeId);
        }
    }
}
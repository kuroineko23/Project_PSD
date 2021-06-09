using Project_PSD.Factories;
using Project_PSD.Models;
using Project_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handlers
{
    public class TimeHandler
    {
        public static List<Time> GetShowTimeListByShowIdAndDate(int showId, DateTime date)
        {
            List<Time> Showtime = TimeRepository.GetShowTimeListByShowId(showId);

            List<Time> curr = new List<Time>();

            for(int i=0; i<Showtime.Count; i++) //bikin disini krna di repository nggak bisa date.Date.. LINQ not recognize blablabla
            {
                if (Showtime[i].ShowTime.Date.Equals(date.Date))
                {
                    curr.Add(Showtime[i]);
                }
            }

            return curr;
        }

        public static bool CreateDefault(int showId, DateTime date)
        {
            List<Time> notAvailable = GetShowTimeListByShowIdAndDate(showId, date);
            DateTime curr = date;

            if (notAvailable.Count() == 0)
            {
                for (int i = 0; i < 24; i++)
                {
                    Time newTime = TimeFactory.create(showId, curr, true);
                    TimeRepository.Insert(newTime);
                    curr = curr.AddHours(1);
                }
            }
            else
            {
                int j = 0, i = 0;
                int maxJ = notAvailable.Count();
                if(maxJ == 24)
                {
                    return true;
                }
                while (i < 24 || j < maxJ) 
                {
                    if (curr.Hour != notAvailable[j].ShowTime.Hour)
                    {
                        if(curr.Hour < notAvailable[j].ShowTime.Hour)
                        {
                            Time newTime = TimeFactory.create(showId, curr, true);
                            TimeRepository.Insert(newTime);
                            curr = curr.AddHours(1);
                            i++;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else
                    {
                        i++; j++;
                    }
                }
                
            }
            return true;
        }

        public static bool UpdateHourAvailability(int showId, DateTime date)
        {
            List<Time> TodayShow = GetShowTimeListByShowIdAndDate(showId, date);
            DateTime now = DateTime.Now;

            for (int i = 0; i < 24; i++)
            {
                Time t = TimeRepository.GetTimeById(TodayShow[i].Id);
                if(t != null)
                {
                    if(now > t.ShowTime)
                    {
                        t.Availablity = false;
                        TimeRepository.UpdateTime(t);
                    }
                }
            }
            return true;
        }
        public static bool TimeOrdered(int timeId)
        {
            Time t = TimeRepository.GetTimeById(timeId);
            if (t != null)
            {
                t.Availablity = false;
                TimeRepository.UpdateTime(t);
            }
            return true;
        }

        public static Time GetTimeById(int timeId)
        {
            return TimeRepository.GetTimeById(timeId);
        }
    }
}
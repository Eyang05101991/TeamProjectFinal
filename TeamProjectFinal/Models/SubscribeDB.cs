using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProjectFinal.Models
{
    public static class SubscribeDB
    {
        public static void Subsribe(Subscriber s)
        {
            TeamProjectFinalDB db = new TeamProjectFinalDB();
            db.Subscribers.Add(s);
            db.SaveChanges();

        }
    }
}
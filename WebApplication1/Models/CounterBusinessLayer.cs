using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccessLayer;

namespace WebApplication1.Models
{
    public class CounterBusinessLayer
    {
        public int GetMax()
        {
            CounterDAL test = new CounterDAL();
            return test.Counters.Max(x => x.CounterCount);
        }

        public Counter SaveCounter(Counter c)
        {
            CounterDAL test = new CounterDAL();
            test.Counters.Add(c);
            test.SaveChanges();
            return c;
        }

        public bool Delete()
        {
            try
            {
                CounterDAL test = new CounterDAL();
                test.Database.ExecuteSqlCommand("TRUNCATE TABLE TblCounter");
                DefaultValue();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool DefaultValue()
        {
            Counter defData = new Counter();
            defData.CounterCount = 1;
            SaveCounter(defData);
            return true;
        }
    }
}
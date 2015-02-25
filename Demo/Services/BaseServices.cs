using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Demo.Services
{
    public class BaseServices
    {
        private Random _rnd;

        public BaseServices()
        {
            this._rnd = new Random();
        }

        protected string RandomString(int size = 10)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * this._rnd.NextDouble() + 65))));
            }

            return builder.ToString();
        }

        protected DateTime RandomDateTime()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(this._rnd.Next(range));
        }

        protected int RandomInteger(int min = int.MinValue, int max = int.MaxValue)
        {
            return this._rnd.Next(min, max);
        }

        protected double RandomDouble(double min = double.MinValue, double max = double.MaxValue)
        {
            return min + (this._rnd.NextDouble() * (max - min));
        }
    }
}
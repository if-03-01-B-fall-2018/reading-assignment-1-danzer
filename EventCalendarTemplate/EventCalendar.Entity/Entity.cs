using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendar.Entity
{
    public class Entity
    {
        private string _title;
        private string _date;
        private int _maxVisitors;

        public Entity(string _title, string _date, int _maxVisitors)
        {
            this._title = _title;
            this._date = _date;
            this._maxVisitors = _maxVisitors;
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int maxVisitors
        {
            get { return maxVisitors; }
            set { _maxVisitors = value; }
        }
    }
}

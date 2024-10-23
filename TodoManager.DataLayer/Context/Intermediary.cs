using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager.DataLayer.Context
{
    public static class Intermediary // get value from login form and send to other forms.
    {
        private static int _userId;
        public static int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class SaveLoginForm
    {
        private static string _beforForm;

        public static string BeforForm
        {
            get { return _beforForm; }
            set { _beforForm = value; }
        }
    }
}


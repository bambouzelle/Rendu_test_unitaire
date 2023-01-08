using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console
{
    public class SystemLang
    {
        public CultureInfo _currentCulture;

        public string Getsystemlang()
        {
            return _currentCulture.Name;
        }
    }
}

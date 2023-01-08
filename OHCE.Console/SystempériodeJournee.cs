using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console
{
    public class SystempériodeJournee
    {
        private TimeSpan _matinDebut;
        private TimeSpan _matinFin;
        private TimeSpan _apresMidiDebut;
        private TimeSpan _apresMidiFin;
        private TimeSpan _soirDebut;
        private TimeSpan _soirFin;

        public SystempériodeJournee (TimeSpan matinDebut, TimeSpan matinFin, 
            TimeSpan apresMidiDebut, TimeSpan apresMidiFin, TimeSpan soirDebut, TimeSpan soirFin)
        {
            _matinDebut = matinDebut;
            _matinFin = matinFin;
            _apresMidiDebut = apresMidiDebut;
            _apresMidiFin = apresMidiFin;
            _soirDebut = soirDebut;
            _soirFin = soirFin;
        }
        public string GetPeriodeJournee()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            if (currentTime >= _matinDebut && currentTime < _matinFin)
            {
                return "matin";
            }
            else if (currentTime >= _apresMidiDebut && currentTime < _apresMidiFin)
            {
                return "après-midi";
            }
            else if (currentTime >= _soirDebut && currentTime < _soirFin)
            {
                return "soir";
            }
            else
            {
                return "nuit";
            }
        }
    }
        
}

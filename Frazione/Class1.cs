using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Frazione
    {
        //attributi
        private double _nominatore;
        private double _denominatore;

        //costruttore
        public Frazione()
        {
            Nominatore = 0;
            Denominatore = 1;
        }

        //costruttore di copia
        public Frazione(Frazione frazPrec)
        {
            Nominatore = frazPrec.Nominatore;
            Denominatore = frazPrec.Denominatore;
        }

        //metodo di semplificazione della frazione
        private double semplificaFrazione(double nom, double denom)
        {
            return nom / denom;
        }

        //metodo di somma di due frazioni
        public double Somma(double nom, double denom)
        {
            return semplificaFrazione(nom, denom) + semplificaFrazione(Nominatore, Denominatore);
        }

        //properties attributi
        double Denominatore
        {
            get { return _denominatore; }
            set { if (value != 0) _denominatore = value; }
        }

        double Nominatore
        {
            get { return _nominatore; }
            set { _nominatore = value; }
        }
    }
}

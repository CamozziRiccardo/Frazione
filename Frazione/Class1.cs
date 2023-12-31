﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Frazione
    {
        //attributi
        protected double _nominatore;
        protected double _denominatore;

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
        protected virtual double semplificaFrazione(double nom, double denom)
        {
            return nom / denom;
        }

        //metodo che trasforma un numero decimale in una frazione
        private double[] desemplificaFrazione(double decimale)
        {
            double[] fraz = new double[1];
            string str = decimale.ToString();
            double moltiplicatore = 1;
            for (int i = 0; i < str.Length; i++)
            {
                moltiplicatore *= 10;
            }
            decimale *= moltiplicatore;
            fraz[0] = decimale;
            fraz[1] = moltiplicatore;
            return fraz;
        }

        //metodo di somma di due frazioni
        public double []Somma(double nom, double denom)
        {
            return desemplificaFrazione(semplificaFrazione(nom, denom) + semplificaFrazione(Nominatore, Denominatore));
        }

        //metodo di sottrazione di due frazioni
        public double []sottrazione(double nom, double denom)
        {
            if (semplificaFrazione(nom, denom) < semplificaFrazione(Nominatore, Denominatore))
            {
                return desemplificaFrazione(semplificaFrazione(Nominatore, Denominatore) - semplificaFrazione(nom, denom));
            }
            else
            {
                return desemplificaFrazione(semplificaFrazione(nom, denom) - semplificaFrazione(Nominatore, Denominatore));
            }
        }

        //metodo di moltiplicazione tra due frazione
        public double []moltiplicazione(double nom, double denom)
        {
            return desemplificaFrazione(semplificaFrazione(nom, denom) * semplificaFrazione(Nominatore, Denominatore));
        }

        //metodo di divisione tr due frazioni
        public double []divisione(double nom, double denom)
        {
            return desemplificaFrazione(semplificaFrazione(nom, denom) / semplificaFrazione(Nominatore, Denominatore));
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

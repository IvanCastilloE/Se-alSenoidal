﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeñalSenoidal
{
    class SeñalSenoidal
    {
        //Auto Properties
        //Atributos encapsulados de c#
        //no tienen rutinas al establecer u obtener valor
        public double Amplitud { get; set; }
        public double Fase { get; set; }
        public double Frecuencia { get; set; }

        //Constructor se ejecuta al instanciar la clase, sintaxis: public NombreDeLaClase(parametros)
        public SeñalSenoidal()
        {
            Amplitud = 1.0;
            Fase = 0.0;
            Frecuencia = 1.0;
        }
        public SeñalSenoidal(double amplitud,double fase,double frecuencia)
        {
            Amplitud = amplitud;
            Fase = fase;
            Frecuencia = frecuencia;
        }
        public double evaluar(double tiempo)
        {
            double resultado = 0.0;
            //Evaluar la función
            resultado = Amplitud * (Math.Sin((2.0 * Math.PI * Frecuencia * tiempo) + Fase));

            return resultado;
        }
    }
}

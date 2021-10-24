using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class Cuadrado
    {
        private double lado;

        public Cuadrado() { 
        }

        public Cuadrado(double lado) {
            this.lado = lado;
        }

        public double getLado() {
            return lado;
        }

        public void setLado(double lado) {
            this.lado = lado;
        }
        public String toString()
        {
            return "Cuadrado:\n" + "Lados c/u= " + lado;
        }

        public double CalcularArea() {
            double area = 0;

            area = lado * lado;

            return area;
        }

        public double CalcularPerimetro() {
            double perimetro = 0;

            perimetro = lado + lado + lado + lado; //lado*4

            return perimetro;
        }

    }
}

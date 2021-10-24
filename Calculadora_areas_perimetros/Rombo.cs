using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class Rombo
    {
        private double lado;
        private double diagonal1;
        private double diagonal2;

        public Rombo() { 
        }

        public Rombo(double lado, double D, double d) {
            this.lado = lado;
            diagonal1 = D;
            diagonal2 = d;
        }

        public double getLado()
        {
            return lado;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }
        public double getDiagonal1()
        {
            return diagonal1;
        }

        public void setDiagonal1(double diagonal1)
        {
            this.diagonal1 = diagonal1;
        }
        public double getDiagonal2()
        {
            return diagonal2;
        }

        public void setDiagonal2(double diagonal2)
        {
            this.diagonal2 = diagonal2;
        }
        public String toString()
        {
            return "Rombo:\n" + "Lados c/u= " + lado + ", diagonal 1= " + diagonal1 + ", diagonal 2= " + diagonal2;
        }

        public double CalcularArea() {
            double area = 0;

            area = diagonal1 * diagonal2;

            return area;
        }

        public double CalcularPerimetro() {
            double perimetro = 0;

            perimetro = lado + lado + lado + lado; //lado*4

            return perimetro;
        }
    }
}

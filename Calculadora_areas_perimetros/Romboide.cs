using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class Romboide
    { 
        private double basee;
        private double altura;
        private double lado;

        public Romboide()
        {
        }

        public Romboide(double basee, double altura, double lado)
        {
            this.basee = basee;
            this.altura = altura;
            this.lado = lado;
        }
        public double getBasee()
        {
            return basee;
        }

        public void setBasee(double basee)
        {
            this.basee = basee;
        }
        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getLado()
        {
            return lado;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public String toString()
        {
            return "Romboide:\n" + "Base= " + basee + "\nAltura= " + altura + "\nLado= " + lado;
        }

        public double CalcularArea()
        {
            double area = 0;

            area = basee * altura;

            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 0;

            perimetro = basee + basee + lado + lado; //(basee * 2) + (lado * 2)

            return perimetro;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class Triangulo
    {
        private double basee;
        private double altura;
        private double lado1;
        private double lado2;
    
        public Triangulo() { 
        }

        public Triangulo(double basee, double altura, double lado1, double lado2) {
            this.basee = basee;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
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

        public double getLado1()
        {
            return lado1;
        }

        public void setLado1(double lado1)
        {
            this.lado1 = lado1;
        }
        public double getLado2()
        {
            return lado2;
        }

        public void setLado2(double lado2)
        {
            this.lado2 = lado2;
        }

        public String toString()
        {
            return "Ractangulo:\n" + "Base= " + basee + ", altura= " + altura + ", lado 1= " + lado1 +
                    ", lado 2= " + lado2;
        }

        public double CalcularArea() {
            double area = 0;

            area = (basee * altura) / 2;

            return area;
        }

        public double CalcularPerimetro() {
            double perimetro = 0;

            perimetro = basee + lado1 + lado2;

            return perimetro;
        }
    }
}

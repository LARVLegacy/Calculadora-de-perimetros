using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class Trapecio
    {
        private double base_menor;
        private double base_mayor;
        private double lado;
        private double altura;

        public Trapecio() { 
        }

        public Trapecio(double b1, double b2, double lado, double altura) {
            base_menor = b1;
            base_mayor = b2;
            this.lado = lado;
            this.altura = altura;
        }

        public double getBase_menor()
        {
            return base_menor;
        }

        public void setBase_menor(double base_menor)
        {
            this.base_menor = base_menor;
        }
        public double getBase_mayor()
        {
            return base_mayor;
        }

        public void setBase_mayor(double base_mayor)
        {
            this.base_mayor = base_mayor;
        }

        public double getLado()
        {
            return lado;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public String toString()
        {
            return "Romboide:\n" + "Base menor= " + base_menor + ", base mayor= " + base_mayor +
                ", lados c/u= " + lado + ", altura= " + altura;
        }

        public double CalcularArea() {
            double area = 0;

            area = (altura * (base_mayor * base_menor)) / 2;

            return area;
        }

        public double CalcularPerimetro() {
            double perimetro = 0;

            perimetro = base_mayor + base_menor + lado + lado; // (lado * 2)

            return perimetro;

        }

    }
}

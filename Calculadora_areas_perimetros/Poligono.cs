using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class Poligono
    {
        private double lado;
        private int numero_lados;
        private double apotema;

        public Poligono() {
        }

        public Poligono(double lado, int numero_lados, double apotema) {
            this.lado = lado;
            this.numero_lados = numero_lados;
            this.apotema = apotema;
        }

        public double getLado()
        {
            return lado;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public double getNumero_lados()
        {
            return numero_lados;
        }

        public void setNumero_lados(int numero_lados)
        {
            this.numero_lados = numero_lados;
        }

        public double getApotema()
        {
            return apotema;
        }

        public void setApotema (double apotema)
        {
            this.apotema = apotema;
        }

        public String toString()
        {
            return "Poligono:\n" + "Lado c/u= " + lado + ", Número de lados= " + numero_lados +
                    ", apotema= " + apotema;
        }

        public double CalcularArea() {
            double area = 0;

            area = (numero_lados * lado * apotema)/2;

            return area;
        }

        public double CalcularPerimetro() {
            double perimetro = 0;

            perimetro = numero_lados * lado;
            
            return perimetro;
        }
    }
}

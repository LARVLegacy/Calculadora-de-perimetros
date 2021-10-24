using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class Circulo
    {
        private double radio;

        public Circulo() { 
        }
        public Circulo(double radio) {
            this.radio = radio;
        }

        public double getRadio()
        {
            return radio;
        }

        public void setRadio(double radio)
        {
            this.radio = radio;
        }

        public String toString()
        {
            return "Circulo:\n" + "Radio= " + radio;
        }

        public double CalcularArea() {
            double area = 0;

            area = System.Math.PI * (radio * radio); //Math.Pow(numero, 2)

            return area;
        }

        public double CalcularPerimetro() {
            double perimetro = 0;

            perimetro = 2 * System.Math.PI * radio;

            return perimetro;
        }
    }
}

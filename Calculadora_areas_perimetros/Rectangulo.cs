using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class Rectangulo
    {
        private double basee;
        private double altura;

        public Rectangulo() { 
        }

        public Rectangulo(double basee, double altura) {
            this.basee = basee;
            this.altura = altura;
        }
        public double getBasee(){
            return basee;
        }

        public void setBasee(double basee){
            this.basee = basee;
        }
        public double getAltura(){
            return altura;
        }

        public void setAltura(double altura){
            this.altura = altura;
        }

        public String toString()
        {
            return "Rectangulo:\n" + "Base= " + basee + "\nAltura= " + altura;
        }

        public double CalcularArea() {
            double area = 0;

            area = basee * altura;

            return area;
        }

        public double CalcularPerimetro() {
            double perimetro = 0;

            perimetro = basee + basee + altura + altura; //(basee * 2) + (altura * 2)

            return perimetro;
        }
    }
}

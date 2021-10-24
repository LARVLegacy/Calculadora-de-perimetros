using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_areas_perimetros
{
    class ClassPrincipal
    {
        static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("▒▒▒▒▒▒▒▓\n" +
                                  "▒▒▒▒▒▒▒▓▓▓\n" +
                                  "▒▓▓▓▓▓▓░░░▓\n" +
                                  "▒▓░░░░▓░░░░▓\n" +
                                  "▓░░░░░░▓░▓░▓\n" +
                                  "▓░░░░░░▓░░░▓\n" +
                                  "▓░░▓░░░▓▓▓▓\n" +
                                  "▒▓░░░░▓▒▒▒▒▓\n" +
                                  "▒▒▓▓▓▓▒▒▒▒▒▓\n" +
                                  "▒▒▒▒▒▒▒▒▓▓▓▓\n" +
                                  "▒▒▒▒▒▓▓▓▒▒▒▒▓\n" +
                                  "▒▒▒▒▓▒▒▒▒▒▒▒▒▓\n" +
                                  "▒▒▒▓▒▒▒▒▒▒▒▒▒▓\n" +
                                  "▒▒▓▒▒▒▒▒▒▒▒▒▒▒▓\n" +
                                  "▒▓▒▓▒▒▒▒▒▒▒▒▒▓\n" +
                                  "▒▓▒▓▓▓▓▓▓▓▓▓▓\n" +
                                  "▒▓▒▒▒▒▒▒▒▓\n" +
                                  "▒▒▓▒▒▒▒▒▓\n");

            do
            {
                Console.WriteLine("Menú de opciones para calcular areas y perimetros\n\n"

                        + "1. Rectangulo.\n"
                        + "2. Cuadrado.\n"
                        + "3. Triangulo.\n"
                        + "4. Rombo.\n"
                        + "5. Trapecio.\n"
                        + "6. Poligono.\n"
                        + "7. Circulo.\n"
                        + "8. Romboide.\n"
                        + "9. Salir\n\n");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Console.WriteLine("Ingrese base del rectangulo");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese altura del rectangulo");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Rectangulo figura1 = new Rectangulo(b, h);

                        double area1 = figura1.CalcularArea();
                        double perimetro1 = figura1.CalcularPerimetro();

                        Console.WriteLine(figura1.toString() + "\nArea= " + area1 + "\nPerimetro= " + perimetro1 + "\n"+
                                          "---------------------------------------------------------------------------\n");

                        break;

                    case 2:

                        Console.WriteLine("Ingrese lado del cuadrado");
                        double lado = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Cuadrado figura2 = new Cuadrado(lado);

                        double area2 = figura2.CalcularArea();
                        double perimetro2 = figura2.CalcularPerimetro();

                        Console.WriteLine(figura2.toString() + "\nArea= " + area2 + "\nPerimetro= " + perimetro2 + "\n" +
                                          "---------------------------------------------------------------------------\n");

                        break;

                    case 3:

                        Console.WriteLine("Ingrese base del triangulo");
                        double b1 = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese altura del triangulo");
                        double h1 = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese lado 1 del triangulo");
                        double l1 = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese lado 2 del triangulo");
                        double l2 = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Triangulo figura3 = new Triangulo(b1, h1, l1, l2);

                        double area3 = figura3.CalcularArea();
                        double perimetro3 = figura3.CalcularPerimetro();

                        Console.WriteLine(figura3.toString() + "\nArea= " + area3 + "\nPerimetro= " + perimetro3 + "\n" +
                                          "---------------------------------------------------------------------------\n");

                        break;

                    case 4:

                        Console.WriteLine("Ingrese lado del rombo");
                        double lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese diagonal 1");
                        double d1 = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese diagonal 2");
                        double d2 = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Rombo figura4 = new Rombo(lado1, d1, d2);

                        double area4 = figura4.CalcularArea();
                        double perimetro4 = figura4.CalcularPerimetro();

                        Console.WriteLine(figura4.toString() + "\nArea= " + area4 + "\nPerimetro= " + perimetro4 + "\n" +
                                          "---------------------------------------------------------------------------\n");

                        break;

                    case 5:

                        Console.WriteLine("Ingrese base menor del trapecio");
                        double base_menor = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese base mayor del trapecio");
                        double  base_mayor= double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese lado del trapecio");
                        double lados = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese altura del trapecio");
                        double altura = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Trapecio figura5 = new Trapecio(base_menor, base_mayor, lados, altura);

                        double area5 = figura5.CalcularArea();
                        double perimetro5 = figura5.CalcularPerimetro();

                        Console.WriteLine(figura5.toString() + "\nArea= " + area5 + "\nPerimetro= " + perimetro5 + "\n" +
                                          "---------------------------------------------------------------------------\n");

                        break;

                    case 6:

                        Console.WriteLine("Ingrese lado del poligono");
                        double lado_p = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese número de lados del poligono");
                        int num_lados = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese apotema del poligono");
                        double apotema = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Poligono figura6 = new Poligono(lado_p, num_lados, apotema);

                        double area6 = figura6.CalcularArea();
                        double perimetro6 = figura6.CalcularPerimetro();

                        Console.WriteLine(figura6.toString() + "\nArea= " + area6 + "\nPerimetro= " + perimetro6 + "\n" +
                                          "---------------------------------------------------------------------------\n");

                        break;

                    case 7:

                        Console.WriteLine("Ingrese radio del circulo");
                        double radio = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Circulo figura7 = new Circulo(radio);

                        double area7 = figura7.CalcularArea();
                        double perimetro7 = figura7.CalcularPerimetro();

                        Console.WriteLine(figura7.toString() + "\nArea= " + area7 + "\nPerimetro= " + perimetro7 + "\n" +
                                          "---------------------------------------------------------------------------\n");

                        break;

                    case 8:

                        Console.WriteLine("Ingrese base del romboide");
                        double base_r = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese altura del romboide");
                        double altura_r = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ingrese lado del romboide");
                        double lado_r = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Romboide figura8 = new Romboide(base_r, altura_r, lado_r);

                        double area8 = figura8.CalcularArea();
                        double perimetro8 = figura8.CalcularPerimetro();

                        Console.WriteLine(figura8.toString() + "\nArea= " + area8 + "\nPerimetro= " + perimetro8 + "\n" +
                                          "---------------------------------------------------------------------------\n");

                        break;

                    case 9:
                        Console.WriteLine("Gracias por usar la calculadora de Alejandro\n\n" +
                                          "────────────────────░███░\n" +
                                          "───────────────────░█░░░█░\n" +
                                          "──────────────────░█░░░░░█░\n" +
                                          "─────────────────░█░░░░░█░\n" +
                                          "──────────░░░───░█░░░░░░█░\n" +
                                          "─────────░███░──░█░░░░░█░\n" +
                                          "───────░██░░░██░█░░░░░█░\n" +
                                          "──────░█░░█░░░░██░░░░░█░\n" +
                                          "────░██░░█░░░░░░█░░░░█░\n" +
                                          "───░█░░░█░░░░░░░██░░░█░\n" +
                                          "──░█░░░░█░░░░░░░░█░░░█░\n" +
                                          "──░█░░░░░█░░░░░░░░█░░░█░\n" +
                                          "──░█░░█░░░█░░░░░░░░█░░█░\n" +
                                          "─░█░░░█░░░░██░░░░░░█░░█░\n" +
                                          "─░█░░░░█░░░░░██░░░█░░░█░\n" +
                                          "─░█░█░░░█░░░░░░███░░░░█░\n" +
                                          "░█░░░█░░░██░░░░░█░░░░░█░\n" +
                                          "░█░░░░█░░░░█████░░░░░█░\n" +
                                          "░█░░░░░█░░░░░░░█░░░░░█░\n" +
                                          "░█░█░░░░██░░░░█░░░░░█░\n" +
                                          "─░█░█░░░░░████░░░░██░\n" +
                                          "─░█░░█░░░░░░░█░░██░█░\n" +
                                          "──░█░░██░░░██░░█░░░█░\n" +
                                          "───░██░░███░░██░█░░█░\n" +
                                          "────░██░░░███░░░█░░░█░\n" +
                                          "──────░███░░░░░░█░░░█░\n" +
                                          "──────░█░░░░░░░░█░░░█░\n" +
                                          "──────░█░░░░░░░░░░░░█░\n" +
                                          "──────░█░░░░░░░░░░░░░█░\n" +
                                          "──────░█░░░░░░░░░░░░░█░");
                        Console.ReadLine();
                        option = 9;
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta, vuelve a intentar nuevamente\n");
                        break;
                }

            } while (option != 9);

        }
    }
}

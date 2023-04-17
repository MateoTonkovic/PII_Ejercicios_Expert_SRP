using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Libro libro1 = new Libro("Design Patterns", "Erich Gamma & Others", "001-034");
            Libro libro2 = new Libro("Pro C#", "Troelsen", "001-035");


            Sector sector1 = new Sector();
            Sector sector2 = new Sector();

            Estante estante1 = new Estante();
            Estante estante2 = new Estante();

            estante1.AgregarLibro("7", libro1);
            estante2.AgregarLibro("3", libro2);

            sector1.AgregarEstante("A", estante1);
            sector2.AgregarEstante("B", estante2);
        }
    }
}
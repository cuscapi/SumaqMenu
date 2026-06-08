using System;

namespace MenuBonito
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Instanciamos objeto de la clase Sumaq Menu
            SumaqMenu menu = new SumaqMenu("MI MENU");
            menu.AgregarOpcion("Opcion 1");
            menu.AgregarOpcion("Opcion 2");
            menu.AgregarOpcion("Opcion 3");
            menu.AgregarOpcion("Opcion 4");
            menu.AgregarOpcion("Opcion 5");
            menu.AgregarOpcion("Opcion 6");
            menu.MostrarMenu1();
        }
    }
}
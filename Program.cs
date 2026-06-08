using System;

namespace MenuBonito
{
    class Program
    {
        static void Main(string[] args)
        {
            SumaqMenu menu = new SumaqMenu("MIS HERMANOS LOS TONTOS");
            menu.AgregarOpcion("Glados Huarraca ayqui");
            menu.AgregarOpcion("hola cristofer uscaoi baez");
            menu.MostrarMenu1();
        }
    }
}
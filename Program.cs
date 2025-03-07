using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otronose
{
    internal class Program
    {
        public enum Menu
        {
            Agregar=1,Mostrar,Contar,Eliminar,Actualizar
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();

            while (true)
            {
                switch (menu())
                {
                    case Menu.Agregar:
                        acciones.AgregarAuto();
                        break;
                    case Menu.Mostrar:
                        acciones.MostrarAutos();
                        break;
                    case Menu.Contar:
                        Console.WriteLine(acciones.ContarAutomoviles());
                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Dame la marca a eliminar");
                        string Marca = Console.ReadLine();
                        acciones.EliminarAutomovil(Marca);
                        break;
                    case Menu.Actualizar:
                        Console.WriteLine("Dame la marca a actualizar");
                        string actualizar = Console.ReadLine();
                        acciones.Actualizar(actualizar);
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1)Agregar autos:");
            Console.WriteLine("2)Mostrar autos:");
            Console.WriteLine("3)Contar autos:");
            Console.WriteLine("4)Eliminar autos:");
            Console.WriteLine("5)ACTUALIZAR:");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}

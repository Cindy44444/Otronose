using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otronose
{
    //Cindy
    internal class Acciones
    {
        public List<Automovil> listaautomovil = new List<Automovil>();
        Automovil a = new Automovil();

        public void AgregarAuto()
        {
            Console.WriteLine("Marca:");
            a.Marca= Console.ReadLine();
            Console.WriteLine("Modelo:");
            a.Modelo= Console.ReadLine();
            Console.WriteLine("Año:");
            a.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No. Puertas:");
            a.NOpuertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Color:");
            a.Color= Console.ReadLine();


            listaautomovil.Add(new Automovil(a.Marca,a.Modelo,a.Año,a.NOpuertas,a.Color));

        }

        public void MostrarAutos()
        {
            foreach(var auto in listaautomovil)
            {
                Console.WriteLine($"Marca{auto.Marca}");
                Console.WriteLine($"Modelo:{auto.Modelo}");
                Console.WriteLine($"Año:{auto.Año}");
                Console.WriteLine($"No. Puertas:{auto.NOpuertas}");
                Console.WriteLine($"Color:{auto.Color}");
            }
        }

        public int ContarAutomoviles()
        {
            return listaautomovil.Count;
        }
        public void EliminarAutomovil(string nombremarca)
        {
            var automovil = listaautomovil.Find(x => x.Marca == nombremarca);
            if (automovil != null)
                listaautomovil.Remove(automovil);
            else
                Console.WriteLine("No se encontro tu automovil");
        }
        public void Actualizar(string nombremarca)
        {
            var automoviles = listaautomovil.Find(x => x.Marca == nombremarca);

            if (automoviles != null)
            {
                automoviles.Marca = Console.ReadLine();
                automoviles.Modelo = Console.ReadLine();
                automoviles.Año = Convert.ToInt32(Console.ReadLine());
                automoviles.NOpuertas = Convert.ToInt32(Console.ReadLine());
                automoviles.Color = Console.ReadLine();

                Console.WriteLine("Codigo exitoso");
            }
            else
            {
                Console.WriteLine("No se encontró ningún automóvil con esa marca.");
            }
        }
    }
    
}

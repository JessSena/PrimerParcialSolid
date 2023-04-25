using System;
using System.Collections.Generic;

namespace primer_parcial_solid_transporte
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ITransporte> transportesAereos = new List<ITransporte>();

            List<ITransporte> transportesTerrestres = new List<ITransporte>();

            TransporteRepository transporteRepository = new TransporteRepository();

            Avion avion1 = new Avion("AVION 01",0,100,0,100);
            transportesAereos.Add(avion1);

            Avion avion2 = new Avion("AVION 02",0,100,0,100);
            transportesAereos.Add(avion2);

            Tren tren1 = new Tren("TREN 01",0,100);
            transportesTerrestres.Add(tren1);

            Console.WriteLine("Inicio del viaje :)");

            foreach (Avion avion in transportesAereos)
            {
                avion.Volar(10);
                transporteRepository.guardar(avion);
            }

            foreach (Tren tren in transportesTerrestres)
            {
               tren.Acelerar(10);
                transporteRepository.guardar(tren);
            }

            Console.WriteLine("Fin del viaje :)");
        }
    }
}

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace AgendaMat

{

    class Program

    {
        static string[,] agenda; 

        static int Contactos = 0;

        static int Contador = 0;



        static void Main(string[] args)

        {
            Contactos = PedirNoContactos();

            agenda = new string[4, Contactos];

            Console.WriteLine("\n");

            GuardarContacto();

            GuardarContacto();

            MostrarContactos();



            BuscarModificarEliminar('b');

            BuscarModificarEliminar('m');

            MostrarContactos();

            BuscarModificarEliminar('e');

            MostrarContactos();





            Console.ReadKey();

        }



        static int PedirNoContactos()

        {

            Console.Write("Cuantos contactos desea agregar: ");

            return int.Parse(Console.ReadLine());

        }



        static string PedirDatos(string linea)

        {

            string dato = "";

            dato = "Ingrese " + linea + " : ";

            return dato;
           

        }
     
        static string Buscardato ()
        {
            string busca = "";
            busca = ("ingrese el nombre del contacto a buscar: ");
            busca = Console.ReadLine();
            return busca;
        }
        static string Modificardato()
        {
            string modifica = "";

            Console.Write("ingrese el nombre del contacto a Modificar: ");
            modifica = Console.ReadLine();
            return modifica;
        }
        static string eliminardato()
        {
            string borrar = "";

            Console.Write("ingrese el nombre del contacto a Borrar: ");
            borrar = Console.ReadLine();
            return borrar;
        }
        
        static void GuardarContacto()

        {

            if (Contador < Contactos)

            {

                Console.Write(PedirDatos("Nombre"));

                agenda[0, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Apellido"));

                agenda[1, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Direccion"));

                agenda[2, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Telefono"));

                agenda[3, Contador] = Console.ReadLine();

                Contador++;

                Console.WriteLine("\n");

            }

            else

            {

                Console.WriteLine("Agenda llena\n");

            }

        }



        static void MostrarContactos()

        {

            for (int f = 0; f < Contador; f++)

            {

                Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f] + "\n");

            }

        }



        static void BuscarModificarEliminar(char tipo)

        {

            string buscar = Buscardato();
            string modifica = Modificardato();
            string borrar = eliminardato();
            for (int f = 0; f < Contactos; f++)

            {

                if (tipo == 'b')
                {

                    if (buscar == agenda[0, f])

                    {

                        Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f]);

                    }

                }

                else if (tipo == 'm')

                {

                    

                    if (modifica == agenda[0, f])

                    {

                        Console.Write(PedirDatos("Nombre"));

                        agenda[0, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Apellido"));

                        agenda[1, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Direccion"));

                        agenda[2, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Telefono"));

                        agenda[3, f] = Console.ReadLine();

                    }

                }

                else

                {
                   
                    if (borrar == agenda[0, f])

                    {

                        agenda[0, f] = " ";

                        agenda[1, f] = " ";

                        agenda[2, f] = " ";

                        agenda[3, f] = " ";

                    }

                }

            }

        }

    }

}





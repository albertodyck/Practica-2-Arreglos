using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar un arreglo de tipo string,nombre ListaNombres, de 10 elementos 
            string[] ListaNombres = new string[10];
            //Solicitar los datos para llenar el arreglo
            Console.WriteLine("Programa de Lista de Nombres en Arreglo");
            for (int i = 0; i < ListaNombres.Length; i++)
            {
                Console.WriteLine($"Teclee el Nombre a guardar: (elemento {i+1} del arreglo)");
                //funcion que valida la lectura de nombre valido(caracteres y espacios) y la coloca en el elemento i del arreglo
                ListaNombres[i]=LeerCadena();
            }

            Console.WriteLine("Ha terminado de capturar los nombres, el arreglo esta lleno, presione una tecla para desplegarlo");
            Console.ReadKey();
            Console.WriteLine();
            foreach (string nombre in ListaNombres)
            {
                Console.WriteLine($"-{nombre}-");
            }
            Console.WriteLine("Presione una tecla para terminar, los datos se perderan");
            Console.ReadKey();
        }


        #region Validacion de Nombre
        public static string LeerCadena()
        {
            string Regresastr = null;
            bool bandera = false;

            do
            {
                bandera = false;
                Regresastr = Console.ReadLine();

                foreach (char ch in Regresastr)
                {
                    if (!char.IsLetter(ch) && ch != 32)
                    {
                        Console.WriteLine("Contiene Caracteres No Validos");
                        Console.WriteLine("Vuelva a Intentar escribir el Nombre");
                        bandera = true;
                    }
                }

            } while (bandera == true);
            return Regresastr;
        }

        #endregion
    }
}

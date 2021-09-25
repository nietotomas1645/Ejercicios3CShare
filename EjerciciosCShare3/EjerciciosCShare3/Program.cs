using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCShare3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Crear un programa, que recorra con un bucle for del 1 al 1000, 
            //    insertando en cada iteración el valor del numero en un ArrayList.una vez acabe el proceso, 
            //    recorreremos ese ArrayList mostrando en consola los números.
 
             ArrayList lista = new ArrayList();
            
            for (var i = 0; i < 1000; i++)
           {
                
                lista.Add(i);
           }

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


            //  2 - Pedir por pantalla 5 nombres, e insertarlo en una Lista(List) una vez insertados, 
            //    se pedirá que introduzcamos un nombre, el programa tendrá que decirnos,
            //    si ese nombre esta contenido en la lista.

            List<string> listaNombres = new List<string>();
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Introduce un nombre:");
                listaNombres.Add(Console.ReadLine());
            }

            Console.WriteLine("Introduce otro nombre");
            var nombre = Console.ReadLine();

            if (listaNombres.Contains(nombre))
            {
                Console.WriteLine("Ese nombre esta contenido en el listado");
            }
            else
            {
                Console.WriteLine("Ese nombre NO esta contenido en el listado");
            }

            Console.ReadKey();

            //  3 - Pedir por pantalla 10 números, que iremos almacenando en un Listado
            //    (o 2 como prefiramos).Al terminar de introducir los números,
            //    tendremos que recorrer el / los listados,
            //    diciéndonos cuanto suman los pares y cuando los impares.


            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            int sumaPares = 0;
            int sumaImpares = 0;

            for (int e = 0; e < 10; e++)
            {
                Console.WriteLine("Introduce un numero");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    pares.Add(numero);
                }
                else
                {
                    impares.Add(numero);
                }
            }

            foreach (var numPares in pares)
            {
                sumaPares = sumaPares + numPares;
            }

            foreach (var numImpares in impares)
            {
                sumaImpares = sumaImpares + numImpares;
            }

            Console.WriteLine($"La suma de los pares es : {sumaPares}");
            Console.WriteLine($"La suma de los impares es : {sumaImpares}");

            Console.ReadKey();

            //4 - Crear un programa nos pida introducir 10 números enteros. esos valores los 
            //    introduciremos en un Listado y  mostraremos el numero mayor y menor,
            //    consultando los valores en el Listado.

            List<int> listadoEnteros = new List<int>();
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Introduce un numero");
                int numero = int.Parse(Console.ReadLine());

                listadoEnteros.Add(numero);
            }

            Console.WriteLine($"El numero mayor en el listado es: {listadoEnteros.Max()}");
            Console.WriteLine($"El numero menor en el listado es: {listadoEnteros.Min()}");
            Console.ReadKey();

            //5 - Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array, dependiendo de 
            //    ese numero de elementos, nos ira pidiendo valores, que introduciremos en el array.una vez introducidos, 
            //    nos pedirá un nuevo valor a insertar y la posición donde queremos insertarla en el array.

            //PENDIENTE ( NO SALIO :c  )
        }
    }
}

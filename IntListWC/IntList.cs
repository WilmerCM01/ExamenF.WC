using System;

namespace IntListWC
{
    class IntList
    {

        public static int[] list = new int[10];
        public static byte contador = 0;

        static void Add(int x){

            if(contador < list.Length){

                list[contador] = x;

                contador+=1;

            }

            if(contador >= list.Length){

                contador = 0;

            }

        }

        static Boolean Remove(int x){

            Boolean verificador = false;
            byte contador = 0;

            for(int i = 0; i < list.Length; i++)
            {
                
                if(list[i] == x && contador == 0){

                    list[i] = 0;
                    verificador = true;
                    contador+=1;

                }

            }

            return verificador;

        }

        static Boolean RemoveAll(int x){

            Boolean verificador = false;

            for(int i = 0; i < list.Length; i++)
            {
                
                if(list[i] == x){

                    list[i] = 0;
                    verificador = true;

                }

            }

            return verificador;

        }

        static Boolean Contains(int x){

            Boolean verificador = false;

            for(int i = 0; i < list.Length; i++)
            {
                
                if(list[i] == x){

                    verificador = true;

                }

            }

            return verificador;

        }

        static int Length(){

            byte contador = 0;

            foreach(var elemento in list)
            {

                if(elemento != 0){

                    contador+=1;

                }
                
            }

            return contador;

        }

        static int[] All(){

            return list;

        }

        static Boolean isEmpty(){

            Boolean verificador = false;
            byte contador = 0;

            for(int i = 0; i < list.Length; i++)
            {
                
                if(list[i] == 0){

                    contador+=1;

                }

            }

            if(contador == list.Length){

                verificador = true;

            }

            return verificador;

        }

        static void Main(string[] args)
        {

            byte acceso = 0;

            while(acceso != 8){

                Console.WriteLine();
                Console.WriteLine("¿Qué acción quiere realizar? Digite '8' si quiere finalizar el programa");
                Console.WriteLine();
                Console.WriteLine("1- Almacenar un elemento en el arreglo.");
                Console.WriteLine("2- Remover una ocurrencia del arreglo.");
                Console.WriteLine("3- Remover todas las ocurrencias del arreglo.");
                Console.WriteLine("4- Verificar si un elemento está en el arreglo.");
                Console.WriteLine("5- Saber la cantidad de elementos almacenados en el arreglo.");
                Console.WriteLine("6- Ver todos los elementos almacenados en el arreglo.");
                Console.WriteLine("7- Verificar si el arreglo está vacío.");
                Console.WriteLine();

                acceso = byte.Parse(Console.ReadLine());

                switch(acceso)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Introduzca un elemento a almacenar: ");
                        int almacenar = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Add(almacenar);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Introduzca la ocurrencia a remover: ");
                        int ocurrencia = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Remove(ocurrencia);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Introduzca la ocurrencia a remover: ");
                        int ocurrencia_all = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        RemoveAll(ocurrencia_all);
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.Write("Introduzca el elemento a verificar: ");
                        int elemento = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if(Contains(elemento)){
                            Console.WriteLine();
                            Console.WriteLine("El elemento se encuentra en el arreglo.");

                        }else{
                            Console.WriteLine();
                            Console.WriteLine("El elemento no se encuentra en el arreglo.");

                        }
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("La cantidad de elementos almacenados es de " + Length());
                        break;
                    case 6:
                        Console.WriteLine();
                        foreach (var elementos in All())
                        {
                            Console.Write(elementos + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        if(isEmpty()){

                            Console.WriteLine();
                            Console.WriteLine("El arreglo está vacío.");

                        }else{

                            Console.WriteLine();
                            Console.WriteLine("El arreglo no está vacío.");

                        }
                        break;
                    
                }
            }

            Console.WriteLine();

        }
    }
}
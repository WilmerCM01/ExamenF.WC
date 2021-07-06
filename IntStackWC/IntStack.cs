using System;

namespace IntStackWC
{
    class IntStack
    {

        public static int[] list = new int[10];
        public static byte contador = 0;

        static void Push_More(int x){

            if(contador < 8){

                list[contador] = x;

                contador+=1;

            }

            if(contador >= 8){

                contador = 0;

            }

        }

        static void Push(int x){

            list[9] = x;

        }

        static int Pop(){

            int valor = list[9];
            list[9] = 0;

            return valor;

        }

        static int Peek(){

            return list[9];

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

        static void Main(string[] args)
        {

            byte acceso = 0;

            while(acceso != 7){

                Console.WriteLine();
                Console.WriteLine("¿Qué acción quiere realizar? Digite '7' si quiere finalizar el programa");
                Console.WriteLine();
                Console.WriteLine("1- Almacenar un elemento en el tope de la pila");
                Console.WriteLine("2- Almacenar un elemento en la pila");
                Console.WriteLine("3- Remover el elemento en el tope de la pila");
                Console.WriteLine("4- Ver el elemento en el tope de la pila");
                Console.WriteLine("5- Verificar si el arreglo está vacío.");
                Console.WriteLine("6- Saber la cantidad de elementos almacenados en el arreglo.");
                Console.WriteLine();

                acceso = byte.Parse(Console.ReadLine());

                switch(acceso)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Introduzca un elemento a almacenar en el tope de la pila: ");
                        int tope = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Push(tope);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Introduzca un elemento a almacenar en la pila: ");
                        int almacenar = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Push_More(almacenar);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Elemento del tope de la pila removido: " + Pop());
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Elemento en el tope de la pila: " + Peek());
                        break;
                    case 5:
                        if(isEmpty()){

                            Console.WriteLine();
                            Console.WriteLine("El arreglo está vacío.");

                        }else{

                            Console.WriteLine();
                            Console.WriteLine("El arreglo no está vacío.");

                        }
                        break;
                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("La cantidad de elementos almacenados es de " + Length());
                        break;

                    
                }
            }

            Console.WriteLine();

        }
    }
}
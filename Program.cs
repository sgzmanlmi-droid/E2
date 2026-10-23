using System;
namespace E2
{
    class Program
    {
        static void Main (string[] args)
        {
            //  Ejercicio 1: Sintaxis de funcion
            // tipo_de_dato_devuelto identificador_funcion(parametros)
            // {
            //Bloque de instrucciones
            // }
            // invocacion 
            int Doble (int numero)
            {
                return numero * 2;
            }
            Devolucion = Doble(5);
            Console.WriteLine($"El doble de 5 es: {Devolucion}");

            // Ejercicio 2
            string FuncionesII (string numero)
            {
                return numero;
            }
            string resultado = FuncionesII("Unidad 2");
            Console.WriteLine(resultado);
            
            // Ejercicio 4
            int FuncionSinParametros()
            {
                return 10;
            }
            int resultado = FuncionSinParametros();
            Console.WriteLine($"Funcion sin parametros : {resultado}");

            // Ejercicio 5


        }
    }
}

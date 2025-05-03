using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {

        int[] arregloDesordenado = { 5, 3, 8, 6, 2, 7, 1, 4, 9 };
        int[] arregloOrdenado = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int objetivo = 7;

        Console.WriteLine($"Arreglo desordenado: [{string.Join(", ", arregloDesordenado)}]");
        Console.WriteLine($"Arreglo ordenado:    [{string.Join(", ", arregloOrdenado)}]");
        Console.WriteLine($"Objetivo a buscar: {objetivo}\n");

        // Ejecutar búsqueda lineal
        int resultadoLineal = BusquedaLineal.Buscar(arregloDesordenado, objetivo);
        Console.WriteLine("[Búsqueda Lineal]");
        Console.WriteLine($"- Resultado: Índice {resultadoLineal}");
        Console.WriteLine($"- Comparaciones realizadas: {arregloDesordenado.Length} (en el peor caso)\n");

        // Ejecutar búsqueda binaria
        int resultadoBinario = BusquedaBinaria.Buscar(arregloOrdenado, objetivo);
        Console.WriteLine("[Búsqueda Binaria]");
        Console.WriteLine($"- Resultado: Índice {resultadoBinario}");
        Console.WriteLine($"- Comparaciones realizadas: {Math.Ceiling(Math.Log2(arregloOrdenado.Length))} (en el peor caso)");
    }
}



public class BusquedaLineal
{

    public static int Buscar(int[] arreglo, int objetivo)
    {

        for (int i = 0; i < arreglo.Length; i++)
        {

            if (arreglo[i] == objetivo)
            {
                return i;
            }
        }


        return -1;
    }
}


public class BusquedaBinaria
{

    public static int Buscar(int[] arreglo, int objetivo)
    {
        int izquierda = 0;
        int derecha = arreglo.Length - 1;

        while (izquierda <= derecha)
        {

            int medio = izquierda + (derecha - izquierda) / 2;


            if (arreglo[medio] == objetivo)
            {
                return medio;
            }

            else if (arreglo[medio] < objetivo)
            {
                izquierda = medio + 1;
            }

            else
            {
                derecha = medio - 1;
            }
        }

        return -1;
    }
}
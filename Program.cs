using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class SonarSweep
{
    static void Main(string[] args)
    {
        // Ruta al archivo de entrada. Asegúrate de que el archivo 'input.txt' esté en el mismo directorio.
        string filePath = "input.txt"; 

        // Leer todas las líneas del archivo, convertirlas a enteros y guardarlas en una lista.
        // Se usa LINQ para simplificar la conversión.
        List<int> measurements = File.ReadAllLines(filePath)
                                     .Select(line => int.Parse(line))
                                     .ToList();

        int increaseCount = 0;

        // Recorrer la lista, empezando desde el segundo elemento (índice 1)
        for (int i = 1; i < measurements.Count; i++)
        {
            // Comparar el número actual con el anterior
            if (measurements[i] > measurements[i - 1])
            {
                increaseCount++;
            }
        }

        // Imprimir el resultado
        Console.WriteLine($"The measure increase count is: {increaseCount}");
    }
}
using System;
using System.IO;
using System.Linq;

// La clase Day1 contendrá la lógica de la solución del Día 1
public class Day1
{
    public void Solve()
    {
        string filePath = "inputDay1.txt";

        // Leer todas las líneas del archivo
        List<int> measurements = File.ReadAllLines(filePath)
            .Select(line => int.Parse(line))
            .ToList();

        int increaseCount = 0;

        // Recorrer la lista para la parte 1 del problema
        // ... (Tu lógica original para la parte 1 va aquí)

        // Recorrer la lista para la parte 2 del problema
        for (int i = 3; i < measurements.Count; i++)
        {
            // Comparar la suma de la ventana actual con la anterior
            if (measurements[i] > measurements[i - 3])
            {
                increaseCount++;
            }
        }

        Console.WriteLine($"The measure increase count is: {increaseCount}");
    }
}
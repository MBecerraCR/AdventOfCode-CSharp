using System;
using System.IO;

public class Day2
{
    public void Solve()
    {
        string filePath = "input.txt";

        string[] commands = File.ReadAllLines(filePath);

        int horizontalPosition = 0;
        int depth = 0;
        

        foreach (string command in commands)
        {
            string[] parts = command.Split(' ');
            string direction = parts[0];
            int value = int.Parse(parts[1]);

            switch (direction)
            {
                case "forward":
                    horizontalPosition += value;
                    
                    break;
                case "down":
                    depth += value;
                    break;
                case "up":
                    depth -= value;
                    break;
            }
        }

        int finalResult = horizontalPosition * depth;

        Console.WriteLine($"Posición horizontal final: {horizontalPosition}");
        Console.WriteLine($"Profundidad final: {depth}");
        Console.WriteLine($"Resultado final (horizontal * depth): {finalResult}");
    }
}
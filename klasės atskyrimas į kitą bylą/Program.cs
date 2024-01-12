// SeqCalculator.cs
using System;
using System.Diagnostics;

class SeqCalculator
{
    private long[] sequence;

    public SeqCalculator(long n)
    {
        sequence = new long[n];
        CalculateSequence(n);
    }

    private void CalculateSequence(long n)
    {
        // Pirmas narys yra 1
        sequence[0] = 1;

        // Skaičiuojame kitus narius
        for (int i = 1; i < n; i++)
        {
            // Narius lyginiais indeksais skaičiuojame kaip dvigubai didesnius už prieš tai esantį narį
            if (i % 2 == 0)
            {
                sequence[i] = sequence[i / 2] * 2;
            }
            // Narius nelyginiais indeksais skaičiuojame kaip prieš tai esantį narį
            else
            {
                sequence[i] = sequence[i - 1];
            }
        }
    }

    public void PrintSequence()
    {
        // Spausdiname sekos narius
        Console.WriteLine("Seka: ");
        foreach (var num in sequence)
        {
            Console.Write(num + " ");
        }

        // Programos veikimo laiko matavimas
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        stopwatch.Stop();

        Console.WriteLine("\nElapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }
}

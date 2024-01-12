// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Nustatome norimą sekos ilgį
        long n = 100; //su tokiu skaiciu, kaip 1000000000000000 programa neveikia

        // Sukuriamas SeqCalculator objektas sukuriantis seką ir iškart ją spausdinantis
        SeqCalculator seqCalculator = new SeqCalculator(n);
        seqCalculator.PrintSequence();
    }
}

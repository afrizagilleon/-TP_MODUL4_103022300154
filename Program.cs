using System;
using TP_MODUL4_103022300154;

class Program
{
    static void Main(string[] args)
    {
        // TABLE DRIVEN: KodePos
        KodePos kp = new KodePos();
        Console.Write("Masukkan nama kelurahan: ");
        string kel = Console.ReadLine();
        string kode = kp.getKodePos(kel);
        Console.WriteLine($"Kode pos {kel} adalah: {kode}");

        
    }
}

using System;

namespace HjulenePaaBussen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sangtekst sangtekst = new();
            sangtekst.UdskrivSangTekst();
            Console.ReadLine();
        }
    }
}
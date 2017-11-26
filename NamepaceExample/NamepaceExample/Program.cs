using System;
using PATA=ProjectA.TeamA;
using PATB=ProjectA.TeamB;

namespace NamepaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PATA.ClassA.print();
            PATB.ClassA c = new PATB.ClassA();
            c.print();
        }
    }
}


﻿using System;
namespace Debugging
{
    class Program

    {
        // Void missing
        static void Main(string[] args)
        {
            // ; missing
            int SNO, MARK1, MARK2, MARK3, AVERAGE, TOTAL;
            string SNAME;
            //" " missing in Consolo . WriteLine
            Console.WriteLine("ENTER THE STUDENT DETAILS");
            Console.WriteLine("ENTER THE STUDENT NO");
            SNO = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE STUDENT NAME");
            SNAME = Console.ReadLine();
            Console.WriteLine(" ENTER THE MARKS OF 3 SUBJECTS ");
            MARK1 = int.Parse(Console.ReadLine());
            MARK2 = int.Parse(Console.ReadLine());
            MARK3 = int.Parse(Console.ReadLine());
            TOTAL = MARK1 + MARK2 + MARK3;
            AVERAGE = TOTAL / 3 ;
            Console.WriteLine(";\n\n\nTHE STUDENT DETAILS ARE GIVEN BELOW :");
            Console.WriteLine("THE STUDENT NO IS: " + SNO);
            Console.WriteLine(" THE STUUDENT NAME IS: " + SNAME);
            Console.WriteLine("TOTAL MARKS IS: " + TOTAL);
            Console.WriteLine(" AVEARGE MAARK IS: " + AVERAGE);
            Console.ReadKey();
        }
    }
}
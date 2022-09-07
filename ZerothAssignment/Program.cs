// See https://aka.ms/new-console-template for more information
using System;

namespace ZerothAssignment;

internal class Program {
    static void Main(string[] args) {
        var calender = new GregorianCalender();

        var input = Console.ReadLine();
        if (Int32.TryParse(input, out int number)) {
            if (calender.IsLeapYear(number)) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        } else {
            Console.WriteLine("nay");
        }
    }
}

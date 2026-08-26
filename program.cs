/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    double m, cm;
    
    Console.WriteLine("Ingrese m:");
    m = double.Parse(Console.ReadLine());
    
    cm = m * 100;
    
    Console.WriteLine($"{m:F2} es igual a {cm:F2} centimetros");
    Console.ReadLine();
    
    
  }
}

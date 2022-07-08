using System; 

public class Program {

  public static void Main(String[] args) 
  {
     String[] v = Console.ReadLine().Split(' ');
     double a = double.Parse(v[0]);
     double b = double.Parse(v[1]);
     double c = double.Parse(v[2]);
     double pi = 3.14159;
     double triang = (a * c) / 2;
     double circ = pi *(c * c);
     double trapez = ((a + b) * c) / 2;
     double quad = b * b;
     double retang = a * b;
     Console.WriteLine($"TRIANGULO: {triang:0.000}");
     Console.WriteLine($"CIRCULO: {circ:0.000}");
     Console.WriteLine($"TRAPEZIO: {trapez:0.000}");
     Console.WriteLine($"QUADRADO: {quad:0.000}");
     Console.WriteLine($"RETANGULO: {retang:0.000}");
  }
} 
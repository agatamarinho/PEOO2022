using System; 

public class Program {

  public static void Main(String[] args) 
  {
     double h = double.Parse(Console.ReadLine());
     double km = int.Parse(Console.ReadLine());
     double combustivel =(km*h)/12;
     Console.WriteLine($"{combustivel:0.000}");
  }
} 
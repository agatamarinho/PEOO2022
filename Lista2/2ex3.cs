using System; 

public class Program {

  public static void Main(string[] args) 
  {
     Console.WriteLine("Nota do primeiro bimestre");
     int n1 = int.Parse(Console.ReadLine());
     Console.WriteLine("Nota do segundo bimestre");
     int n2 = int.Parse(Console.ReadLine());
     int p1 = 2;
     int p2 = 3;
     int media = (p1 * n1 + p2 * n2) / (p1+p2);
     Console.WriteLine($"Média parcial {media}");
  }
}

using System; 

public class Program {

  public static void Main(string[] args) 
  {
    Console.WriteLine("Base do retângulo");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Altura do retângulo");
    double h = double.Parse(Console.ReadLine());
    double area = b * h;
    double per = (b * 2) + (h * 2);
    double diag = Math.Sqrt((b * b) + (h * h));
    Console.WriteLine($"Área = {area:0.00} - Perímetro = 
    {per:0.00} - Diagonal = {diag:0.00}");
  }
}

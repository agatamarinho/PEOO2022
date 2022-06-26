using System; 

public class Program {

  public static void Main(String[] args) 
  {
    String[] a = Console.ReadLine().Split(' ');
    int c = int.Parse(a[0]);
    int n = int.Parse(a[1]);
    int termino = (c % n);
    Console.WriteLine(termino);
  }
} 

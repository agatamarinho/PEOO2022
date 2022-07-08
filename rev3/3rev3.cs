using System; 

public class Program {

  public static void Main(String[] args) 
  {
    int v = 1;
    int x = 1;
    while ( v<=10 ){
      Console.Write($"{x*v} ");
      x = -x;
      v++;
    }
  }
} 

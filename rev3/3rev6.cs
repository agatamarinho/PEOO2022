using System; 

public class Program {

  public static void Main(String[] args) 
  {
    int v = 1;
    while (v<=30){
      Console.Write($"{v} ");
      if (v %3 == 0) Console.Write($"{v + v - 1 + v - 2} ");
      v++;
    }
  }
} 

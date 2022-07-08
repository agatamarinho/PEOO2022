using System; 

public class Program {

  public static void Main(String[] args) 
  {
    int v = 1;
    while (v<=30){
      if (v%3==0) Console.Write($"-{v} ");
      else Console.Write(v + " ");
      v++;
    }
  }
} 

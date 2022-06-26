using System; 

public class Program {

  public static void Main(String[] args) 
  {
     String[] T = Console.ReadLine().Split(' ');
     int t1 = int.Parse(T[0]);
     int t2 = int.Parse(T[1]);
     int t3 = int.Parse(T[2]);
     int t4 = int.Parse(T[3]);
     int tomadas = ((t1+t2+t3) - 3)+t4;
      Console.WriteLine(tomadas);
  }
} 
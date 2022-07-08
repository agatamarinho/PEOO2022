using System; 

public class Program {

  public static void Main(String[] args) 
  {
    string f = Console.ReadLine();
    int e = f.IndexOf(' ');
    while (e != -1){
      f = f.Substring(e + 1);
      Console.WriteLine(f);
      e = f.IndexOf(' ');
    }
  }
} 

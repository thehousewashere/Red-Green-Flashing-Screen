using System;

class MainClass {
  public static void Main (string[] args) { 
    
    //Title Screen
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Red");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("&");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Green");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(" Flashing Screen (V.1)");
    Console.WriteLine("By thehousewashere");
    System.Threading.Thread.Sleep(5000);
    
    //Red and Green
    while (1 == 1) {
      Console.BackgroundColor = ConsoleColor.Red;  
      System.Threading.Thread.Sleep(100);
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Green; 
      System.Threading.Thread.Sleep(100);
      Console.Clear();
    }
  }
}
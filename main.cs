using System;

class Program {
  public static void Main (string[] args) {

    decimal money = 0.0m;

    switch (money) {
    case '0.0':
      Console.WriteLine("No Person is found");
      break;
    case '1':
      Console.WriteLine("Jose Rizal");
      break;
    case '5':
      Console.WriteLine("Emilio Aguinaldo");
      break;
    
    }
  }
}
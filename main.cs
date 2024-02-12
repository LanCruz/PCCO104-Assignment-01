using System;

class Program {
  public static void Main (string[] args) {

    decimal money = 500m;

    switch (money) {
    case 0.01m:
      Console.WriteLine("No Person is found");
      break;
    case 0.05m:
      Console.WriteLine("No Person is found");
      break;
    case 0.25m:
      Console.WriteLine("No Person is found");
      break;
    case 1m:
      Console.WriteLine("Jose Rizal");
      break;
    case 5m:
      Console.WriteLine("Emilio Aguinaldo");
      break;
    case 10m:
      Console.WriteLine("Andres Bonifacio, Apolinario Mabini");
      break;
    case 20m:
      Console.WriteLine("Manuel L. Quezon");
      break;
    case 50m:
      Console.WriteLine("Sergio Osmena");
      break;
    case 100m:
      Console.WriteLine("Manuel Roxas");
      break;
    case 200m:
      Console.WriteLine("Diosdado Macapagal");
      break;
    case 500m:
      Console.WriteLine("Benigno Sr. and Corazon Aquino");
      break;
    case 1000m:
      Console.WriteLine("Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda");
      break;
    default:
      Console.WriteLine("Invalid Denomination")
      break;
    }
  }
}
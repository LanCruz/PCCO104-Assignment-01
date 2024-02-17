using System;

class Program {
  public static void Main (string[] args) {

    decimal money = .05m;

    switch (money) {
    case .01m:
    case .05m:
    case .25m:
      Console.WriteLine($"No Person is found in Php. {money}");
      break;
    case 1m:
      Console.WriteLine("Jose Rizal is found in Php. 1");
      break;
    case 5m:
      Console.WriteLine("Emilio Aguinaldo is found in Php. 5");
      break;
    case 10m:
      Console.WriteLine("Andres Bonifacio & Apolinario Mabini is found in Php. 10");
      break;
    case 20m:
      Console.WriteLine("Manuel L. Quezon is found in Php. 20");
      break;
    case 50m:
      Console.WriteLine("Sergio Osmena is found in Php. 50");
      break;
    case 100m:
      Console.WriteLine("Manuel Roxas is found in Php. 100");
      break;
    case 200m:
      Console.WriteLine("Diosdado Macapagal is found in Php. 200");
      break;
    case 500m:
      Console.WriteLine("Benigno Sr. and Corazon Aquino is found in Php. 500");
      break;
    case 1000m:
      Console.WriteLine("Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda is found in Php. 1000");
      break;
    default:
      Console.WriteLine("Invalid Denomination");
      break;
    }
  }
}
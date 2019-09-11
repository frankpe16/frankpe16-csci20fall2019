using System;
class MainClass {
  public static void Main (string[] args)
  
   {//program prompts user to insert temp in Ferenheit
    Console.WriteLine ("Insert a tempertaure in Ferenheit ");
    int Ferenheit= Convert.ToInt32(Console.ReadLine());
//This converts the string to an int and displays input
  
    Console.WriteLine("Kelvin= {0}", Ferenheit - 32/1.8 + 273.15 );
    Console.WriteLine("Celcius= {0}", Ferenheit *18/10+32);
  }//The inputted number then converts input and outputs temps in Fereneheit, Celsius, and Kelvin
}

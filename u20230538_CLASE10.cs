using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
          //Clase numero 10
          //Programa para mostrar el mes segun el numero

          Console.WriteLine("\n**********INICIO DEL MENU**********\n"+
          "* Mes 1 \n"+
          "* Mes 2 \n"+
          "* Mes 3 \n"+
          "* Mes 4 \n"+
          "* Mes 5 \n"+
          "* Mes 6 \n"+
          "\nIngresar el numero del mes del primer semestre del año (1-6):");
          
          int mesNum = Convert.ToInt32(Console.ReadLine());

          string? nombreMes;

          switch(mesNum)
          {
            case 1:
                nombreMes = "Enero";
                break;
          case 2:
                nombreMes = "Febrero";
                break;
            case 3:
                nombreMes = "Marzo";
                break;
            case 4:
                nombreMes = "Abril";
                break;
            case 5:
                nombreMes = "Mayo";
                break;
            case 6:
                nombreMes = "Junio";
                break;
            default:
                Console.WriteLine("Número de mes inválido. Por favor, ingresar un número del 1 al 6.");
                return; // Salir del programa si el número es inválido.        
          } 
          Console.WriteLine("El mes número "+mesNum+" es "+nombreMes+"\n");
          Console.WriteLine("************************FIN DEL PROGRAMA************************");
        }
    }
}
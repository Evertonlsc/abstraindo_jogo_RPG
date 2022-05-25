using System;
using desafio.src.Entities;


namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Knigth arus = new Knigth("Everton", 23, "Knigth");
            Wizard wizard = new Wizard("Felipe", 23, "White Wizard");
            Topapa topapa = new Topapa("Natalia", 23, "Topapa");
            Wedge wedge = new Wedge("Natalia", 23, "Wedge");
   
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(arus.Attack());
            Console.WriteLine(topapa.Attack(4));
            Console.WriteLine(topapa.Attack(6));
            Console.WriteLine(wizard.Attack(5));
            Console.WriteLine(wizard.Attack(7));
            
        
           
        }
    }
}

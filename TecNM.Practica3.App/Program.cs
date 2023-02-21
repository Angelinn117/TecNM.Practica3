using System;
using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Enums;
using TecNM.Practica3.Core.Managers;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.App;

public static class Program
{
    public static void Main(string[] args)
    {

        float grossSalary = 0;
        
        System.Console.WriteLine("Please, enter your gross salary:");
        Single.TryParse(System.Console.ReadLine(), out grossSalary);
        
        var person = new Person{GrossSalary = grossSalary};

        var service = new IsrService();
        var manager = new IsrManager(service);

        ISR isr = manager.GetIsr(person);
        System.Console.WriteLine($"\nGross salary registered: {person.GrossSalary} MXN.");
        System.Console.WriteLine($"Table level: {isr.ISR_Range}.");
        System.Console.WriteLine($"Your ISR is: {isr.IsrResult}\n");
        
        
    }
    
}


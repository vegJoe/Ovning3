using System;
using Ovning3.Prsn;
using Ovning3.UsrErr;
using Ovning3.Animals;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Reflection;

namespace Ovning3
{
    internal class Program
    {
        //Q&A
        //13. I klassen Bird
        //14. Animal
        //3.4 9. Fel typ av objekt
        //3.4 10 Animal
        //3.4 13 Metoden stats i respektive klass kallas och skriver ut de unika variablerna för klassen
        //3.4 17 Metoden finns inte i animal objektet


        /*
         * Main class som skapar objekt och listor och sen bara kallar på metoder
         */
        static void Main(string[] args)
        {
            PersonHandler pHandler = new PersonHandler();
            List<UserError> errors = new List<UserError>();
            List<Animal> animals = new List<Animal>();

            animals = AddAnimals(animals);
            PrintAnimals(animals);
            PrintDog(animals);

            errors = AddErrors(errors);
            CreatePerson(pHandler);
            PrintError(errors);
        }

        /*
         * Printar ut typ av objekt samt ljudet djuret gör från listan med animal obj
         * Utifall att objektet ärver från interfacet IPerson (endast wolfman som gör i detta programmet)
         * då type castar den objektet till Wolfman för att få åtkomst till Talk() metoden
         */
        private static void PrintAnimals(List<Animal> animals)
        {
            foreach(Animal animal in animals)
            {
                if (typeof(IPerson).IsAssignableFrom(animal.GetType()))
                {
                    var wolfman = (animal as Wolfman);
                    Console.WriteLine($"{animal.GetType().Name} says {wolfman!.Talk()}");
                }
                else
                    Console.WriteLine($"{animal.GetType().Name} says {animal.DoSound()}");

            }
        }

        /*
         * Tar emot en lista av Animal, lägger till djur och returnerar listan
         */

        static List<Animal> AddAnimals(List<Animal> animals)
        {
            Dog dog = new Dog { Age = 3, Name = "spot", Weight = 15, HoleDiggingStat = 199};
            Horse horse = new Horse { Age = 12, Name = "flash", Weight = 500, NumOfApplesEaten = 12000 };
            Wolfman wolfman = new Wolfman { Age = 200, Friendly = false, Name = "moonshine", Weight = 170 };

            animals.Add(dog);
            animals.Add(horse);
            animals.Add(wolfman);

            return animals;
        }

        /*
         * Skapar ett Person obj genom PersonHandler klassens konstruktor. Om någon av felcheckarna i Person
         * slår in då skickas ett exception tillbaka och skrivs ut i konsollen
         */
        static void CreatePerson(PersonHandler pHandler)
        {
            try
            {
                pHandler.CreatePerson(10, "test", "test", 10, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static List<UserError> AddErrors(List<UserError> errors)
        {
            NumericInputError numErr = new NumericInputError();
            TextInputError txtErr = new TextInputError();
            errors.Add(numErr);
            errors.Add(txtErr);

            return errors;
        }

        static void PrintError(List<UserError> errors)
        {
            foreach(var err in errors)
            {
                Console.WriteLine(err.UEMessage());
            }
        }

        /*
         * Snarlik PrintAnimals() metoden med skillnaden att den bara kollar om objektet är en Dog, för att sedan casta om
         * och skriva ut en unik metod i dog klassen
         */

        static void PrintDog(List<Animal> animals)
        {
            foreach(Animal animal in animals) 
            {
                if (animal is Dog)
                {
                    var dog = (animal as Dog);
                    Console.WriteLine(dog!.Test());
                }
            }
        }
    }
}

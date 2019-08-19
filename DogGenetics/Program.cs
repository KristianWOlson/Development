using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROMPTS FOR DOG NAME AND STORES IT
            Console.WriteLine("What is your dog's name?");
            string doggoName = Console.ReadLine();

            //REPORT INTRO
            Console.WriteLine("Well then, I have this highly reliable report on " + doggoName + "'s prestigious background right here.");
            Console.WriteLine("");

            //POSSIBLE DOGGO BREEDS
            Random randomizer = new Random();
            string[] doggoBreeds = new string[] { "St. Bernard", "Shi-Tzu", "German Shepherd", "Boxer", "Labrador Retreiver", "Portugese Water Dog", "Basset Hound", "Poodle", "Golden Retreiver", "Greyhound", "Bulldog", "Beagle", "Chihuahua", "Dachshund", "Catdog", "Husky" };
            

            //CALCULATIONS FOR RANDOM DOGGO DNA

            int puppoPercent = 100;
            int maxPercentValue = 96;
            Console.WriteLine(doggoName + " is:");
            for (int i = 0; i < 5; i++)
            {
                if (puppoPercent >= 1 && i < 4)
                {
                    int randomDoggoBreeds = randomizer.Next(0, doggoBreeds.Length);
                    int randomDoggyDNA = randomizer.Next(1, maxPercentValue);
                    Console.WriteLine(randomDoggyDNA + "% " + doggoBreeds[randomDoggoBreeds]);
                    puppoPercent -= randomDoggyDNA;
                    maxPercentValue -= randomDoggyDNA;
                    randomDoggoBreeds++;
                }
                else
                Console.WriteLine(puppoPercent + "% " + doggoBreeds[randomizer.Next(0, doggoBreeds.Length)]);
            }

           

            Console.WriteLine("Wow, that's QUITE the dog!");
        }
    }
}

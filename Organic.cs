using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Organic:Pet
    {
       public Organic(string name, string species, int boredom, int hunger, int health) : base(name, species, boredom, hunger, health)
        {
        }


        public override void SetName()
        {
            Console.Clear();
            Console.WriteLine("Please enter in your pet name of organic pet");
            Name = Console.ReadLine();
            Console.WriteLine($"Your organic pet name is {Name}");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public override void SetSpecies()
        {
            Console.Clear();
            Console.WriteLine("Type in the species of pet you have.");
            Species = Console.ReadLine().ToLower();
            Console.WriteLine($"Your Pets species is a {Species}");
    

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
        public override void PetStats()
        {
            Console.Clear();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Boredom: " + Boredom);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Health: " + Health);

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
        public override void PetStats2()
        {

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Boredom: " + Boredom);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Health: " + Health);

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
        public override void PlayWithPet()
        {



            Console.Clear();
            Console.WriteLine("Start Boredom Level " + Boredom);
            Console.WriteLine("Would you like to play fetch with pet?");
            Console.WriteLine("Y/N");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y")
            {
                Console.WriteLine("You have played fetch with your pet");
                Console.WriteLine("Your boredom level has went down by ten");
                Boredom -= 20;
                Console.WriteLine($"Current Boredom level " + Boredom);
                Console.WriteLine("Your " + Species + " hunger went up");
                Console.WriteLine("Your " + Species + " health increased by 5");
                Hunger += 5;
                Health += 5;

            }
            else if (userInput == "N")
            {
                Console.WriteLine("Your Pet didn't get played with");
                Console.WriteLine("Your pets boredom level has increased by 5");
                Boredom += 5;
            }
            else
            {
                Console.WriteLine("You did not enter Y/N");
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
        public override void Feed()
        {
            Console.Clear();
            Console.WriteLine("Would you like to feed your " + Species + ", " + Name + "?");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y")
            {
                Hunger -= 20;
                Boredom -= 5;
                Health += 5;
                Console.WriteLine("Yummy! Your " + Species + ", " + Name + " is now fed.");
                Console.ReadLine();
            }
            if (userInput == "N")
            {
                Console.WriteLine("Don't forget to feed your " + Species + ", " + Name);
                Console.ReadLine();
            }

        }
        public override void TakePetToVet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to take your pet to see the local Vet");
            Console.WriteLine("Y/N");
            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "Y")
            {
                Console.WriteLine("Your pet feels better now");
                Console.WriteLine("Your " + Species + " boredom has decreased");
                Console.ReadLine();
                Health += 20;
                Boredom -= 5;
            }
            if (userInput == "N")
            {
                Console.WriteLine("Do not forget to take your " + Species + " to get medical care");
                Console.ReadLine();
            }

        }

    }
}


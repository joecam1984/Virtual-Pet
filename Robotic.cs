using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Robotic:Pet
    {
        public Robotic(string name, string species, int boredom, int hunger, int health) : base(name, "Robot", boredom, hunger, health)
        {
        }
        public override void SetName()
        {
            Console.Clear();
            Console.WriteLine("Please enter in your pet name of Robotic pet");
            Name = Console.ReadLine();
            Console.WriteLine($"Your Robotic pet name is {Name}");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public override void SetSpecies()
        {
            Console.Clear();
            Console.WriteLine("You have picked robot Species");
            Species = "Robot";
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
            Console.WriteLine("Pet Robot Name: " + Name);
            Console.WriteLine("Boredom Level: " + Boredom);
            Console.WriteLine("Would you like to play vidoe games with your pet Robot?");
            Console.WriteLine("Y/N");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y")
            {
                Console.WriteLine("You have played video games with your pet");
                Console.WriteLine("Your pet's boredom level has went down by 20");
                Boredom -= 20;
                Console.WriteLine($"Current Boredom level " + Boredom);
                Console.WriteLine("Your " + Species + "'s energy went down");

                Health -= 10;
                Hunger += 5;
                

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
            Console.WriteLine("Would you like to charge your " + Species + ", " + Name + "?");
            Console.WriteLine("Hunger Level: " + Hunger);
            Console.WriteLine("Y/N");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y")
            {
                Hunger -= 20;
                Boredom -= 5;
                
                Console.WriteLine("Ping! Your " + Species + ", " + Name + " is charged up.");
                Console.ReadLine();
            }
            if (userInput == "N")
            {
                Console.WriteLine("Don't forget to charge your " + Species + ", " + Name);
                Console.ReadLine();
            }
            if (Hunger <= 0)
            {
                Console.WriteLine("Your pet robot " + Name + ", is fully cahrged.");
            }
            else
            {
                Console.WriteLine("You did not enter Y/N");
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }
            

        }
        public override void TakePetToVet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to take your pet Robot " + Name + ", to see the local Engineer");
            Console.WriteLine("Y/N");
            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "Y")
            {
                Console.WriteLine("Your pet Robot, " + Name + " feels a lot better now");
                Console.WriteLine("Your " + Species + "'s boredom has decreased");
                Console.ReadLine();
                Health += 20;
                Boredom -= 5;
            }
            if (userInput == "N")
            {
                Console.WriteLine("Do not forget to take your " + Species + " to get a tune up ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You did not enter Y/N");
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }


    }
}

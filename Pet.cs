using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;


namespace template_csharp_virtual_pet
{
    public  class Pet
    {

        //field/Instance
        private string name;
        private string species;
        private int boredom;
        private int hunger;
        private int health;
        
        public string Name;
        public string Species;
        public int Boredom;
        public int Hunger;
        public int Health;

        public Pet(string name, string species, int boredom, int hunger, int health)
        {
            Name = name;
            Species = species;
            Boredom = boredom;
            Hunger = hunger;
            Health = health;
        }

        public virtual void SetName()
        {
            Console.Clear();
            Console.WriteLine("Please enter in your pet name");
            Name = Console.ReadLine();
            Console.WriteLine($"Your Characters name is {Name}");
          

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public Pet()
        {

        }

        public virtual void SetSpecies()
        {
            Console.Clear();
            Console.WriteLine("Type in the species of pet you have.");
            Species = Console.ReadLine().ToLower();
            Console.WriteLine($"Your Pets species is a {Species}");
           

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();


        }
        public virtual void PetStats()
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
        public virtual void PetStats2()
        {
            
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Boredom: " + Boredom);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Health: " + Health);

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
        public virtual void PlayWithPet()
        {
            
            
         
            Console.Clear();
            Console.WriteLine("Pet Name: " + Name);
            Console.WriteLine("Boredom Level: " + Boredom);
            Console.WriteLine("Would you like to play fetch with your pet?");
            Console.WriteLine("Y/N");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y")
            {
                Console.WriteLine("You have played fetch with your pet");
                Console.WriteLine("Your boredom level has went down by ten");
                Boredom -= 20;
                Console.WriteLine($"Current Boredom level " + Boredom) ;
                Console.WriteLine("Your " + Species + "'s hunger went up");
                Console.WriteLine("Your " + Species + "'s health increased by 5");
                Hunger += 5;
                Health += 5;

            }
            else if(userInput == "N") 
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
        public virtual void Tick()
        {
            Hunger+= 5;
            Boredom +=5;
            Health -= 5;
            if (Boredom >= 80)
            {
                Console.WriteLine("Your " + Species + " is getting bored");
                Console.ReadLine();
            }
            if (Hunger >= 80)
            {
                Console.WriteLine("Your Pet " + Name +", is getting Hungry");
                Console.ReadLine();
            }
            if (Health <= 20)
            {
                Console.WriteLine("Your pet " + Name+ ", is in need of Medical Attention");
                Console.ReadLine();
            }
        }
        public virtual void Feed()
        {
            Console.Clear();
            Console.WriteLine("Would you like to feed your " + Species + ", " + Name + "?");
            Console.WriteLine("Hunger Level: " + Hunger);
            Console.WriteLine("Y/N");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Y")
            {
                Hunger -= 20;
                Boredom -= 5;
                Health += 5;
                Console.WriteLine("Yummy! Your " + Species + ", " + Name +  " is now fed.");
                Console.WriteLine(Name + "'s hunger level is now " + Hunger);
                Console.ReadLine();
            }
            if(userInput == "N")
            {
                Console.WriteLine("Don't forget to feed your " + Species + ", " + Name);
                Console.ReadLine();
            }
           
        }
        public virtual void TakePetToVet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to take your pet to see the local Vet?");
            Console.WriteLine("Y/N");
            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "Y")
            {
                Console.WriteLine("Your pet feels better now.");
                Console.WriteLine(Name + "'s health is now: " + Health);
                Console.WriteLine("Your " + Species + " boredom has also decreased'");
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

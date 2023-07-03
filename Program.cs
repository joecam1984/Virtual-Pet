// Your Program Code Here
using System;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Reflection;
using template_csharp_virtual_pet;




{
    Organic myPet = new Organic("", "", 30, 30, 100);
    Organic myPet1 = new Organic("", "", 30, 30, 100);
    Organic myPet2 = new Organic("", "", 30, 30, 100);
    Organic myPet3 = new Organic("", "", 30, 30, 100);
    Organic myPet4 = new Organic("", "", 30, 30, 100);

    Robotic myRobot = new Robotic("", "", 30, 30, 100);
    Robotic myRobot1 = new Robotic("", "", 30, 30, 100);
    Robotic myRobot2 = new Robotic("", "", 30, 30, 100);
    Robotic myRobot3 = new Robotic("", "", 30, 30, 100);
    Robotic myRobot4 = new Robotic("", "", 30, 30, 100);
    

    Shelter shelter = new Shelter();

    shelter.AddPet1(myPet1);
    shelter.AddPet1(myPet2);
    shelter.AddPet1(myPet3);
    shelter.AddPet1(myPet4);
    shelter.AddPet1(myRobot1);
    shelter.AddPet1(myRobot2);
    shelter.AddPet1(myRobot3);
    shelter.AddPet1(myRobot4);

    //List<Organic> organicPetList = new() { myPet1, myPet2, myPet3, myPet4 };
    //List<Robotic> roboticPetList = new() { myRobot1, myRobot2, myRobot3, myRobot4 };
    bool option = true;
    bool createNew = true;
    bool specificPet = false;

    Console.WriteLine("Welcome to Virtual Pet!");
    Console.WriteLine("==============================");
    
    while (createNew)
    {

        Console.WriteLine("Do you want to create an Organic or Robot pet?");
        Console.WriteLine("Choose an option");
        Console.WriteLine("1. Organic \n2. Robot");
        string petType = Console.ReadLine();
        option = true;


        bool isRunning = true;


        while (isRunning)
        {

            Console.Clear();

            


            if (petType == "1")


            {

                Console.Clear();
                if (option)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Pick a slot for your new pet?");
                    myPet = (Organic)shelter.GetPet();

                    option = false;
                }


                myPet.Tick();


                Console.WriteLine("Menu");
                Console.WriteLine("0 Create a new pet");
                Console.WriteLine("1 Name");
                Console.WriteLine("2 Species");
                Console.WriteLine("3 Pet interaction ");
                Console.WriteLine("4 Interact with pets in shelter");
                Console.WriteLine("5 Adopt or Remove pet from shelter");
                Console.WriteLine("q Exit");
                Console.WriteLine();





                Console.WriteLine("Pet Name: " + myPet.Name);
                Console.WriteLine("Species: " + myPet.Species);

                Console.WriteLine("Enter Your Choice");
                string choice = Console.ReadLine();
                

                switch (choice)
                {
                    case "0":
                        isRunning = false;

                        break;
                    case "1":
                        myPet.SetName();
                        break;
                    case "2":
                        myPet.SetSpecies();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Welcome to Pet interaction\n 1: View Pets Stats \n 2: Play with your pet \n 3: Feed your pet\n 4: Take your pet to the doctor ");
                        int userInput = Convert.ToInt32(Console.ReadLine());
                        if (userInput == 1)
                        {
                            myPet.PetStats();
                        }
                        else if (userInput == 2)
                        {
                            myPet.PlayWithPet();
                        }
                        else if (userInput == 3)
                        {
                            myPet.Feed();
                        }
                        else if (userInput == 4)
                        {
                            myPet.TakePetToVet();
                        }
                        else
                        {
                            Console.WriteLine("Please input one of the options");
                        }
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Welcome to the shelter\n 1: View all pets in shelter \n 2: Feed all pets in shelter \n 3: Play with all pets in shelter\n 4: Take all pets to the doctor in shelter \n 5: View all pets statuses");
                        Console.WriteLine(" 6: Interact with a specific pet");
                        int userInput1 = Convert.ToInt32(Console.ReadLine());
                        if (userInput1 == 1)
                        {
                            shelter.PrintAllPets();
                        }
                        else if (userInput1 == 2)
                        {
                            shelter.FeedAllPets();
                        }
                        else if (userInput1 == 3)
                        {
                            shelter.PlayWithAllPets();
                        }
                        else if (userInput1 == 4)
                        {
                            shelter.TakeAllPetsToDoctor();
                        }
                        else if (userInput1 == 5)
                        {
                            shelter.PrintAllPetsStatus();
                        }
                        else if (userInput1 == 6)
                        {
                            isRunning = false;

                        }
                        else
                        {
                            Console.WriteLine("Please input one of the options");
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Would you like to Add or Remove\n 1: Add pet to shelter \n 2: Remove Pet from shelter \n ");
                        int userInput2 = Convert.ToInt32(Console.ReadLine());
                        if (userInput2 == 1)
                        {
                            Console.WriteLine("What pet would you like to admit");
                            Console.WriteLine("Please enter pet's slot number");
                            int index = Convert.ToInt32(Console.ReadLine());
                            shelter.AddPet(myPet);
                        }
                        else if (userInput2 == 2)
                        {
                            Console.WriteLine("What pet would you like to remove");

                            int index = Convert.ToInt32(Console.ReadLine());
                            shelter.RemovePet(myPet);


                        }
                        break;
                    default:
                        break;
                }
            }
            else if (petType == "2")
            {
                Console.Clear();
                if (option)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pick a slot for your Robotic Pet?");
                    myRobot = (Robotic)shelter.GetPet1();
                    option = false;
                }


                myRobot.Tick();


                Console.WriteLine("Menu");
                Console.WriteLine("0 Create new Pet");
                Console.WriteLine("1 Name");
                Console.WriteLine("2 Species");
                Console.WriteLine("3 Pet interaction ");
                Console.WriteLine("4 Interact with pets in shelter");
                Console.WriteLine("5 Adopt or Remove pet from shelter");
                Console.WriteLine("q Exit");
                Console.WriteLine();


                Console.WriteLine("Pet Name: " + myRobot.Name);
                Console.WriteLine("Species: " + myRobot.Species);
                Console.WriteLine("Enter Your Choice");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        isRunning = false;
                        break;
                    case "1":
                        myRobot.SetName();
                        break;
                    case "2":
                        myRobot.SetSpecies();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Welcome to Pet interaction\n 1: View Pets Stats \n 2: Play with your pet \n 3: Feed your pet\n 4: Take your pet to the doctor ");
                        int userInput = Convert.ToInt32(Console.ReadLine());
                        if (userInput == 1)
                        {
                            myRobot.PetStats();
                        }
                        else if (userInput == 2)
                        {
                            myRobot.PlayWithPet();
                        }
                        else if (userInput == 3)
                        {
                            myRobot.Feed();
                        }
                        else if (userInput == 4)
                        {
                            myRobot.TakePetToVet();
                        }
                        else
                        {
                            Console.WriteLine("Please input one of the options");
                        }
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Welcome to the shelter\n 1: View all pets in shelter \n 2: Feed all pets in shelter \n 3: Play with all pets in shelter\n 4: Take all pets to the doctor in shelter \n 5: View all pets statuses");
                        Console.WriteLine(" 6: Interact with specific pet");

                        int userInput1 = Convert.ToInt32(Console.ReadLine());
                        if (userInput1 == 1)
                        {
                            shelter.PrintAllPets();
                        }
                        else if (userInput1 == 2)
                        {
                            shelter.FeedAllPets();
                        }
                        else if (userInput1 == 3)
                        {
                            shelter.PlayWithAllPets();
                        }
                        else if (userInput1 == 4)
                        {
                            shelter.TakeAllPetsToDoctor();

                        }
                        else if (userInput1 == 5)
                        {
                            shelter.PrintAllPetsStatus();
                        }
                        else if (userInput1 == 6)
                        {
                            isRunning = false;

                        }
                        else
                        {
                            Console.WriteLine("Please input one of the options");
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Would you like to Add or Remove\n 1: Add pet to shelter \n 2: Remove Pet from shelter \n ");
                        int userInput2 = Convert.ToInt32(Console.ReadLine());
                        if (userInput2 == 1)
                        {
                            Console.WriteLine("What pet would you like to admit?");
                            Console.WriteLine("Please enter your pet's slot number.");
                            int index = Convert.ToInt32(Console.ReadLine());
                            shelter.AddPet1(myRobot);
                        }
                        else if (userInput2 == 2)
                        {
                            Console.WriteLine("What pet would you like to remove");
                            int index = Convert.ToInt32(Console.ReadLine());
                            shelter.RemovePet(myRobot);
                        }
                        break;
                    default:
                        break;
                }
            }



            if (myPet.Hunger >= 100 || myPet.Boredom >= 100 || myPet.Health <= 0)
            {
                Console.Clear(); Console.WriteLine("Your " + myPet.Species + ", " + myPet.Name + " ran away for being neglected");
                isRunning = false;
                createNew = false;
            }
            if (myRobot.Hunger >= 100 || myRobot.Boredom >= 100 || myRobot.Health <= 0)
            {
                Console.Clear(); Console.WriteLine("Your " + myPet.Species + ", " + myPet.Name + " ran away for being neglected");
                isRunning = false;
                createNew = false;
            }
            if (petType == "q")
            {
                Console.WriteLine("Thank you for playing Virtual Pet.");
                Console.WriteLine("Bye-Bye");
                Console.ReadLine();
                isRunning = false;
                createNew = false;
            }


        }

    }


}

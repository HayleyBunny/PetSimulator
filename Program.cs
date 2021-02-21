using System;

namespace Pet_Simulator
{
    class Program
    {
        public static void CatCareChoices(int pCatChoice, Cat cat)
        {

            if (pCatChoice == 1)
            {
                cat.GiveFood();
            }
            else if (pCatChoice == 2)
            {
                cat.PetHead();
            }
            else if (pCatChoice == 3)
            {
                cat.GiveWater();
            }
            else if (pCatChoice == 4)
            {
                cat.GiveBath();
            }
            else if (pCatChoice == 5)
            {
                cat.BrushFur();
            }
            else if (pCatChoice == 6)
            {
                cat.Poke();
            }
            else if (pCatChoice == 7)
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
        public static int UserChooseMenu(string pQuestion, string[] pOptions, out int pMenuChoice)
        {
            bool ValidInput = false; 
            int input = 0;
            do
            {
                Console.WriteLine(pQuestion);
                Console.WriteLine("Please enter the number that represents your choice.");
                for (int optionNum = 0; optionNum != pOptions.Length; optionNum++)
                {
                    Console.WriteLine((optionNum + 1) + ". " + pOptions[optionNum]);
                }
                try
                {
                    input = int.Parse(Console.ReadLine());
                    ValidInput = true;
                }
                catch
                {
                    ValidInput = false;
                }
                pMenuChoice = input;
                if (pMenuChoice > pOptions.Length + 1 || pMenuChoice <= 0)
                {
                    ValidInput = false;
                    Console.WriteLine("That was invalid input! Please try again.");
                }
            } while (ValidInput == false);
            return pMenuChoice;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the virtual pet simulation!");
            //User Pet Adoption and Choice
            string StartMenuQuestion = "What kind of pet would you like to adopt?";
            string[] StartMenuOptions = { "Cat", "Dog", "Frog", "Snake", "Exit" };
            UserChooseMenu(StartMenuQuestion, StartMenuOptions, out int MenuChoice);
            Console.WriteLine("Please choose a name for your new " + (StartMenuOptions[MenuChoice - 1]));
            string PetName = Console.ReadLine();
            bool KeepPlaying = true;
            //User Choices Acted Upon


            //Cat Choice Options
            if (MenuChoice == 1)
            {
                Cat MyFirstPet = new Cat(PetName);
                do
                {
                    string CatQuestion = "What would you like to do with " + MyFirstPet.Name + " today?";
                    string[] CatMenuOptions = { "Give Food", "Pet Head", "Give Water", "Give Bath", "Brush Fur", "Poke", "Exit" };
                    UserChooseMenu(CatQuestion, CatMenuOptions, out int CatChoice);
                    CatCareChoices(CatChoice, MyFirstPet);
                    if (CatChoice == 7)
                    {
                        MyFirstPet.Results();
                        KeepPlaying = false;
                    }
                } while (KeepPlaying == true);
            }
        }
    }
}

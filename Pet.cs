using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_Simulator
{
    class Pet
    {
        public int HappinessMeter;
        private string name;
        public int NumberOfMeals;

        public Pet(string mPetName)
        {
            name = mPetName;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public virtual void GiveFood()
        {
            NumberOfMeals++;
            Console.WriteLine("Congratualtions! " + Name + " ate some food! YUMMMY ");
        }
    }

    class Mammal : Pet
    {
        public int TimesWatered;
        public int TimesBathed;
        public Mammal(string name) : base(name)
        {
        }
        public void PetHead()
        {
            Console.WriteLine("You pet " + Name + "'s head! Cute!!");
            HappinessMeter++;
        }
        public void GiveWater()
        {
            Console.WriteLine("Gulp Gulp! " + Name + " has drunk delicous water!");
            TimesWatered++;
        }
        public virtual void GiveBath()
        {
            Console.WriteLine("Splish Splash, " + Name + " took a bath!!");
            TimesBathed++;
        }
        public void BrushFur()
        {
            Console.WriteLine(Name + "'s fur is nice and soft! So pretty!");
            HappinessMeter++;
        }
    }

    class Cat : Mammal
    {
        public int Scratched = 0;
        public Cat(string name) : base(name)
        {
        }
        public void Poke()
        {
            Console.WriteLine("You poked " + Name + ", he does not look happy! MEEEEOW! Watch your fingers!!");
            Scratched++;
            HappinessMeter =- 1;
        }
        public override void GiveBath()
        {
            Console.WriteLine(Name + " is not very happy to have a bath! HISSS ");
            HappinessMeter =- 1;
            TimesBathed++;
        }
        public void Results()
        {
            Console.WriteLine("Here are your Owner Results:");
            Console.WriteLine("You were Scratched " + Scratched + " times!");
            Console.WriteLine("You fed " + Name + " " + NumberOfMeals + " times!");
            Console.WriteLine("You gave " + Name + " water " + TimesWatered + " times!");
            Console.WriteLine("You gave " + Name + " " + TimesBathed + " baths!");
            Console.WriteLine("Your pet " + Name + " had " + HappinessMeter + " happiness points!");
        }
    }
    class Dog : Mammal
    {
        public int walksTaken;
        public int bite;
        public int tricksLearnt;
        public Dog(string name) : base(name)
        { 
        }
        public void Train()
        {
            Console.WriteLine("You took your time to teach " + Name + " a trick!");
            tricksLearnt++;
        }
        public void Walk()
        {
            Console.WriteLine(Name + " is very happy on his walk! Such a good boy!");
            HappinessMeter++;
            walksTaken++;
        }
        public override void GiveFood()
        {
            Console.WriteLine(Name + " ate it's food super fast!! Careful you dont choke!");
            NumberOfMeals++;
        }
        public override void GiveBath()
        {
            Console.WriteLine("What a mess! " + Name + " made such a big mess in the bath! Silly Puppy...");
            HappinessMeter++;
            TimesBathed++;
        }

    }
}
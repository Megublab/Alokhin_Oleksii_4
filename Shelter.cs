using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_semestr.Laba_4
{
    internal class Shelter
    {
        public List<Home_Pet> List_Home_pets = new List<Home_Pet>();
        public void Count_Pets()
        {
            int Dog_Count = 0;
            int Cat_Count = 0;
            int Bird_Count = 0;
            foreach (var pet in List_Home_pets)
            {
                if (pet.GetType().Name == "Cat")
                {
                    Cat_Count++;
                }
                else if (pet.GetType().Name == "Dog")
                {
                    Dog_Count++;
                }
                else if (pet.GetType().Name == "Bird")
                {
                   Bird_Count++;
                }
                else if (pet.GetType().Name == "Parrot")
                {
                   Bird_Count++;
                }
            }
            Console.WriteLine("Animals - " + List_Home_pets.Count);
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("birds - " + Bird_Count);
            Console.WriteLine("dogs - " + Dog_Count);
            Console.WriteLine("cats - " + Cat_Count);
            Console.WriteLine(new String('-', 50));
        }
        public void Determine(List<Home_Pet> List_Home_pets)
        {
            foreach (var pet in List_Home_pets)
            {
                Console.WriteLine("Animals in shelter" + pet.GetType().Name);
                Console.WriteLine(new String('-', 50));
            }
        }
        public void Addpet(Home_Pet pet)
        {
            List_Home_pets.Add(pet);
        }
        public void DetermineType(Home_Pet pet)
        {
            Console.WriteLine("Type - " + pet.GetType().Name);
            Console.WriteLine(new String('-', 50));
        }
    }
    abstract class Home_Pet 
    {
        public void Move()
        {
            Console.WriteLine("*Pets walking in the yard*");
        }
        public void Sounds()
        {
            Console.WriteLine("*Many sound of animals*");
        }

    }
    class Cat : Home_Pet
    {
        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public int Current_Food { get; set; }
        public int Max_Food { get; set; }
        public int Min_Food { get; set; }
        public Cat(string Name, int Age, int Weight)
        {
            name = Name;
            age = Age;                       
            weight = Weight;
        }
        public Cat()
        {
            Random run = new Random();
            Max_Food = 200;
            Min_Food = 50;
            Current_Food = run.Next(1,(Max_Food - Min_Food) / 2 + Min_Food);
        }
        public enum Const_Food 
        {
            Meat = 80,
            Milk = 50,
            Cat_Food = 100,
            Fish = 90,
            Exit = 0
        }
        public string Eat(Const_Food enter)
        {
            switch (enter)
            {
                case Const_Food.Meat: return "Cat ate meat";
                case Const_Food.Milk: return "Cat ate milk";
                case Const_Food.Cat_Food: return "Cat ate Cat Food";
                case Const_Food.Fish: return "Cat ate fish";
                default: return "";
            }
        }

        public void Feed_Cat()
        {
            Cat myCat = new Cat();
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Cat`s max food status {0} ", myCat.Max_Food);
            Console.WriteLine("Cat`s min food status {0}", myCat.Min_Food);
            Console.WriteLine("Cat`s current food {0}", myCat.Current_Food);
            Console.WriteLine("To end enter \"Exit\"");
            Const_Food anyfood = Const_Food.Milk;
            do
            {                                                                                           
                Console.WriteLine("\n What would cat eat? \n Meat \n Milk \n Cat_Food \n Fish ");
                string ent_food = Console.ReadLine();
                StringBuilder sb = new StringBuilder(ent_food);
                anyfood = (Const_Food)Enum.Parse(typeof(Const_Food), ent_food);
                myCat.Current_Food += Convert.ToInt32(anyfood);
                Console.WriteLine(myCat.Eat(anyfood) + ", current food status: " + myCat.Current_Food);
                if (myCat.Current_Food > myCat.Max_Food)
                {
                    Console.WriteLine("Cat got too fat. Get food stutus to 0? Y/N");
                    var answer = Console.ReadLine();
                    if (answer == "Y")
                    {
                        myCat.Current_Food = 10;
                        Console.WriteLine("Уровень сытости: " + myCat.Current_Food);
                    }
                    else if(answer == "N")
                    {
                        anyfood = Const_Food.Exit;
                    }
                    else
                    {
                        Console.WriteLine("Unlnown comand");
                    }
                }
            }
            while (anyfood != Const_Food.Exit);
        }
        public void Get_Voice()
        {                                               
            Console.WriteLine("Meow");
        }
    }
    class Dog : Home_Pet
    {
        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public Dog(string Name, int Age, int Weight)
        {
            name = Name;                   
            age = Age;
            weight = Weight;
        }
        public void Get_Dog_Style(Dog dog_1, Dog dog_2)
        {
            string winner;
            int Power_of_Dog_1 = (dog_1.age * dog_1.weight) / 2;
            int Power_of_Dog_2 = dog_2.age * dog_2.weight;
            if (Power_of_Dog_2 < Power_of_Dog_1)
            {
                winner = dog_1.name;
                Console.WriteLine("Winner - " + dog_1.name);
            }
            else                                
            if (Power_of_Dog_2 > Power_of_Dog_1)
            {
                winner = dog_2.name;
                Console.WriteLine("Winner - " + dog_2.name);
            }
            else if (Power_of_Dog_2 == Power_of_Dog_1)
            {
                Console.WriteLine("All dogs are cool");
            }
            else
            {
                Console.WriteLine("Error");
            }    
        }
        public void Get_Voice()
        {
            Console.WriteLine("Woof");
        }
    }
    class Bird : Home_Pet
    {
        public string Fly()
        {
            Console.WriteLine("Allow bird to fly ? Y/N");
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                return "Bird flying in the big cage";
            }
            else if(answer == "N")
            {
                return "Bird stayed in the little cage";
            }
            else
            {
                return "Unknown Command";
            }  
        }
    }
    class Parrot : Bird 
    {
        public string name { get; set; }
        public int years { get; set; }
        public bool spelling { get; set; }
        public Parrot(string Name, int Years, bool Spelling)
        {
            name = Name;
            years = Years;          
            spelling = Spelling;
        }
        public void Parrot_Speacking() 
        {
            if (spelling == true)
            {
                Console.WriteLine($"What {name} shoud repeat");
                string yourword = Console.ReadLine();
                Get_Voice(yourword);
            }
            else if (spelling == false)
            {
                Console.WriteLine(name + " won`t repeat your speach");
            }
            else
            {
                Console.WriteLine("Unknown comand");
            }
        }
        public void Get_Voice(string yourword)
        {
            Console.WriteLine(name + " said " + yourword);
        }

    }
}

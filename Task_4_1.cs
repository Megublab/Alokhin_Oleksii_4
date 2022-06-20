using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_semestr.Laba_4
{
    internal class Task_4_1
    {


        //  Проаналізувати завдання, виділити інформаційні об’єкти та дії.Визначити правильну ієрархію об’єктів 
        //  Створити базовий суперклас(абстрактний клас або інтерфейс) і визначити загальні методи для даного класу. 
        //  Створити підкласи, в які додати специфічні властивості та методи.Частину методів перевизначити.  
        //  Розробити програму з використанням абстрактних класів та інтерфейсів.
        //  Чітко розуміти, де доцільно використати суперклас, а де звичайний.
        //  При розробці використовувати наслідування та поліморфізм
        //  У всіх класах повинні бути реалізовані доцільні для класу методи, навіть якщо це не вказано у завданні
        //  Використовувати об’єкти підкласів для моделювання реальних ситуацій на об’єктів

        // Створити суперклас Домашня тварина і підкласи Собака, Кішка, Папуга, Птах.
        // За допомогою конструктора встановити ім'я кожної тварини і його характеристики.
        // Вивести на екран голос, який подає домашня тварина
        public static void Start()
        {

            var shelter = new Shelter();
            //Cats
            var cat = new Cat("Bubble", 7, 4);
            shelter.Addpet(cat);
            cat.Feed_Cat();
            cat.Get_Voice();
            Console.WriteLine(new String('-', 50));
            //Dogs
            var dog_1 = new Dog("Jack", 12, 86);
            var dog_2 = new Dog("Rex", 10, 80);
            shelter.Addpet(dog_1);                          
            Console.WriteLine("Firs dog name - " + dog_1.name);
            Console.WriteLine("Firs dog age - " + dog_1.age);
            Console.WriteLine("Firs dog weight - " + dog_1.weight);
            Console.WriteLine("Second dog name - " + dog_2.name);
            Console.WriteLine("Second dog age - " + dog_2.age);
            Console.WriteLine("Second dog weight - " + dog_2.weight);
            dog_1.Get_Dog_Style(dog_1, dog_2);
            Console.WriteLine(new String('-', 50));
            //Parrot
            var parrot1 = new Parrot("Mister P", 3, true);
            shelter.Addpet(parrot1);
            Console.WriteLine("Parrot name - " + parrot1.name);
            Console.WriteLine("PArrot age - " + parrot1.years);
            parrot1.Parrot_Speacking();
            parrot1.Fly();
            //shelter
            shelter.DetermineType(dog_1);
            shelter.DetermineType(dog_2);
            shelter.Determine(shelter.List_Home_pets);
            shelter.Count_Pets();

        }
    }
}

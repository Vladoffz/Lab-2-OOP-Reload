using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOP_Reload
{
    enum AnimalType //тип животного
    {
        Bird,
        Fish,
        Mammal,
    };
    enum PowerSupplyType //тип живлення
    {
        Carnivorous,
        Herbivorous,
        Omnivorous,
    };
    class Animals //статики
    {
        public AnimalType type;
        public PowerSupplyType food_type;
        public string name;
        public int age;
        public bool hungryState;
        public string time; // food time

        public Animals(AnimalType type, PowerSupplyType food_type, string name, int age, bool hungryState, string time)
        
        {
            this.type = type;
            this.food_type = food_type;
            this.name = name;
            this.age = age;
            this.hungryState = hungryState;
            this.time = time;
        }
        public string Feed(int amount)
        {
            if(this.hungryState == true)
            {
                //Console.WriteLine("Animal hungry");
                this.hungryState = false;
                return "Animal hungry";
                
            }
            return "Animal not hungry";
            //Console.WriteLine("Animal not hungry");

         
        }
        
    }
}

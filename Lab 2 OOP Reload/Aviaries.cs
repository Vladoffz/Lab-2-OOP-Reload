using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOP_Reload
{
    class Aviaries
    {
        public List<Animals> Animals_in_aviary = new List<Animals>();
        public AnimalType aviaryType; 
        public void AddAnimal(Animals animal)
        {
            if (Animals_in_aviary.Count != 0)
            {
                if (animal.type == Animals_in_aviary[0].type)
                {
                    Animals_in_aviary.Add(animal);
                }
                else
                {
                    Console.WriteLine("Animal type not validate");
                }
            }
            else
            {
                Animals_in_aviary.Add(animal);
            }
        }
    }
}




        
   


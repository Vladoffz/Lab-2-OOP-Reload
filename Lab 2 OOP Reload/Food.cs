using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOP_Reload
{
    enum FoodType
    {
        Grass,
        Meat,
        Fish,
    };
    class Food
    {
        public FoodType FoodType;
        public int Quantity;
        public string Name;
        public string TimeToUse;
        public Food() {}
        public Food(FoodType type, int Quantity, string name, string TimeToUse)
        {
            FoodType = type;
            this.Quantity = Quantity;
            Name = name;
            this.TimeToUse = TimeToUse;
        }
    }          
}




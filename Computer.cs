using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_DeBord_Joshua
{
    internal class Computer : IBootUp
    {
        public bool IsOn { get; set; } //makes a public booleon called IsOn

        public string Brand { get; set; }//make a public string called Brand
        public string Type { get; set; }    //makes a public string called Type

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn == true)//if statement. if the IsOn booleon is true, it executes below
            {
                Console.WriteLine("The computer is booting up!"); //writes to the console the text to the left
            }
            else//if the booleon IsOn is false, it executes below instead
            {
                Console.WriteLine("The computer is shutting down!");//writes to the console the text to the left
            }
        }

        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is {IsOn}!"; // returns the text to the left
        }
    }
}

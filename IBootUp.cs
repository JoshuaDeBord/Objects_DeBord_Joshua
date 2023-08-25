using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_DeBord_Joshua
{
    internal interface IBootUp
    {
        public bool IsOn { get; set; } //makes a booleon called IsOn

        public void PowerOnOff();//creates a public method called PowerOnOff

    }
}

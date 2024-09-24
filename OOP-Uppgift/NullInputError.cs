using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift
{
    internal class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a null input in this field. This fierd an error !";
        }
    }
}
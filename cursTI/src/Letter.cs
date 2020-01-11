using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursTI.src
{
    class Letter
    {
        public char ActualLetter;


        public bool Let(char letter)
        {
            return char.IsLetter(letter);
        }

        public bool Digit(char letter)
        {
            return char.IsDigit(letter);
        }




        public void SetActualLetter(char inputChar)
        {
            ActualLetter = inputChar;
        }

        public char GetActualLetter()
        {
            return ActualLetter;
        }
    }
}

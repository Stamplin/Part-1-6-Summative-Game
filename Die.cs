using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_a_Die_Class
{
    public class Die
    {
        private int _roll;
        private Random _generator;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }


        public int Roll
        {
            get { return _roll; }
        }

        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;
        }

        public void DrawRoll(int dieNum, int position)
        {
            int hOffset = 0;
            if (dieNum > 1)
                hOffset = 5;

            if (_roll == 1)
            {
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|   |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("| o |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|   |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
            }
            else if (_roll == 2)
            {
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o  |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|   |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|  o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
            }

            else if (_roll == 3)
            {
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o  |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("| o |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|  o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
            }
            else if (_roll == 4)
            {
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|   |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
            }
            else if (_roll == 5)
            {
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("| o |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
            }
            else if (_roll == 6)
            {
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|o o|");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
            }
            else
            {
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|   |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("| ? |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("|   |");
                position++;
                Console.SetCursorPosition((dieNum - 1) * 6, position - hOffset);
                Console.WriteLine("-----");
            }




            


        }

        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }

            else if (_roll == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| ? |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }




        }

        public override string ToString()
        {
            return _roll.ToString();
        }

    }
}
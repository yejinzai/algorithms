using System;
using System.Collections.Generic;
using System.Linq;

namespace hanoi
{
    class Program
    {
        static Stack<int> a = new Stack<int>();
        static Stack<int> b = new Stack<int>();
        static Stack<int> c = new Stack<int>();
        static List<char> pegs = new List<char> { 'a','b','c' };
        static int moves = 0;

        static void Main(string[] args)
        {
            InitHanoi(5, 'a', 'b');
            //InitHanoi(7, 'a', 'c');
        }

        static void InitHanoi(int numDisks, char fromPeg, char toPeg){
            var peg = GetPegObject(fromPeg);
            for (var i = numDisks; i > 0; i--)
            {
                peg.Push(i);
            }

            PrintArray(fromPeg);
            SolveHanoi(numDisks, fromPeg, toPeg);
            PrintArray(toPeg);

            Console.WriteLine("Correct number of moves: {0}", Math.Pow(2, numDisks) - 1);
            Console.WriteLine("Number of moves: {0}:", moves);
        }


        static bool SolveHanoi(int numDisks, char fromPeg, char toPeg){
            if (numDisks == 0)
                return true;

            var sparePeg = GetSparePeg(fromPeg, toPeg);
            SolveHanoi(numDisks-1, fromPeg, sparePeg);

            MoveDisk(fromPeg, toPeg);
            moves++;

            SolveHanoi(numDisks-1, sparePeg, toPeg);

            return false;
        }

        static Stack<int> GetPegObject(char pegLetter){
            if (char.ToLower(pegLetter) == 'a') return a;
            if (char.ToLower(pegLetter) == 'b') return b;
            if (char.ToLower(pegLetter) == 'c') return c;

            return null;
        }

        static void MoveDisk(char fromPeg, char toPeg){
            var pegS = GetPegObject(fromPeg);
            var pegD = GetPegObject(toPeg);

            var disk = pegS.Pop();
            pegD.Push(disk);
        }

        static char GetSparePeg(char fromPeg, char toPeg){

            List<char> _p = new List<char> { char.ToLower(fromPeg), char.ToLower(toPeg) };

            return pegs.Except(_p).FirstOrDefault();
        }

        static void PrintArray(char pegLetter)
        {
            Console.WriteLine("{0}:", pegLetter);
            foreach (var o in GetPegObject(pegLetter))
            {
                Console.WriteLine(o);
            }

            Console.WriteLine();
        }
    }
}

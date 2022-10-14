using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_Lab
{
    internal class VHS : Movies
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string name, Category genere, int runtime, string[] scenes)
            : base(name, genere, runtime, scenes)
        {
            this.Name = name;
            this.Genere = genere;
            this.RunTime = runtime;
            this.Scenes = scenes;
        }

        public void Play()
        {
            int sceneDivide = RunTime / Scenes.Length;

            for (int i = 0; i < Scenes.Length; i++)
            {
                Console.WriteLine($"{CurrentTime} mins: {Scenes[i]}");
                CurrentTime += sceneDivide;
            }
            Rewind();

        }

        public void Rewind()
        {

            bool rewind = ContinueLoop("Rewind To the begining?");
            if (rewind == true)
            {
                CurrentTime = 0;
                Console.WriteLine("Rewinding Tape!");
            }


        }

        public static bool ContinueLoop(string question)
        {
            string response = GetInput(question);
            if (response.ToLower() == "y")
            {
                return true;
            }
            else if (response.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter y or n");
                return ContinueLoop(question);
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine();
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExercisesonsdag
{
    //Skapa en klass Cat som ärver från Animal och implementerar MakeSound() metoden
    public class cat : Animal
    {
        //attributer
        public int weight { get; set; }
        public string color { get; set; }

        //metod
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
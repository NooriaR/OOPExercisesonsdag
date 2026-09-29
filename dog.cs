using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExercisesonsdag
{
    //Skapa en klass Dog som ärver från Animal och implementerar MakeSound() metoden
    public class dog : Animal
    {
        //attributer
        public string rase { get; set; }
        public string color { get; set; }

        //metod
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

    }
}

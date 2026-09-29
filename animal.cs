using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExercisesonsdag
{
    //Skapa en abstract basklass Animal med en abstrakt metod MakeSound().
    public abstract class Animal
    {
        //attributer 
        public string Name { get; set; }
        public int Age { get; set; }

        //Metod
        public abstract void MakeSound();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicMoq.DAL
{
    // 1. Implement the IQuestions Interface
    // 2. Use the methods in your Answers class to address tasks/questions posed by this class
    // 3. Access an instance of your Answers class using the "Wand"
    public class Questions : IQuestions
    {
        //anything with a get; set; is ALWAYS default to null
        public Answers Wand { get; set; } // This is important. Do not delete this.

        public Questions() //!!Constructor!!
        {
            Wand = new Answers();
        }

        public Questions(Answers answer) //ANOTHER !!Constructor!!
        {
            Wand = answer;
        }


        public int OnePlusOne()
        {
            return Wand.One() + Wand.One();
        }

        public int ZeroPlusZero()
        {
            //OPTION ONE:
           // return Wand.Two();

            //OPTION TWO:
            return Wand.One() + Wand.One();
        }

        public int FourPlusZero()
        {
            return Wand.Four();
        }

        public int TwoMinusZero()
        {
            return Wand.Two();
        }

        public int OnePlusTwo()
        {
            return Wand.Three();
        }

        public int TwoPlusTwo()
        {
            return Wand.Two() + Wand.Two();
        }

        public int OneMinusOne()
        {
            //OPTION 1:
            return Wand.Zero(); //you could either mock the Zero() method 

            //OPTION 2:
            //return Wand.One() - Wand.One(); // OR you could mock the One() method

        }

        public int FourMinusTwo()
        {
            return Wand.Four() - Wand.Two();
        }

        public int FourMinusTwoPlusOne()
        {
            return Wand.Four() - Wand.Two() + Wand.One();
        }

        public string SayNothing()
        {
            return Wand.EmptyString();
        }

        public bool ReturnFalse()
        {
            return Wand.False();
        }

        public bool ReturnTrue()
        {
            return Wand.True();
        }

        public string SayHelloWorld()
        {
            return Wand.HelloWorld(); 
        }
            
        public List<int> CountToFive()
        {
            return Wand.ListOfNInts(1);
        }

        public List<int> FirstThreeEvenInts()
        {
            List<int> numbers = Wand.ListOfNInts(6);
            List <int> result = new List<int>();
            foreach(var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public List<int> FirstThreeOddInts()
        {
            List<int> numbers = Wand.ListOfNInts(6);
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}
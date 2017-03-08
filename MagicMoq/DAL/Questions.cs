﻿using System;
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
            throw new NotImplementedException();
        }

        public int ZeroPlusZero()
        {
            throw new NotImplementedException();
        }

        public int FourPlusZero()
        {
            throw new NotImplementedException();
        }

        public int TwoMinusZero()
        {
            throw new NotImplementedException();
        }

        public int OnePlusTwo()
        {
            throw new NotImplementedException();
        }

        public int TwoPlusTwo()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int FourMinusTwoPlusOne()
        {
            throw new NotImplementedException();
        }

        public string SayNothing()
        {
            throw new NotImplementedException();
        }

        public bool ReturnFalse()
        {
            throw new NotImplementedException();
        }

        public bool ReturnTrue()
        {
            throw new NotImplementedException();
        }

        public string SayHelloWorld()
        {
            return Wand.HelloWorld(); 
        }

        public List<int> CountToFive()
        {
            throw new NotImplementedException();
        }

        public List<int> FirstThreeEvenInts()
        {
            throw new NotImplementedException();
        }

        public List<int> FirstThreeOddInts()
        {
            throw new NotImplementedException();
        }
    }
}
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
        public Answers Wand { get; set; } // This is important. Do not delete this.

        public Questions()
        {
            Wand = new Answers(); // the '=' SETS a new instance of Wand
        }

        public Questions(Answers answer)
        {
            Wand = answer;
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

        public int FourMinusTwo()
        {
            return Wand.Two();
        }

        public int FourMinusTwoPlusOne()
        {
            return Wand.Three();
        }

        public int FourPlusZero()
        {
            return Wand.Four();
        }

        public int OneMinusOne()
        {
            // Option 1
            return Wand.Zero();

            // Option 2
            // return Wand.One() - Wand.One();
        }

        public int OnePlusOne()
        {
            return Wand.One() + Wand.One();
        }

        public int OnePlusTwo()
        {
            return Wand.Three();
        }

        public bool ReturnFalse()
        {
            return false;
        }

        public bool ReturnTrue()
        {
            return true;
        }

        public string SayHelloWorld()
        {
            return Wand.HelloWorld(); // using HelloWorld from the Answers Class
        }

        public string SayNothing()
        {
            return Wand.EmptyString();
        }

        public int TwoMinusZero()
        {
            return Wand.Two();
        }

        public int TwoPlusTwo()
        {
            return Wand.Four();
        }

        public int ZeroPlusZero()
        {
            return Wand.Zero();
        }
    }
}
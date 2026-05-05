using System;
using System.Collections.Generic;
using System.Text;

namespace Christian_Gonzalez_Project
{
    public class Die : IRollableToken
    {
        public int NumSidesPerDie;
        public const int MinSidesPerDie = 4;

        public Die(int numSidesPerDie)
        {
            NumSidesPerDie = numSidesPerDie;
        } // End Constructor

        public int RollToken()
        {
            return Random.Shared.Next(1, NumSidesPerDie + 1);
        } // End RollToken
    }
}

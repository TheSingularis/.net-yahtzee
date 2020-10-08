using System;

namespace Sluiter_ASG5_Yahtzee {

    class Die {
        public int value;

        public Die () {

        }

        public int Roll () {
            Random random = new Random( Guid.NewGuid().GetHashCode() );   //Uniquely Seeded

            int randInt = random.Next( 0, 6 );

            value = randInt + 1;

            return randInt;
        }
    }
}

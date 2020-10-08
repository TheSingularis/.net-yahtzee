using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sluiter_ASG5_Yahtzee {
    class Hand {

        private List<Die> dieList = new List<Die>();

        public List<Die> getDice () {
            return dieList;
        }

        public Hand () {
            resetHand();
        }

        public void resetHand () {
            dieList.Clear();

            dieList.Add( new Die() );
            dieList.Add( new Die() );
            dieList.Add( new Die() );
            dieList.Add( new Die() );
            dieList.Add( new Die() );
        }

        public void rollDie ( int i ) {
            dieList[i].Roll();
        }

        public Die getDieByIndex ( int i ) {
            return dieList[i];
        }
    }
}

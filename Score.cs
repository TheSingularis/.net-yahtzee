using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sluiter_ASG5_Yahtzee {
    class Score {
        public int scoreUpper ( List<Die> listDie, int num ) {
            int total = 0;

            foreach (Die die in listDie) {
                if (die.value == num) {
                    total += num;
                }
            }

            return total;
        }

        public int score3OfKind ( List<Die> listDie ) {
            int total = 0;

            // Make a Sorted list of the dice, having a sorted list makes it much easier to work 
            // with three and four of a kind, and also to work with straights
            List<Die> sortedList = listDie.OrderBy( d => d.value ).ToList();

            // Checking for three of a kind, very similar to when you look for three in a row in Tic Tac Toe
            // Look for  x,x,x,y,z   or x,y,y,y,z  or x,y,z,z,z
            if ((sortedList[0].value == sortedList[1].value && sortedList[1].value == sortedList[2].value) ||
                (sortedList[1].value == sortedList[2].value && sortedList[2].value == sortedList[3].value) ||
                (sortedList[2].value == sortedList[3].value && sortedList[3].value == sortedList[4].value)) {
                // Found three of a kind, add the values of all dice to the total
                foreach (Die die in sortedList) {
                    total = total + die.value;
                }
            }

            // Set the total in the textbox
            return total;

        }

        public int score4OfKind ( List<Die> listDie ) {
            int total = 0;
            
            //Organize the Die
            List<Die> sortedList = listDie.OrderBy( d => d.value ).ToList();

            if ((sortedList[0].value == sortedList[1].value && sortedList[1].value == sortedList[2].value && sortedList[2].value == sortedList[3].value) ||
                (sortedList[1].value == sortedList[2].value && sortedList[2].value == sortedList[3].value && sortedList[3].value == sortedList[4].value)) {

                foreach (Die die in sortedList) {
                    total = total + die.value;
                }
            }

            return total;
        }

        public int scoreFullHouse ( List<Die> listDie ) {
            bool goodHand = false;

            List<Die> sortedList = listDie.OrderBy( d => d.value ).ToList();

            if ((sortedList[0].value == sortedList[1].value && sortedList[1].value == sortedList[2].value && sortedList[2].value != sortedList[3].value && sortedList[3].value == sortedList[4].value) ||
                (sortedList[0].value == sortedList[1].value && sortedList[1].value != sortedList[2].value && sortedList[2].value == sortedList[3].value && sortedList[3].value == sortedList[4].value)) {
                goodHand = true;
            }

            if (goodHand) {
                return 25;
            } else {
                return 0;
            }
        }

        public int scoreSmallStraight ( List<Die> listDie ) {
            bool goodHand = false;

            List<Die> sortedList = listDie.OrderBy( d => d.value ).ToList();

            if ((sortedList[0].value + 1 == sortedList[1].value && sortedList[1].value + 1 == sortedList[2].value && sortedList[2].value + 1 == sortedList[3].value) ||
                (sortedList[1].value + 1 == sortedList[2].value && sortedList[2].value + 1 == sortedList[3].value && sortedList[3].value + 1 == sortedList[4].value)) {
                goodHand = true;
            }

            if (goodHand) {
                return 30;
            } else {
                return 0;
            }
        }

        public int scoreLargeStraight ( List<Die> listDie ) {
            bool goodHand = false;

            List<Die> sortedList = listDie.OrderBy( d => d.value ).ToList();

            if (sortedList[0].value + 1 == sortedList[1].value && sortedList[1].value + 1 == sortedList[2].value && sortedList[2].value + 1 == sortedList[3].value && sortedList[3].value + 1 == sortedList[4].value) {
                goodHand = true;
            }
            if (goodHand) {
                return 40;
            } else {
                return 0;
            }
        }

        public int scoreYahtzee ( List<Die> listDie ) {
            bool goodHand = true;

            int num = listDie[0].value;

            foreach (Die die in listDie) {
                if (die.value != num) {
                    goodHand = false;
                }
            }

            if (goodHand) {
                return 50;
            } else {
                return 0;
            }
        }

        public int scoreChance ( List<Die> listDie ) {
            int total = 0;

            foreach (Die die in listDie) {
                total += die.value;
            }
            
            return total;
        }
    }
}

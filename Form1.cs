using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sluiter_ASG5_Yahtzee {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        Hand hand = new Hand();
        Score score = new Score();

        List<PictureBox> listPicBox = new List<PictureBox>();
        List<Label> listHoldLabel = new List<Label>();
        List<bool> upperScored = new List<bool>();
        List<bool> lowerScored = new List<bool>();
        int upperPoints = 0;
        int lowerPoints = 0;
        int bonusPoints = 0;

        int rollNum = 0;

        private void Form1_Load ( object sender, EventArgs e ) {
            listPicBox.Add( pictureBoxDie1 );
            listPicBox.Add( pictureBoxDie2 );
            listPicBox.Add( pictureBoxDie3 );
            listPicBox.Add( pictureBoxDie4 );
            listPicBox.Add( pictureBoxDie5 );

            listHoldLabel.Add( labelHoldDie1 );
            listHoldLabel.Add( labelHoldDie2 );
            listHoldLabel.Add( labelHoldDie3 );
            listHoldLabel.Add( labelHoldDie4 );
            listHoldLabel.Add( labelHoldDie5 );

            upperScored.Add( false );
            upperScored.Add( false );
            upperScored.Add( false );
            upperScored.Add( false );
            upperScored.Add( false );
            upperScored.Add( false );

            lowerScored.Add( false );
            lowerScored.Add( false );
            lowerScored.Add( false );
            lowerScored.Add( false );
            lowerScored.Add( false );
            lowerScored.Add( false );
            lowerScored.Add( false );

            resetDice();
        }

        private void resetDice () {
            foreach (Label label in listHoldLabel) {
                label.Text = " ";
            }

            foreach (PictureBox picBox in listPicBox) {
                picBox.Image = null;
            }

            hand = new Hand();
            buttonRoll.Enabled = true;
            rollNum = -1;
            updateRollCount();
        }

        private void buttonRoll_Click ( object sender, EventArgs e ) {

            for (int i = 0; i < 5; i++) {
                if (listHoldLabel[i].Text != "Hold") {
                    hand.rollDie( i );
                }
            }

            for (int i = 0; i < 5; i++) {
                if (!(listHoldLabel[i].Text == "Hold")) {
                    listPicBox[i].Image = imageListDie.Images[hand.getDieByIndex( i ).value - 1];
                }
            }
            updateRollCount();
        }

        private void updateRollCount () {
            rollNum++;

            if (rollNum == 3) {
                buttonRoll.Enabled = false;
            }

            labelRollCount.Text = "Roll: " + rollNum.ToString();
        }

        private void toggleHold ( int i ) {
            Label tempLabel = listHoldLabel[i - 1];

            if (rollNum == 0) {
                tempLabel.Text = "";
                return;
            }

            if (tempLabel.Text == "Hold") {
                tempLabel.Text = "";
            } else {
                tempLabel.Text = "Hold";
            }
        }

        private void pictureBoxDie1_Click ( object sender, EventArgs e ) {
            toggleHold( 1 );
        }
        private void pictureBoxDie2_Click ( object sender, EventArgs e ) {
            toggleHold( 2 );
        }
        private void pictureBoxDie3_Click ( object sender, EventArgs e ) {
            toggleHold( 3 );
        }
        private void pictureBoxDie4_Click ( object sender, EventArgs e ) {
            toggleHold( 4 );
        }
        private void pictureBoxDie5_Click ( object sender, EventArgs e ) {
            toggleHold( 5 );
        }

        private void buttonSetUpper_Click ( object sender, EventArgs e ) {
            if (rollNum < 1) {
                return;
            }
            upperScore();
        }

        private void buttonSetLower_Click ( object sender, EventArgs e ) {
            if (rollNum < 1) {
                return;
            }
            lowerScore();
        }

        //Score Upper -- Easy, One method fits all
        private void upperScore () {
            if (listBoxUpper.SelectedIndex == -1) {
                return;
            }

            int selection = listBoxUpper.SelectedIndex;

            if (upperScored[selection]) {
                return;
            } else {
                listBoxUpper.Items[selection] = listBoxUpper.SelectedItem.ToString() + score.scoreUpper( hand.getDice(), selection + 1 ).ToString();
                upperPoints += score.scoreUpper( hand.getDice(), selection + 1 );
                upperScored[selection] = true;
            }

            resetDice();
            updateScoreCounts();
        }

        //Score Lower -- Time For Big Sad
        private void lowerScore () {
            //Theres probably a more legible way to do this but theyre in order so were just gonna use indexes cuz its less effort sorry Andy

            if (listBoxLower.SelectedIndex == -1) {
                return;
            }

            int selection = listBoxLower.SelectedIndex;

            if (lowerScored[selection]) {
                return;
            } else {

                switch (selection) {

                    //Three Of A Kind:
                    case 0:
                        listBoxLower.Items[selection] = listBoxLower.SelectedItem.ToString() + score.score3OfKind( hand.getDice() );
                        lowerPoints += score.score3OfKind( hand.getDice() );
                        lowerScored[selection] = true;
                        break;
                    //Four Of A Kind:
                    case 1:
                        listBoxLower.Items[selection] = listBoxLower.SelectedItem.ToString() + score.score4OfKind( hand.getDice() );
                        lowerPoints += score.score4OfKind( hand.getDice() );
                        lowerScored[selection] = true;
                        break;
                    //Full House:
                    case 2:
                        listBoxLower.Items[selection] = listBoxLower.SelectedItem.ToString() + score.scoreFullHouse( hand.getDice() );
                        lowerPoints += score.scoreFullHouse( hand.getDice() );
                        lowerScored[selection] = true;
                        break;
                    //Small Straight:
                    case 3:
                        listBoxLower.Items[selection] = listBoxLower.SelectedItem.ToString() + score.scoreSmallStraight( hand.getDice() );
                        lowerPoints += score.scoreSmallStraight( hand.getDice() );
                        lowerScored[selection] = true;
                        break;
                    //Large Straight:
                    case 4:
                        listBoxLower.Items[selection] = listBoxLower.SelectedItem.ToString() + score.scoreLargeStraight( hand.getDice() );
                        lowerPoints += score.scoreLargeStraight( hand.getDice() );
                        lowerScored[selection] = true;
                        break;
                    //Yahtzee:
                    case 5:
                        listBoxLower.Items[selection] = listBoxLower.SelectedItem.ToString() + score.scoreYahtzee( hand.getDice() );
                        lowerPoints += score.scoreYahtzee( hand.getDice() );
                        lowerScored[selection] = true;
                        break;
                    //Chance:
                    case 6:
                        listBoxLower.Items[selection] = listBoxLower.SelectedItem.ToString() + score.scoreChance( hand.getDice() );
                        lowerPoints += score.scoreChance( hand.getDice() );
                        lowerScored[selection] = true;
                        break;
                }
            }

            resetDice();
            updateScoreCounts();
        }

        private void updateScoreCounts () {
            if ( upperPoints > 62) {
                bonusPoints = 35;
            }

            labelUpperTotal.Text = upperPoints.ToString();
            labelLowerTotal.Text = lowerPoints.ToString();

            labelBonus.Text = bonusPoints.ToString();
            labelGameTotal.Text = (upperPoints + lowerPoints + bonusPoints).ToString();
        }
    }
}

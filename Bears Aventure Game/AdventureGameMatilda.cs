using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Bears_Aventure_Game
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 101;
            }
            else if (page ==3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 101;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 101;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 100;
            }
            else if (page == 13)
            {
                int chance = randGen.Next(1, 11);
                if (chance <= 3)
                {
                    page = 19;
                }
                else
                {
                    page = 20;
                }
            }
            else if (page == 14)
            {
                page = 101;
            }
            else if (page == 15)
            {
                page = 22;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 100;
            }
            else if (page == 19)
            {
                page = 101;
            }
            else if (page == 100 || page == 101)
            {
                page = 1;
            }

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 15)
            {
                page = 21;
            }
            else if (page == 18)
            {
                page = 101;
            }

            else if (page == 15)
            {
                page = 22;
            }
            else if (page == 20)
            {
                page = 100;
            }
            else if (page == 23)
            {
                int chance = randGen.Next(1, 6);
                if (chance == 1)
                {
                    page = 14;
                }
                else
                {
                    page = 13;
                }
            }
            else if (page == 100 || page == 101)
            {
                page = 102;
            }

            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {

        } 
        public void DisplayPage()
        {
            option1Button.Visible = true;
            option1Button.Enabled = true;
            option2Button.Visible = true;
            option2Button.Enabled = true;

            outputLabel.Text = "The bears play a basketball game against some random teens! The bears lose the game by a lot! They forget their yellow backpack on a bench.";
            option1Label.Text = "Go back to bear cave";
            option2Label.Text = "Go back and find backpack";
            option3Label.Text = "";

            imageBox.Image = Properties.Resources.bearsWithBag;
            SoundPlayer player = new SoundPlayer(Properties.Resources.basketballbouncing);
            player.Play();

            switch (page)
            {
                case 1:

                    option1Button.Visible = true;
                    option1Button.Enabled = true;
                    option2Button.Visible = true;
                    option2Button.Enabled = true;
                    option3Button.Visible = false;
                    option3Button.Enabled = false;

                    outputLabel.Text = "The bears play a basketball game against some random teens! The bears lose the game by a lot! They forget their yellow backpack on a bench.";
                    option1Label.Text = "Go back to bear cave";
                    option2Label.Text = "Go back and find backpack";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.bearsWithBag;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.basketballbouncing);
                    player1.Play();
                    break;
                case 2:
                    option2Button.Visible = false;

                    outputLabel.Text = "The bears would never leave their stuff behind!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.missingBag;
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.gameover);
                    player2.Play();
                    break;
                case 3:

                    outputLabel.Text = "Good choice! The bears would never leave their stuff behind. Unfortunately the bag is gone!";
                    option1Label.Text = "Ask cops for help";
                    option2Label.Text = "Ask pigeons watching basketball game for help";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.missingBag;
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.parknoise);
                    player3.Play();
                    break;
                case 4:
                    option2Button.Visible = false;

                    outputLabel.Text = "The cops are no help!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.cops_are_no_help;
                    SoundPlayer player4 = new SoundPlayer(Properties.Resources.policenoise);
                    player4.Play();
                    break;
                case 5:

                    outputLabel.Text = "Ice bear speaks pigeon and gets one to explain the thief. The suspect is one of the players from the basketball game!";
                    option1Label.Text = "Look in park";
                    option2Label.Text = "Track down suspect";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.asking_pigeons_for_help;
                    SoundPlayer player5 = new SoundPlayer(Properties.Resources.pigeons);
                    player5.Play();
                    break;
                case 6:
                    option2Button.Visible = false;

                    outputLabel.Text = "The bears search for hours and no luck.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.lose_ending;
                    SoundPlayer player6 = new SoundPlayer(Properties.Resources.gameover);
                    player6.Play();
                    break;
                case 7:

                    outputLabel.Text = "The bears find the suspect in an apartment.";
                    option1Label.Text = "Break into the apartment";
                    option2Label.Text = "Expose the suspect online";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.apartment;
                    SoundPlayer player7 = new SoundPlayer(Properties.Resources.citynoise);
                    player7.Play();
                    break;
                case 8:

                    outputLabel.Text = "The bears break into the apartment and toss the bag around until they can escape! They are now on the side of the building! The cops show up with a helicopter and a bunch of cars. They shout for the bears to jump down on a trampoline.";
                    option1Label.Text = "Open bag as proof";
                    option2Label.Text = "Keep bag closed";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.bears_on_side_of_building;
                    SoundPlayer player8 = new SoundPlayer(Properties.Resources.glass);
                    player8.Play();
                    break;
                case 9:
                    option2Button.Visible = false;

                    outputLabel.Text = "That does absolutely nothing!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.expose_online;
                    SoundPlayer player9 = new SoundPlayer(Properties.Resources.gameover);
                    player9.Play();
                    break;
                case 10:

                    outputLabel.Text = "The bears open the bag only to realize that it was actually a dupe! This same yellow backpack actually belongs to the suspect!";
                    option1Label.Text = "apologize";
                    option2Label.Text = "cause a scene";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.bears_on_edge__closeup_;
                    SoundPlayer player10 = new SoundPlayer(Properties.Resources.citynoise);
                    player10.Play();
                    break;
                case 11:
                    option2Button.Visible = false;

                    outputLabel.Text = "The cops believe the bears however they must face the consequences.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.cop_cars;
                    SoundPlayer player11 = new SoundPlayer(Properties.Resources.winmusic);
                    player11.Play();
                    break;
                case 12:
                    option2Button.Visible = false;

                    outputLabel.Text = "Who does that you should've just given up.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.lose_ending;
                    SoundPlayer player12 = new SoundPlayer(Properties.Resources.gameover);
                    player12.Play();
                    break;
                case 13:

                    outputLabel.Text = "The bears jump down onto the trampoline however they manage to bounce off and crash into the next building! All the pigeons are in the building with the backpack!";
                    option1Label.Text = "Report to cops";
                    option2Label.Text = "Attack pigeons";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.shattered;
                    SoundPlayer player13 = new SoundPlayer(Properties.Resources.glass);
                    player13.Play();
                    break;
                case 14:
                    option2Button.Visible = false;

                    outputLabel.Text = "The bears jump down onto the trampoline and make it safely back onto the ground. However they get arrested!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.trampoline;
                    SoundPlayer player14 = new SoundPlayer(Properties.Resources.whoosh);
                    player14.Play();
                    break;
                case 15:

                    outputLabel.Text = "The bears try to sneak away however they are too large for that. They are about to fall off the edge of the building.";
                    option1Label.Text = "Jump off and hope they survive";
                    option2Label.Text = "Hand yourself over and reason with cops";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.bears_on_side_of_building;
                    SoundPlayer player15 = new SoundPlayer(Properties.Resources.citynoise);
                    player15.Play();
                    break;
                case 16:

                    outputLabel.Text = "The cops ask the bears what happened";
                    option1Label.Text = "Tell them the pigeons are thieves";
                    option2Label.Text = "Explain how you broke into someone's apartment";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.cop_cars;
                    SoundPlayer player16 = new SoundPlayer(Properties.Resources.policenoise);
                    player16.Play();
                    break;
                case 17:
                    option2Button.Visible = false;

                    outputLabel.Text = "The cops look into the pigeon situation. The pigeons are actually part of a famous criminal cartel! The bears get their stuff back and all is well!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.bag_recovery_2;
                    SoundPlayer player17 = new SoundPlayer(Properties.Resources.winmusic);
                    player17.Play();
                    break;
                case 18:
                    option2Button.Visible = false;

                    outputLabel.Text = "You are so stupid! The bears are now super guilty!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.lose_ending;
                    SoundPlayer player18 = new SoundPlayer(Properties.Resources.gameover);
                    player18.Play();
                    break;
                case 19:
                    option2Button.Visible = false;

                    outputLabel.Text = "Bad idea! The bears are terrible fighters (besides ice bear) and there are too many pigeons!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.pigeons_building;
                    SoundPlayer player19 = new SoundPlayer(Properties.Resources.gameover);
                    player19.Play();
                    break;
                case 20:
                    option2Button.Visible = false;

                    outputLabel.Text = "The bears manage to fight the pigeons off! The pigeons are actually criminals and the cops thank them!";
                    option1Label.Text = "continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.bag_recovery_2;
                    SoundPlayer player20 = new SoundPlayer(Properties.Resources.pigeons);
                    player20.Play();
                    break;
                case 21:
                    option2Button.Visible = false;

                    outputLabel.Text = "The bears are now injured!";
                    option1Label.Text = "continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.sad;
                    SoundPlayer player21 = new SoundPlayer(Properties.Resources.gameover);
                    player21.Play();
                    break;
                case 22:
                    option2Button.Visible = false;

                    outputLabel.Text = "The cops believe the bears but they are punished!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.bag_recovery;
                    SoundPlayer player22 = new SoundPlayer(Properties.Resources.policenoise);
                    player22.Play();
                    break;
                case 23:

                    outputLabel.Text = "The bears are still in trouble!";
                    option1Label.Text = "Jump";
                    option2Label.Text = "Sneak away";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.bears_on_edge__closeup_;
                    SoundPlayer player23 = new SoundPlayer(Properties.Resources.citynoise);
                    player23.Play();
                    break;
                case 100:

                    outputLabel.Text = "You won :)! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.win_ending;
                    SoundPlayer player24 = new SoundPlayer(Properties.Resources.winmusic);
                    player24.Play();
                    break;
                case 101:

                    outputLabel.Text = "You lost :(! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.lose_ending;
                    SoundPlayer player25 = new SoundPlayer(Properties.Resources.gameover);
                    player25.Play();
                    break;
                case 102:

                    outputLabel.Text = "Thanks for playing!! :)";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    option1Button.Visible = false;
                    option1Button.Enabled = false;
                    option2Button.Visible = false;
                    option2Button.Enabled = false;
                    option3Button.Visible = false;
                    option3Button.Enabled = false;

                    imageBox.Image = Properties.Resources.win_ending;
                    SoundPlayer player26 = new SoundPlayer(Properties.Resources.winmusic);
                    player26.Play();
                    break;

                    Thread.Sleep(3000);

                    this.Close();
                    break;
            }
        }

    }
}

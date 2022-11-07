//Text Adventure Game
//Vaniya Pokusaev


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
using System.Windows.Forms.PropertyGridInternal;

namespace adventureGame
{
    public partial class Form1 : Form
    {

        int pageNum = 1;
        string ending;
        string death;
        Random randNum = new Random();
        int generatedNum;
        string locked = "(locked)";
        bool core1 = false;
        bool core2 = false;
        bool core3 = false;
        int add1;
        int add2;
        int sumAdd;
        int guessedNum;
        int fightChance;
        int colorNum;
        int playerHP = 100;
        int dragonHP = 1000;
        int dragonMelee;
        int dragonRange;
        int chanceItem;
        bool deathOrb = false;
        public Form1()
        {
            InitializeComponent();

            //The Page that is displayed when the player starts the game.
            
            switch (pageNum)
            {
                case 1:
                    playerHealth.Visible = false;
                    dragonHealth.Visible = false;
                    deathOrbLabel.Visible = false;
                    outputLabel.Text = "Ah! A brave adventurer I see. Choose your path";
                    desision1.Text = "Forest";
                    desision2.Text = "Town";
                    break;

            }
        }


        private void desision1_Click(object sender, EventArgs e)
        {
           //If statements that allow for the user to click through pages.
            
            if (pageNum == 1)
            {
                generatedNum = randNum.Next(1, 101);
                switch (generatedNum)
                {
                    //The player has a 1 in 100 chance to get unlucky and die after trying to go to the next page.
                    
                    case 1:
                        ending = "You stepped on a nail and started bleeding";
                        pageNum = 100;
                        break;
                    default:
                        pageNum = 2;
                        break;
                }


            }
            else if (pageNum == 2)
            {
                pageNum = 3;
            }
            else if (pageNum == 3)
            {
                pageNum = 4;
            }
            else if (pageNum == 4)
            {
                pageNum = 5;
            }
            else if (pageNum == 5)
            {
                pageNum = 6;
            }
            else if (pageNum == 6)
            {
                pageNum = 6;
            }
            else if (pageNum == 7)
            {
                pageNum = 8;

            }
            else if (pageNum == 8)
            {
                death = $"Drill too weak";
                pageNum = 99;
            }
            else if (pageNum == 13)
            {
                if (colorNum == 1)
                {
                    pageNum = 11;
                }
            }
            else if (pageNum == 11)
            {
                if (core1 == true && core2 == true && core3 == true) ;
                {
                    ending = $"You found all the cores and completed the quest. Good job.";
                    pageNum = 100;
                }
            }
            else if (pageNum == 16)
            {
                pageNum = 17;
            }
            else if (pageNum == 17)
            {
                pageNum = 18;
            }
            else if (pageNum == 18)
            {
                //A player vs enviornment system where the player will deal a set amount of damage to the dragon while the dragon will deal a range of damage to a player.
                
                dragonMelee = randNum.Next(5, 16);
                playerHP -= dragonMelee;
                dragonHP -= 100;
                outputLabel.Text = "You hit the dragon with melee attack";
                if (dragonHP == 0 || dragonHP < 0)
                {
                    ending = "You defeated the dragon. Melee Victory";
                    pageNum = 100;
                }
                else if (playerHP == 0 || playerHP < 0)
                {
                    death = "You died to the dragon trying to melee it";
                    pageNum = 99;
                }
                else
                {
                    pageNum = 18;
                }
            }
            
            //Ending and Death pages where the player can restart the game.
            else if (pageNum == 99)
            {

                Application.Restart();
            }
            else if (pageNum == 100)
            {
                Application.Restart();
            }



            //Switch cases that displays what is on each page.
            
            switch (pageNum)
            {
                case 1:
                    outputLabel.Text = "Ah! A brave adventurer I see. Choose your path";
                    desision1.Text = "Forest";
                    desision2.Text = $"Town {locked}";

                    break;
                case 2:
                    outputLabel.Text = "You run into an enemy. Fight it?";
                    desision1.Text = "No";
                    desision2.Text = "Yes";
                    break;
                case 3:
                    outputLabel.Text = "It begins to get dark as you adventure. Sleep?";
                    desision1.Text = "Continue";
                    desision2.Text = "Sleep";
                    break;
                case 4:
                    outputLabel.Text = "You find a building. Enter?";
                    desision1.Text = "Yes";
                    desision2.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You see a man inside offering you a quest. Do you accept it?";
                    desision1.Text = "Accept";
                    desision2.Text = "Decline";
                    break;
                case 6:
                    outputLabel.Text = "You are brought back to where you started. It seems a new path is unlocked.";
                    desision1.Text = $"Forest {locked}";
                    desision2.Text = "Town";
                    break;
                case 7:
                    outputLabel.Text = "You see three strange buildings. Which one do you enter?";
                    desision1.Text = "Building 1";
                    desision2.Text = "Building 2";
                    desision3.Text = "Building 3";
                    break;
                case 8:
                    outputLabel.Text = "You find a safe with something inside. What do you use to break in?";
                    desision1.Text = "Drill";
                    desision2.Text = "Pencil";
                    desision3.Text = "A pipe bomb made using quora posts";
                    break;
                case 9:
                    outputLabel.Text = "You found core 2";
                    desision1.Text = "Building 1";
                    desision2.Text = $"Building 2 {locked}";
                    desision3.Text = "Building 3";
                    break;
                case 10:
                    outputLabel.Text = "You found core 1";
                    desision1.Text = $"Building 1 {locked}";
                    desision2.Text = "Building 2";
                    desision3.Text = "Building 3";
                    break;
                case 11:
                    backgroundLabel.BackColor = Color.White;
                    outputLabel.Text = "You found core 3";
                    desision1.Text = "";
                    desision2.Text = "Complete Quest";
                    desision3.Text = $"";
                    if (core1 == true && core2 == true && core3 == true) ;
                    {
                        ending = $"You found all the cores and completed the quest. Good job.";
                        pageNum = 100;
                    }
                    break;
                case 16:
                    outputLabel.Text = "You receive a set of armor, weapons and tools. Where do you go next?";
                    desision1.Text = "South";
                    desision2.Text = "North";
                    desision3.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "You see a cave and a structure in the distance. Which do you enter?";
                    desision1.Text = "Cave";
                    desision2.Text = "Structure";
                    desision3.Text = "";
                    break;
                case 18:
                    playerHealth.Visible = true;
                    dragonHealth.Visible = true;
                    playerHealth.Text = $"Player Health: {playerHP}";
                    dragonHealth.Text = $"Dragon Health: {dragonHP}";
                    outputLabel.Text = "You find a dragon in the cave";
                    desision1.Text = "Use melee attack";
                    desision2.Text = "Use ranged attack";
                    break;
                case 99:
                    outputLabel.Text = $"You died: {death}, no ending for you haha";
                    desision1.Text = "Restart";
                    desision2.Text = "Quit";
                    playerHealth.Visible = false;
                    dragonHealth.Visible = false;
                    break;

                case 100:
                    playerHealth.Visible = false;
                    dragonHealth.Visible = false;
                    outputLabel.Text = $"Ending: {ending}";
                    desision1.Text = "Restart";
                    desision2.Text = "Quit";
                    break;
            }
        }

        private void desision2_Click(object sender, EventArgs e)
        {
            if (pageNum == 1)
            {
                pageNum = 1;
            }
            else if (pageNum == 2)
            {
                pageNum = 14;
            }
            else if (pageNum == 3)
            {
                ending = "Ghost Parade";
                pageNum = 100;
            }
            else if (pageNum == 4)
            {
                pageNum = 5;
            }
            else if (pageNum == 5)
            {
                pageNum = 6;
            }
            else if (pageNum == 6)
            {
                pageNum = 7;
            }
            else if (pageNum == 7)
            {
                pageNum = 12;
            }
            else if (pageNum == 8)
            {
                pageNum = 9;
                core2 = true;
            }
            else if (pageNum == 12)
            {
                if (guessedNum == sumAdd)
                {
                    pageNum = 10;
                }
            }
            else if (pageNum == 9)
            {
                pageNum = 12;
            }
            else if (pageNum == 11)
            {
                pageNum = 12;
            }
            else if (pageNum == 13)
            {
                if (colorNum == 2)
                {
                    pageNum = 11;
                }
            }
            else if (pageNum == 11)
            {
                if (core1 == true && core2 == true && core3 == true) ;
                {
                    ending = $"You found all the cores and completed the quest. Good job.";
                    pageNum = 98;
                }
            }
            else if (pageNum == 98)
            {
                pageNum = 100;
            }
            else if (pageNum == 15)
            {
                pageNum = 16;
            }
            else if (pageNum == 16)
            {
                ending = "You run into a pack of wolves. You try to escape but the wolves tear you apart.";
                pageNum = 100;
            }
            else if (pageNum == 17)
            {
                pageNum = 5;
            }
            else if (pageNum == 18)
            {
                dragonRange = randNum.Next(1, 16);
                playerHP -= dragonRange;
                dragonHP -= 50;
                outputLabel.Text = "You hit the dragon with a ranged attack";
                if (dragonHP == 0 || dragonHP < 0)
                {
                    ending = "You defeated the dragon. Ranged Victory";
                    pageNum = 100;
                }
                else if (playerHP == 0 || playerHP < 0)
                {
                    death = "You died to the dragon trying to hit it with ranged attack";
                    pageNum = 99;
                }
                else
                {
                    pageNum = 18;
                }
            }
            else if (pageNum == 99)
            {

                Application.Exit();
            }
            else if (pageNum == 100)
            {
                Application.Exit();
            }



            switch (pageNum)
            {
                case 1:
                    outputLabel.Text = "Ah! A brave adventurer I see. Choose your path";
                    desision1.Text = "Forest";
                    desision2.Text = $"Town {locked}";
                    break;
                case 2:
                    outputLabel.Text = "You run into an enemy. Fight it?";
                    desision1.Text = "No";
                    desision2.Text = "Yes";
                    break;
                case 3:
                    outputLabel.Text = "It begins to get dark as you adventure. Sleep?";
                    desision1.Text = "Continue";
                    desision2.Text = "Sleep";
                    break;
                case 4:
                    outputLabel.Text = "You find a building. Enter?";
                    desision1.Text = "Yes";
                    desision2.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You see a man inside offering you a quest. Do you accept it?";
                    desision1.Text = "Accept";
                    desision2.Text = "Decline";
                    break;
                case 6:
                    outputLabel.Text = "You are brought back to where you started. It seems a new path is unlocked.";
                    desision1.Text = "Forest";
                    desision2.Text = "Town";
                    break;
                case 7:
                    outputLabel.Text = "You see three strange buildings. Which one do you enter?";
                    desision1.Text = "Building 1";
                    desision2.Text = "Building 2";
                    desision3.Text = "Building 3";
                    break;
                case 8:
                    outputLabel.Text = "You find a safe with something inside. What do you use to break in?";
                    desision1.Text = "Drill";
                    desision2.Text = "Pencil";
                    desision3.Text = "A pipe bomb made using quora posts";
                    break;
                case 9:
                    outputLabel.Text = "You found core 2";
                    guessTextLabel.Visible = false;
                    backgroundLabel.BackColor = Color.White;
                    desision1.Text = "Building 1";
                    desision2.Text = $"Building 2";
                    desision3.Text = "Building 3";
                    break;
                case 10:
                    guessTextLabel.Visible = false;
                    outputLabel.Text = "You found core 1";

                    backgroundLabel.BackColor = Color.White;
                    desision1.Text = $"Building 1 ";
                    desision2.Text = "Building 2";
                    desision3.Text = "Building 3";
                    break;
                case 11:
                    outputLabel.Text = "You found core 3";
                    guessTextLabel.Visible = false;
                    backgroundLabel.BackColor = Color.White;
                    desision1.Text = "";
                    desision2.Text = "Complete Quest";
                    desision3.Text = $"";
                    if (core1 == true && core2 == true && core3 == true) ;
                    {
                        ending = $"You found all the cores and completed the quest. Good job.";
                        pageNum = 100;
                    }
                    break;
                case 12:


                    add1 = randNum.Next(1, 100);
                    add2 = randNum.Next(1, 100);
                    sumAdd = add1 + add2;
                    guessTextLabel.Visible = true;

                    if (guessedNum == sumAdd)
                    {
                        pageNum = 10;
                        core1 = true;
                    }
                    outputLabel.Text = $"Answer the simple math question. What is {add1} + {add2}";
                    desision1.Text = "";
                    desision2.Text = "Answer";
                    desision3.Text = "";
                    break;
                case 13:
                    guessTextLabel.Visible = false;
                    colorNum = randNum.Next(1, 4);
                    outputLabel.Text = "What is the color of this?";
                    desision1.Text = "Red";
                    desision2.Text = "Green";
                    desision3.Text = "Blue";
                    switch (colorNum)
                    {
                        case 1:
                            backgroundLabel.BackColor = Color.Red;
                            break;
                        case 2:
                            backgroundLabel.BackColor = Color.Green;
                            break;
                        case 3:
                            backgroundLabel.BackColor = Color.Blue;
                            break;

                    }

                    break;
                case 14:
                    fightChance = randNum.Next(1, 5);
                    switch (fightChance)
                    {
                        case 1:
                            pageNum = 15;
                            chanceItem = randNum.Next(1, 5);
                            switch (chanceItem)
                            {
                                case 1:
                                    deathOrb = true;
                                    deathOrbLabel.Visible = true;
                                    break;
                            }
                            break;
                        default:
                            death = $"Unfair Fight";
                            pageNum = 99;
                            break;
                    }
                    break;
                case 15:
                    break;
                case 16:
                    outputLabel.Text = "You receive a set of armor, weapons and tools. Where do you go next?";
                    desision1.Text = "South";
                    desision2.Text = "North";
                    desision3.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "You see a cave and a structure in the distance. Which do you enter?";
                    desision1.Text = "Cave";
                    desision2.Text = "Structure";
                    desision3.Text = "";
                    break;
                case 18:
                    playerHealth.Visible = true;
                    dragonHealth.Visible = true;
                    playerHealth.Text = $"Player Health: {playerHP}";
                    dragonHealth.Text = $"Dragon Health: {dragonHP}";
                    outputLabel.Text = "You find a dragon in the cave";
                    desision1.Text = "Use melee attack";
                    desision2.Text = "Use ranged attack";
                    if (deathOrb == true)
                    {
                        desision3.Text = "Use Death Orb";
                    }
                    break;
                case 98:
                    break;
                case 99:
                    playerHealth.Visible = false;
                    dragonHealth.Visible = false;
                    outputLabel.Text = $"You died: {death}, no ending for you haha";
                    desision1.Text = "Restart";
                    desision2.Text = "Quit";
                    break;
                case 100:
                    playerHealth.Visible = false;
                    dragonHealth.Visible = false;
                    outputLabel.Text = $"Ending: {ending}";
                    desision1.Text = "Restart";
                    desision2.Text = "Quit";
                    break;
            }
        }

        private void desision3_Click(object sender, EventArgs e)
        {
            if (pageNum == 8)
            {
                pageNum = 99;
                death = "The safe is made out of many layers of graphite, bomb was weak";
            }
            else if (pageNum == 7)
            {
                pageNum = 13;
            }
            else if (pageNum == 13)
            {
                if (colorNum == 3)
                {
                    pageNum = 11;
                }
            }
            else if (pageNum == 9)
            {
                pageNum = 13;
            }
            else if (pageNum == 10)
            {
                pageNum = 13;
            }
            else if (pageNum == 11)
            {
                pageNum = 13;
            }
            else if (pageNum == 11)
            {
                if (core1 == true && core2 == true && core3 == true) ;
                {
                    ending = $"You found all the cores and completed the quest. Good job.";
                    pageNum = 100;
                }
            }
            else if (pageNum == 18)
            {

                dragonHP = 0;
                ending = "You defeated the dragon with the death orb";
                pageNum = 100;
            }

            switch (pageNum)
            {
                case 7:
                    outputLabel.Text = "You see three strange buildings. Which one do you enter?";
                    guessTextLabel.Visible = false;
                    backgroundLabel.BackColor = Color.White;
                    desision1.Text = "Building 1";
                    desision2.Text = "Building 2";
                    desision3.Text = "Building 3";
                    break;
                case 8:
                    outputLabel.Text = "You find a safe with something inside. What do you use to break in?";
                    desision1.Text = "Drill";
                    desision2.Text = "Pencil";
                    desision3.Text = "A pipe bomb made using quora posts";
                    break;
                case 11:
                    outputLabel.Text = "You found core 3";
                    guessTextLabel.Visible = false;
                    backgroundLabel.BackColor = Color.White;
                    desision1.Text = "";
                    desision2.Text = "Complete Quest";
                    desision3.Text = $"";
                    if (core1 == true && core2 == true && core3 == true) ;
                    {
                        ending = $"You found all the cores and completed the quest. Good job.";
                        pageNum = 98;
                    }
                    break;

                case 13:
                    guessTextLabel.Visible = false;
                    colorNum = randNum.Next(1, 4);
                    outputLabel.Text = "What is the color of this?";
                    desision1.Text = "Red";
                    desision2.Text = "Green";
                    desision3.Text = "Blue";
                    switch (colorNum)
                    switch (colorNum)
                    switch (colorNum)
                    {
                        case 1:
                            backgroundLabel.BackColor = Color.Red;
                            break;
                        case 2:
                            backgroundLabel.BackColor = Color.Green;
                            break;
                        case 3:
                            backgroundLabel.BackColor = Color.Blue;
                            break;

                    }
                    break;
                case 18:
                    if (deathOrb == true)
                    {
                        desision3.Text = "Use Death Orb";
                    }
                    playerHealth.Visible = true;
                    dragonHealth.Visible = true;
                    playerHealth.Text = $"Player Health: {playerHP}";
                    dragonHealth.Text = $"Dragon Health: {dragonHP}";
                    outputLabel.Text = "You find a dragon in the cave";
                    desision1.Text = "Use melee attack";
                    desision2.Text = "Use ranged attack";

                    break;
                case 98:
                    break;
                case 99:
                    outputLabel.Text = $"You died: {death}, no ending for you haha";
                    desision1.Text = "Restart";
                    desision2.Text = "Quit";
                    break;
                case 100:
                    outputLabel.Text = $"Ending: {ending}";
                    desision1.Text = "Restart";
                    desision2.Text = "Quit";
                    break;
            }
        }

        private void guessTextLabel_TextChanged(object sender, EventArgs e)
        {
            guessedNum = Convert.ToInt32(guessTextLabel.Text);
        }
    }
}
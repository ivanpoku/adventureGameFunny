using System.Runtime.Versioning;
using System.Xml;

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
        public Form1()
        {
            InitializeComponent();

            switch (pageNum)
            {
                case 1:
                    outputLabel.Text = "Ah! A brave adventurer I see. Choose your path";
                    desision1.Text = "Forest";
                    desision2.Text = "Town";
                    break;
                
            }
        }


        private void desision1_Click(object sender, EventArgs e)
        {
            if (pageNum == 1)
            {
                generatedNum = randNum.Next(1, 100);
                switch (generatedNum)
                {
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
                    desision1.Text = $"Forest {locked}" ;
                    desision2.Text = "Town";
                    break;
                case 7:
                    outputLabel.Text = "You see three strange buildings. Which one do you enter?";
                    desision1.Text = "Building 1";
                    desision2.Text = "Building 2";
                    desision3.Text = "Building 3";
                    break ;
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
                    outputLabel.Text = "You found core 3";
                    desision1.Text = "Building 1";
                    desision2.Text = "Building 2";
                    desision3.Text = $"Building 3 {locked}";
                    break;
                case 100:
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
                pageNum = 2;
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
                    desision1.Text = "Building 1";
                    desision2.Text = $"Building 2";
                    desision3.Text = "Building 3";
                    break;
                case 10:
                    guessTextLabel.Visible = false;
                    outputLabel.Text = "You found core 1";
                    desision1.Text = $"Building 1 ";
                    desision2.Text = "Building 2";
                    desision3.Text = "Building 3";
                    break;
                case 11:
                    outputLabel.Text = "You found core 3";
                    desision1.Text = "Building 1";
                    desision2.Text = "Building 2";
                    desision3.Text = $"Building 3";
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
                    guessTextLabel.Visible = true;
                    generatedNum = randNum.Next(1, 1000);
                    outputLabel.Text = "Guess the number out of 1000";
                    desision1.Text = "";
                    desision2.Text = "Answer";
                    desision3.Text = "";
                    if (guessedNum == generatedNum)
                    {
                        pageNum = 10;
                        core3 = true;
                    }
                    else if (guessedNum > generatedNum)
                    {
                        outputLabel.Text = "Too high";
                    }
                    else if (guessedNum < generatedNum)
                    {
                        outputLabel.Text = "Too low";
                    }
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
                if (guessedNum == generatedNum)
                {
                    pageNum = 10;
                }
            }
            switch (pageNum)
            {
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

                case 13:
                    guessTextLabel.Visible = true;
                    generatedNum = randNum.Next(1, 1000);
                    outputLabel.Text = "Guess the number out of 1000";
                    desision1.Text = "";
                    desision2.Text = "Answer";
                    desision3.Text = "";
                    if (guessedNum == generatedNum)
                    {
                        pageNum = 10;
                        core3 = true;
                    }
                    else if (guessedNum > generatedNum)
                    {
                        outputLabel.Text = "Too high";
                    }
                    else if (guessedNum < generatedNum)
                    {
                        outputLabel.Text = "Too low";
                    }
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
using System.Runtime.Versioning;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        
        int pageNum = 1;
        string ending;
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
                pageNum = 2;
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


            switch (pageNum)
            {
                case 1:
                    outputLabel.Text = "Ah! A brave adventurer I see. Choose your path";
                    desision1.Text = "Forest";
                    desision2.Text = "Town";
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

            switch (pageNum)
            {
                case 1:
                    outputLabel.Text = "Ah! A brave adventurer I see. Choose your path";
                    desision1.Text = "Forest";
                    desision2.Text = "Town";
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
                case 100:
                    outputLabel.Text = $"Ending: {ending}";
                    desision1.Text = "Restart";
                    desision2.Text = "Quit";
                    break;
            }
        }

        private void desision3_Click(object sender, EventArgs e)
        {
            
        }
        
        
        
    }
}
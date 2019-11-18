using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tajinder_dog_race
{
    public partial class Form1 : Form
    {
        String[] credential = { "", "", "" };
        int[] payment = { 120, 120, 120 };
        int indx = 0;
        public Form1()
        {
            InitializeComponent();
            addAmount();
            printBudget();

        }
        //method to add the bet amount in the combo box for selection of the player to bet in the game
        public void addAmount() {
            selectamount.Items.Clear();
            for (int y=1;y<=50;y++) {
                selectamount.Items.Add(y.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void setbet_Click(object sender, EventArgs e)
        {
            //condition to check the bet amount and pass to the array to store them 
            if (selectplayer.Text.ToString().Equals("") || selectamount.Text.ToString().Equals("") || selectdog.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select one item from the 3 combo box ");
            }
            else {

                if (selectplayer.SelectedIndex == 0 && Convert.ToInt32(selectamount.SelectedItem.ToString()) <= payment[0])
                {
                    credential[0] = selectplayer.Text + "-" + selectdog.Text + "-" + selectamount.Text;
                    indx++;
                }
                else if (selectplayer.SelectedIndex == 1 && Convert.ToInt32(selectamount.SelectedItem.ToString()) <= payment[1])
                {
                    credential[1] = selectplayer.Text + "-" + selectdog.Text + "-" + selectamount.Text;
                    indx++;

                }
                else if (selectplayer.SelectedIndex == 2 && Convert.ToInt32(selectamount.SelectedItem.ToString()) <= payment[2])
                {
                    credential[2] = selectplayer.Text + "-" + selectdog.Text + "-" + selectamount.Text;
                    indx++;
                }
                else {
                    MessageBox.Show("You don't have enough balance to bet ");
                }

                // store the detail in the array for future refrenece 
                
             
            }
        }

        private void readyrace_Click(object sender, EventArgs e)
        {
            // if we choose atleast one player for the bet only after that the game will start other wise race will not start 
            if (indx>0) {
                //start the timer to work 
                timer1.Start();
                indx = 0;
            }
            else{
                // if we didnot choose any player and click on the race button to start the race  the else bloack will work 
                MessageBox.Show("you have to select atleast one player for the bet ");
            }
        }

        public void printBudget() {
            for (int y=0;y<3;y++) {
                MessageBox.Show(selectplayer.Items[y] + " has " + payment[y] + " budget");
            }

            label3.Text = "Balance of Tajinder is $" + payment[0];
            label4.Text = "Balance of Harman is $" + payment[1];
            label5.Text = "Balance of Jarman is $" + payment[2];


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //check the value to move the dog from one location to another 
            if (picture1.Left>500) {
                //stop the timer 
                timer1.Stop();
                MessageBox.Show("Dog 1 is the winner ");
                //check the value and pass to the array with payment 
                if (credential[0].Contains("-")) {
                    payment[0] = new ground().show_Result(credential[0], 1, payment[0]);
                }
                if (credential[1].Contains("-"))
                {
                    payment[1] = new ground().show_Result(credential[1], 1, payment[1]);
                }
                if (credential[2].Contains("-"))
                {
                    payment[2] = new ground().show_Result(credential[2], 1, payment[2]);
                }
                credential[0] = "";
                credential[1] = "";
                credential[2] = "";
                picture1.Left = 0;
                picture2.Left = 0;
                picture3.Left = 0;
                picture4.Left = 0;
                indx = 0;
                printBudget();
            }

            if (picture2.Left > 500)
            {
                //stop the timer 
                timer1.Stop();

                MessageBox.Show("Dog 2 is the winner ");

                //check the value and pass to the array with payment 
                if (credential[0].Contains("-"))
                {
                    payment[0] = new ground().show_Result(credential[0], 2, payment[0]);
                }
                if (credential[1].Contains("-"))
                {
                    payment[1] = new ground().show_Result(credential[1], 2, payment[1]);
                }
                if (credential[2].Contains("-"))
                {
                    payment[2] = new ground().show_Result(credential[2], 2, payment[2]);
                }

                credential[0] = "";
                credential[1] = "";
                credential[2] = "";
                picture1.Left = 0;
                picture2.Left = 0;
                picture3.Left = 0;
                picture4.Left = 0;
                indx = 0;
                printBudget();
            }

            if (picture3.Left > 500)
            {
                timer1.Stop();
                MessageBox.Show("Dog 3 is the winner ");
                //check the value and pass to the array with payment 
                if (credential[0].Contains("-"))
                {
                    payment[0] = new ground().show_Result(credential[0], 3, payment[0]);
                }
                if (credential[1].Contains("-"))
                {
                    payment[1] = new ground().show_Result(credential[1], 3, payment[1]);
                }
                if (credential[2].Contains("-"))
                {
                    payment[2] = new ground().show_Result(credential[2], 3, payment[2]);
                }
                credential[0] = "";
                credential[1] = "";
                credential[2] = "";
                picture1.Left = 0;
                picture2.Left = 0;
                picture3.Left = 0;
                picture4.Left = 0;
                indx = 0;
                printBudget();
            }

            if (picture4.Left > 500)
            {
                timer1.Stop();
                MessageBox.Show("Dog 4 is the winner ");
                //check the value and pass to the array with payment 
                if (credential[0].Contains("-"))
                {
                    payment[0] = new ground().show_Result(credential[0], 4, payment[0]);
                }
                if (credential[1].Contains("-"))
                {
                    payment[1] = new ground().show_Result(credential[1], 4, payment[1]);
                }
                if (credential[2].Contains("-"))
                {
                    payment[2] = new ground().show_Result(credential[2], 4, payment[2]);
                }
                credential[0] = "";
                credential[1] = "";
                credential[2] = "";
                picture1.Left = 0;
                picture2.Left = 0;
                picture3.Left = 0;
                picture4.Left = 0;
                indx = 0;
                printBudget();
            }

            picture1.Left += new ground().jump();
            picture2.Left += new ground().jump();
            picture3.Left += new ground().jump();
            picture4.Left += new ground().jump();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

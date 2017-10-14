using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackGenCsharp
{
    public partial class Form1 : Form
    {
        //Open File dialog
        //plug in text file
        //put text file in text box
        //get number from num iterations
        //for loop for number of iterations

        //integer for the desired number of opened card packs
        //array to hold every possible card
        int numPacks; string[] cards; string chosenDeck;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Text (*.txt)|*.txt";
            if (System.Windows.Forms.DialogResult.OK == openfile.ShowDialog())
            {
                string myfile = openfile.FileName;
                chosenDeck = myfile;
                cards = File.ReadAllLines(myfile);

                //for each loop to put every card in the left list box to show possibles
                foreach (string item in cards)
                {
                    lbPossibles.Items.Add(item);
                }                          

            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            //Checking if number of packs is empty
            if (tbPack.Text != "")
            {
                numPacks = int.Parse(tbPack.Text);
                Random r = new Random();

                //Checking if number of packs is not zero or a negative number
                if (numPacks >= 1)
                {
                    //Checking if deck file is selected
                    if (cards != null)
                    {
                        //for loop to run for every pack
                        for (int i = 0; i < numPacks; i++)
                        {
                            //for loop to randomly draw five cards for every pack
                            for (int j = 0; j < 5; j++)
                            {
                                lbDraws.Items.Add(cards[r.Next(cards.Length)]);
                            }
                            //add a space to seperate packs
                            lbDraws.Items.Add("");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must select a valid deck file!");
                    }
                }
                else
                {
                    MessageBox.Show("You must type a positive number of card packs, at least one or more!");
                }
            }
            else
            {
                MessageBox.Show("You must select a number of card packs to open!");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbPack_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 
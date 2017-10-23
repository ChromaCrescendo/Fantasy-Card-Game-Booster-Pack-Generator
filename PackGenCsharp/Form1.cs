using System;
using System.ComponentModel;
using System.IO;
using System.Text;
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
        int numPacks; string[] cards; string chosenDeck; string DeckPath; 
         
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
                DeckPath = openfile.FileName;
                chosenDeck = DeckPath;
                cards = File.ReadAllLines(DeckPath);

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
                        StringBuilder sbDraws = new StringBuilder();
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            tbPack.Text = "";
            lbPossibles.Items.Clear();
            lbDraws.Items.Clear();
            cards = null;
            DeckPath = null;
            chosenDeck = null;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text (*.txt)|*.txt";
            if (System.Windows.Forms.DialogResult.OK == savefile.ShowDialog())
            {
                //try to save file at path chosen in save file dialog
                try
                {
                    string filePath = savefile.FileName;
                    //string safeFilePath = Path.GetFileName(filePath);
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(filePath);
                    foreach (var item in lbDraws.Items)
                    {
                        SaveFile.WriteLine(item);
                    }
                    MessageBox.Show("File Written to: " + filePath);
                }
                //throw error message for every exception
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
 
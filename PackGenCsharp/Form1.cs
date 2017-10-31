using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

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
        //store a name for the app, change-able if needed
        string AppName = "Booster Packer";
         
        public Form1()
        {
            InitializeComponent();
        }

        void ChangeTheme(int themeNum)
        {
            switch (themeNum)
            {
                //Default theme
                case 0:
                    Form1.ActiveForm.BackColor = SystemColors.Control;
                    Form1.ActiveForm.ForeColor = Color.Black;
                    defaultToolStripMenuItem.Checked = true;
                    darkToolStripMenuItem.Checked = false;
                    marbleToolStripMenuItem.Checked = false;
                    /*toolStrip1.BackColor = SystemColors.Control;
                    toolStrip1.ForeColor = Color.Black;

                    tbPack.ForeColor = Color.Black;
                    tbPack.BackColor = Color.White;
                    lbPossibles.ForeColor = Color.Black;
                    lbPossibles.BackColor = Color.White;
                    lbDraws.ForeColor = Color.Black;
                    lbDraws.BackColor = Color.White;*/
                    //Form1.ActiveForm.BackColor = menuStrip1.BackColor;
                    break;
                //Dark theme
                case 1:
                    Form1.ActiveForm.BackColor = SystemColors.ControlDarkDark;
                    Form1.ActiveForm.ForeColor = Color.WhiteSmoke;
                    darkToolStripMenuItem.Checked = true;
                    marbleToolStripMenuItem.Checked = false;
                    defaultToolStripMenuItem.Checked = false;
                    /*toolStrip1.BackColor = SystemColors.ControlDarkDark;
                    toolStrip1.ForeColor = Color.WhiteSmoke;

                    tbPack.ForeColor = Color.WhiteSmoke;
                    tbPack.BackColor = SystemColors.ControlDarkDark;
                    lbPossibles.ForeColor = Color.WhiteSmoke;
                    lbPossibles.BackColor = SystemColors.ControlDarkDark;
                    lbDraws.ForeColor = Color.WhiteSmoke;
                    lbDraws.BackColor = SystemColors.ControlDarkDark;
                    Form1.ActiveForm.BackColor = toolStrip1.BackColor;*/
                    break;
                //Marble theme
                case 2:
                    Form1.ActiveForm.BackColor = Color.OrangeRed;
                    Form1.ActiveForm.ForeColor = Color.Yellow;
                    marbleToolStripMenuItem.Checked = true;
                    defaultToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;
                    /*toolStrip1.BackColor = Color.Firebrick;
                    toolStrip1.ForeColor = Color.LightYellow;

                    tbPack.ForeColor = Color.Yellow;
                    tbPack.BackColor = Color.OrangeRed;
                    lbPossibles.ForeColor = Color.Yellow;
                    lbPossibles.BackColor = Color.OrangeRed;
                    lbDraws.ForeColor = Color.Yellow;
                    lbDraws.BackColor = Color.OrangeRed;*/
                    //Form1.ActiveForm.BackColor = menuStrip1.BackColor;
                    break;
            }
            //waterfall the form1 back color and fore color to other controls
            tbPack.ForeColor = Form1.ActiveForm.ForeColor;
            tbPack.BackColor = Form1.ActiveForm.BackColor;
            lbPossibles.ForeColor = Form1.ActiveForm.ForeColor;
            lbPossibles.BackColor = Form1.ActiveForm.BackColor;
            lbDraws.ForeColor = Form1.ActiveForm.ForeColor;
            lbDraws.BackColor = Form1.ActiveForm.BackColor;
            btnPick.ForeColor = Form1.ActiveForm.ForeColor;
            btnPick.BackColor = Form1.ActiveForm.BackColor;
            btnGen.ForeColor = Form1.ActiveForm.ForeColor;
            btnGen.BackColor = Form1.ActiveForm.BackColor;
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ForeColor = Color.Black;

            //If custom font color...(ORIGINAL)
            /*if (chosenColor != null)
            {//Ask if the user wants to keep it
                string keepColor = Prompt.ShowDialog("Would you like to keep your custom font color?", "Keep font color?").ToUpper();

                if (keepColor == "YES")
                {//User wants to keep his custom font color
                    rtb.ForeColor = Color.FromName(chosenColor);
                }
                else
                {//User doesn't want to keep custom font color, trash custom color reference
                    chosenColor = null;
                }
            }*/
            //If custom font color...
            /* if (chosenColor != null)
             {//Keep the custom font color
                 rtb.ForeColor = Color.FromName(chosenColor);
             }*/
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
            //Try to parse the number of packs to open
            if (int.TryParse(tbPack.Text, out numPacks) && numPacks >= 1)
            {
                //old way
                //numPacks = int.Parse(tbPack.Text);
                Random r = new Random();

                //Checking if number of packs is not zero or a negative number
                    //Checking if deck file is selected
                    if (cards != null)
                    {
                        //StringBuilder sbDraws = new StringBuilder();
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
                MessageBox.Show("You must select a valid number of card packs to open!\nAt least one or more, no commas!");
                tbPack.Focus();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppName + " is a free, open-source booster pack generator, for automating the opening of card packs for custom card games, and saving your results on the fly!\n" +
                "Try the following steps to get your packs opened!\n\n" +
                "1. Open a source text file, where your cards are stored line-by-line, with no spaces, using the 'Pick Source' button\n" +
                "2. Specify a number of card packs to open in the text box\n" +
                "3. Click the 'Open Packs' button to generate your results\n" +
                "(optional) 4. Click the 'Save' button to save your results to a text file\n\n"+
                "Original Author: Robert Tripp Ross IV\n" +
                "V0.1\n");
            tbPack.Focus();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(0);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(1);
        }

        private void marbleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(2);
        }
    }
}
 
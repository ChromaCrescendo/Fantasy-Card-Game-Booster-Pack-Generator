namespace PackGenCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPack = new System.Windows.Forms.TextBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.lbPossibles = new System.Windows.Forms.ListBox();
            this.lbDraws = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPack
            // 
            this.tbPack.Location = new System.Drawing.Point(372, 11);
            this.tbPack.Name = "tbPack";
            this.tbPack.Size = new System.Drawing.Size(37, 20);
            this.tbPack.TabIndex = 0;
            this.tbPack.TextChanged += new System.EventHandler(this.tbPack_TextChanged);
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(148, 10);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 1;
            this.btnPick.Text = "Pick Deck";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(413, 10);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Open Packs";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // lbPossibles
            // 
            this.lbPossibles.FormattingEnabled = true;
            this.lbPossibles.Location = new System.Drawing.Point(12, 58);
            this.lbPossibles.Name = "lbPossibles";
            this.lbPossibles.Size = new System.Drawing.Size(211, 251);
            this.lbPossibles.TabIndex = 5;
            // 
            // lbDraws
            // 
            this.lbDraws.FormattingEnabled = true;
            this.lbDraws.Location = new System.Drawing.Point(277, 58);
            this.lbDraws.Name = "lbDraws";
            this.lbDraws.Size = new System.Drawing.Size(211, 251);
            this.lbDraws.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Packs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Possible Cards:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opened Packs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDraws);
            this.Controls.Add(this.lbPossibles);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.tbPack);
            this.Name = "Form1";
            this.Text = "Legends Of Today (Pack Opener)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPack;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ListBox lbPossibles;
        private System.Windows.Forms.ListBox lbDraws;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


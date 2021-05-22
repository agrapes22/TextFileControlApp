namespace TextFileControlApp
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textLower = new System.Windows.Forms.Label();
            this.firstWord = new System.Windows.Forms.Label();
            this.lastWord = new System.Windows.Forms.Label();
            this.longestWord = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mostVowels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Filter = "\"Text|*.txt|All|*.*\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textLower
            // 
            this.textLower.AutoSize = true;
            this.textLower.Location = new System.Drawing.Point(208, 159);
            this.textLower.Name = "textLower";
            this.textLower.Size = new System.Drawing.Size(35, 13);
            this.textLower.TabIndex = 1;
            this.textLower.Text = "label1";
            this.textLower.Visible = false;
            // 
            // firstWord
            // 
            this.firstWord.AutoSize = true;
            this.firstWord.Location = new System.Drawing.Point(208, 198);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(35, 13);
            this.firstWord.TabIndex = 2;
            this.firstWord.Text = "label2";
            this.firstWord.Visible = false;
            // 
            // lastWord
            // 
            this.lastWord.AutoSize = true;
            this.lastWord.Location = new System.Drawing.Point(208, 238);
            this.lastWord.Name = "lastWord";
            this.lastWord.Size = new System.Drawing.Size(35, 13);
            this.lastWord.TabIndex = 3;
            this.lastWord.Text = "label3";
            this.lastWord.Visible = false;
            // 
            // longestWord
            // 
            this.longestWord.AutoSize = true;
            this.longestWord.Location = new System.Drawing.Point(208, 276);
            this.longestWord.Name = "longestWord";
            this.longestWord.Size = new System.Drawing.Size(35, 13);
            this.longestWord.TabIndex = 4;
            this.longestWord.Text = "label4";
            this.longestWord.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Convert Files";
            // 
            // mostVowels
            // 
            this.mostVowels.AutoSize = true;
            this.mostVowels.Location = new System.Drawing.Point(208, 314);
            this.mostVowels.Name = "mostVowels";
            this.mostVowels.Size = new System.Drawing.Size(35, 13);
            this.mostVowels.TabIndex = 6;
            this.mostVowels.Text = "label1";
            this.mostVowels.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input to lowercase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First word alphabetically:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last word alphabetically:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Longest word:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Word with most vowels:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostVowels);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.longestWord);
            this.Controls.Add(this.lastWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.textLower);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textLower;
        private System.Windows.Forms.Label firstWord;
        private System.Windows.Forms.Label lastWord;
        private System.Windows.Forms.Label longestWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mostVowels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}


namespace EThompson_RockPaperScissors
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.winner = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cIcon = new System.Windows.Forms.Label();
            this.dOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cOut = new System.Windows.Forms.Label();
            this.pOut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pIcon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.randomButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.winTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felt Tip Woman", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock, Paper, Scissors!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.winner);
            this.panel2.Location = new System.Drawing.Point(12, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 71);
            this.panel2.TabIndex = 1;
            // 
            // winner
            // 
            this.winner.Font = new System.Drawing.Font("Felt Tip Woman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner.Location = new System.Drawing.Point(3, 6);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(768, 58);
            this.winner.TabIndex = 1;
            this.winner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cIcon);
            this.panel3.Controls.Add(this.dOut);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cOut);
            this.panel3.Controls.Add(this.pOut);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pIcon);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 175);
            this.panel3.TabIndex = 2;
            // 
            // cIcon
            // 
            this.cIcon.Image = global::EThompson_RockPaperScissors.Properties.Resources.justFrame;
            this.cIcon.Location = new System.Drawing.Point(462, 8);
            this.cIcon.Name = "cIcon";
            this.cIcon.Size = new System.Drawing.Size(155, 155);
            this.cIcon.TabIndex = 13;
            // 
            // dOut
            // 
            this.dOut.Font = new System.Drawing.Font("Felt Tip Woman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOut.Location = new System.Drawing.Point(366, 103);
            this.dOut.Name = "dOut";
            this.dOut.Size = new System.Drawing.Size(40, 35);
            this.dOut.TabIndex = 12;
            this.dOut.Text = "75";
            this.dOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Felt Tip Woman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 36);
            this.label8.TabIndex = 11;
            this.label8.Text = "Draws:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cOut
            // 
            this.cOut.Font = new System.Drawing.Font("Felt Tip Woman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOut.Location = new System.Drawing.Point(672, 67);
            this.cOut.Name = "cOut";
            this.cOut.Size = new System.Drawing.Size(67, 60);
            this.cOut.TabIndex = 10;
            this.cOut.Text = "75";
            this.cOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pOut
            // 
            this.pOut.Font = new System.Drawing.Font("Felt Tip Woman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOut.Location = new System.Drawing.Point(18, 67);
            this.pOut.Name = "pOut";
            this.pOut.Size = new System.Drawing.Size(67, 60);
            this.pOut.TabIndex = 9;
            this.pOut.Text = "75";
            this.pOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Felt Tip Woman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Computer:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Felt Tip Woman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "VS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pIcon
            // 
            this.pIcon.Image = global::EThompson_RockPaperScissors.Properties.Resources.justFrame;
            this.pIcon.Location = new System.Drawing.Point(151, 8);
            this.pIcon.Name = "pIcon";
            this.pIcon.Size = new System.Drawing.Size(155, 155);
            this.pIcon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Felt Tip Woman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.randomButton);
            this.panel4.Controls.Add(this.scissorsButton);
            this.panel4.Controls.Add(this.paperButton);
            this.panel4.Controls.Add(this.rockButton);
            this.panel4.Location = new System.Drawing.Point(12, 382);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 163);
            this.panel4.TabIndex = 3;
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.Transparent;
            this.randomButton.FlatAppearance.BorderSize = 0;
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.Image = global::EThompson_RockPaperScissors.Properties.Resources.rpsgroup;
            this.randomButton.Location = new System.Drawing.Point(586, 2);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(155, 155);
            this.randomButton.TabIndex = 3;
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.BackColor = System.Drawing.Color.Transparent;
            this.scissorsButton.FlatAppearance.BorderSize = 0;
            this.scissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scissorsButton.Image = global::EThompson_RockPaperScissors.Properties.Resources.scissors;
            this.scissorsButton.Location = new System.Drawing.Point(401, 2);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(155, 155);
            this.scissorsButton.TabIndex = 2;
            this.scissorsButton.UseVisualStyleBackColor = false;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BackColor = System.Drawing.Color.Transparent;
            this.paperButton.FlatAppearance.BorderSize = 0;
            this.paperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paperButton.Image = global::EThompson_RockPaperScissors.Properties.Resources.paper;
            this.paperButton.Location = new System.Drawing.Point(216, 2);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(155, 155);
            this.paperButton.TabIndex = 1;
            this.paperButton.UseVisualStyleBackColor = false;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.Color.Transparent;
            this.rockButton.FlatAppearance.BorderSize = 0;
            this.rockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rockButton.Image = ((System.Drawing.Image)(resources.GetObject("rockButton.Image")));
            this.rockButton.Location = new System.Drawing.Point(31, 2);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(155, 155);
            this.rockButton.TabIndex = 0;
            this.rockButton.UseVisualStyleBackColor = false;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.exitButton);
            this.panel5.Controls.Add(this.resetButton);
            this.panel5.Location = new System.Drawing.Point(12, 551);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(776, 91);
            this.panel5.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Felt Tip Woman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(402, 25);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(217, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Felt Tip Woman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(156, 25);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(217, 40);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // winTimer
            // 
            this.winTimer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock, Paper, Scissors!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cIcon;
        private System.Windows.Forms.Label dOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cOut;
        private System.Windows.Forms.Label pOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer winTimer;
    }
}


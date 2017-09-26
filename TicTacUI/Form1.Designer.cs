namespace TicTacUI
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

            this.field1 = new TicTacUI.Field();
            this.field2 = new TicTacUI.Field();
            this.field3 = new TicTacUI.Field();
            this.field4 = new TicTacUI.Field();
            this.field5 = new TicTacUI.Field();
            this.field6 = new TicTacUI.Field();
            this.field7 = new TicTacUI.Field();
            this.field8 = new TicTacUI.Field();
            this.field9 = new TicTacUI.Field();


            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resLbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "New game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(238, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Winner:";
            // 
            // resLbl
            // 
            this.resLbl.AutoSize = true;
            this.resLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resLbl.Location = new System.Drawing.Point(289, 523);
            this.resLbl.Name = "resLbl";
            this.resLbl.Size = new System.Drawing.Size(50, 16);
            this.resLbl.TabIndex = 11;
            this.resLbl.Text = "DRAW";
            // 
            // field1
            // 
            this.field1.BackColor = System.Drawing.Color.LightGray;
            this.field1.Id = 1;
            this.field1.Location = new System.Drawing.Point(13, 13);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(150, 150);
            this.field1.TabIndex = 12;
            this.field1.Click += new System.EventHandler(this.mark_Click);
            // 
            // field2
            // 
            this.field2.BackColor = System.Drawing.Color.LightGray;
            this.field2.Id = 2;
            this.field2.Location = new System.Drawing.Point(169, 12);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(150, 150);
            this.field2.TabIndex = 13;
            this.field2.Click += new System.EventHandler(this.mark_Click);
            // 
            // field3
            // 
            this.field3.BackColor = System.Drawing.Color.LightGray;
            this.field3.Id = 3;
            this.field3.Location = new System.Drawing.Point(325, 12);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(150, 150);
            this.field3.TabIndex = 14;
            this.field3.Click += new System.EventHandler(this.mark_Click);
            // 
            // field4
            // 
            this.field4.BackColor = System.Drawing.Color.LightGray;
            this.field4.Id = 4;
            this.field4.Location = new System.Drawing.Point(12, 169);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(150, 150);
            this.field4.TabIndex = 15;
            this.field4.Click += new System.EventHandler(this.mark_Click);
            // 
            // field5
            // 
            this.field5.BackColor = System.Drawing.Color.LightGray;
            this.field5.Id = 5;
            this.field5.Location = new System.Drawing.Point(169, 168);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(150, 150);
            this.field5.TabIndex = 16;
            this.field5.Click += new System.EventHandler(this.mark_Click);
            // 
            // field6
            // 
            this.field6.BackColor = System.Drawing.Color.LightGray;
            this.field6.Id = 6;
            this.field6.Location = new System.Drawing.Point(325, 168);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(150, 150);
            this.field6.TabIndex = 17;
            this.field6.Click += new System.EventHandler(this.mark_Click);
            // 
            // field7
            // 
            this.field7.BackColor = System.Drawing.Color.LightGray;
            this.field7.Id = 7;
            this.field7.Location = new System.Drawing.Point(12, 325);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(150, 150);
            this.field7.TabIndex = 18;
            this.field7.Click += new System.EventHandler(this.mark_Click);
            // 
            // field8
            // 
            this.field8.BackColor = System.Drawing.Color.LightGray;
            this.field8.Id = 8;
            this.field8.Location = new System.Drawing.Point(168, 324);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(150, 150);
            this.field8.TabIndex = 19;
            this.field8.Click += new System.EventHandler(this.mark_Click);
            // 
            // field9
            // 
            this.field9.BackColor = System.Drawing.Color.LightGray;
            this.field9.Id = 9;
            this.field9.Location = new System.Drawing.Point(324, 325);
            this.field9.Name = "field9";
            this.field9.Size = new System.Drawing.Size(150, 150);
            this.field9.TabIndex = 20;
            this.field9.Click += new System.EventHandler(this.mark_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.field9);
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.resLbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tic Tac Gamme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resLbl;
        private Field field1;
        private Field field2;
        private Field field3;
        private Field field4;
        private Field field5;
        private Field field6;
        private Field field7;
        private Field field8;
        private Field field9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


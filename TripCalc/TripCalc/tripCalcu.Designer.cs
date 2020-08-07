namespace TripCalc
{
    partial class tripCalcu
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
            this.distance = new System.Windows.Forms.TextBox();
            this.gallons = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculatedMPG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(169, 51);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(149, 20);
            this.distance.TabIndex = 0;
            // 
            // gallons
            // 
            this.gallons.Location = new System.Drawing.Point(169, 105);
            this.gallons.Name = "gallons";
            this.gallons.Size = new System.Drawing.Size(149, 20);
            this.gallons.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Caclulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Distance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gallons of gas used";
            // 
            // calculatedMPG
            // 
            this.calculatedMPG.Location = new System.Drawing.Point(87, 212);
            this.calculatedMPG.Name = "calculatedMPG";
            this.calculatedMPG.Size = new System.Drawing.Size(136, 20);
            this.calculatedMPG.TabIndex = 5;
            // 
            // tripCalcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.calculatedMPG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gallons);
            this.Controls.Add(this.distance);
            this.Name = "tripCalcu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox gallons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox calculatedMPG;
    }
}


namespace BlackJack
{
    partial class BJForm
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
            this.DrawBnt = new System.Windows.Forms.Button();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawBnt
            // 
            this.DrawBnt.Location = new System.Drawing.Point(88, 137);
            this.DrawBnt.Name = "DrawBnt";
            this.DrawBnt.Size = new System.Drawing.Size(75, 23);
            this.DrawBnt.TabIndex = 2;
            this.DrawBnt.Text = "Draw Cards";
            this.DrawBnt.UseVisualStyleBackColor = true;
            this.DrawBnt.Click += new System.EventHandler(this.DrawBnt_Click);
            // 
            // Card2
            // 
            this.Card2.Image = global::BlackJack.Properties.Resources._202;
            this.Card2.Location = new System.Drawing.Point(141, 33);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(72, 98);
            this.Card2.TabIndex = 1;
            this.Card2.TabStop = false;
            // 
            // Card1
            // 
            this.Card1.Image = global::BlackJack.Properties.Resources._202;
            this.Card1.Location = new System.Drawing.Point(41, 33);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(72, 98);
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            // 
            // BJForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.DrawBnt);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Name = "BJForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.Button DrawBnt;
    }
}


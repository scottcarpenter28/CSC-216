namespace SkiClub
{
    partial class SkiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkiForm));
            this.Gloves = new System.Windows.Forms.CheckBox();
            this.Skis = new System.Windows.Forms.CheckBox();
            this.Goggles = new System.Windows.Forms.CheckBox();
            this.Hat = new System.Windows.Forms.CheckBox();
            this.Earmuffs = new System.Windows.Forms.CheckBox();
            this.Coat = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.chkBxs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.chkBxs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gloves
            // 
            this.Gloves.AutoSize = true;
            this.Gloves.Location = new System.Drawing.Point(34, 23);
            this.Gloves.Name = "Gloves";
            this.Gloves.Size = new System.Drawing.Size(59, 17);
            this.Gloves.TabIndex = 0;
            this.Gloves.Text = "Gloves";
            this.Gloves.UseVisualStyleBackColor = true;
            // 
            // Skis
            // 
            this.Skis.AutoSize = true;
            this.Skis.Location = new System.Drawing.Point(34, 46);
            this.Skis.Name = "Skis";
            this.Skis.Size = new System.Drawing.Size(46, 17);
            this.Skis.TabIndex = 1;
            this.Skis.Text = "Skis";
            this.Skis.UseVisualStyleBackColor = true;
            // 
            // Goggles
            // 
            this.Goggles.AutoSize = true;
            this.Goggles.Location = new System.Drawing.Point(34, 69);
            this.Goggles.Name = "Goggles";
            this.Goggles.Size = new System.Drawing.Size(65, 17);
            this.Goggles.TabIndex = 2;
            this.Goggles.Text = "Goggles";
            this.Goggles.UseVisualStyleBackColor = true;
            // 
            // Hat
            // 
            this.Hat.AutoSize = true;
            this.Hat.Location = new System.Drawing.Point(123, 23);
            this.Hat.Name = "Hat";
            this.Hat.Size = new System.Drawing.Size(43, 17);
            this.Hat.TabIndex = 3;
            this.Hat.Text = "Hat";
            this.Hat.UseVisualStyleBackColor = true;
            // 
            // Earmuffs
            // 
            this.Earmuffs.AutoSize = true;
            this.Earmuffs.Location = new System.Drawing.Point(123, 46);
            this.Earmuffs.Name = "Earmuffs";
            this.Earmuffs.Size = new System.Drawing.Size(67, 17);
            this.Earmuffs.TabIndex = 4;
            this.Earmuffs.Text = "Earmuffs";
            this.Earmuffs.UseVisualStyleBackColor = true;
            // 
            // Coat
            // 
            this.Coat.AutoSize = true;
            this.Coat.Location = new System.Drawing.Point(123, 69);
            this.Coat.Name = "Coat";
            this.Coat.Size = new System.Drawing.Size(48, 17);
            this.Coat.TabIndex = 5;
            this.Coat.Text = "Coat";
            this.Coat.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SkiClub.Properties.Resources.ski_clip_art_ski_black_hi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 102);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ski trip! What do you need?";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(51, 144);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(117, 37);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(79, 188);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 33);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // chkBxs
            // 
            this.chkBxs.Controls.Add(this.Earmuffs);
            this.chkBxs.Controls.Add(this.Gloves);
            this.chkBxs.Controls.Add(this.Skis);
            this.chkBxs.Controls.Add(this.Goggles);
            this.chkBxs.Controls.Add(this.Hat);
            this.chkBxs.Controls.Add(this.Coat);
            this.chkBxs.Location = new System.Drawing.Point(26, 38);
            this.chkBxs.Name = "chkBxs";
            this.chkBxs.Size = new System.Drawing.Size(200, 100);
            this.chkBxs.TabIndex = 10;
            this.chkBxs.TabStop = false;
            // 
            // SkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(422, 233);
            this.Controls.Add(this.chkBxs);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SkiForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.chkBxs.ResumeLayout(false);
            this.chkBxs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Gloves;
        private System.Windows.Forms.CheckBox Skis;
        private System.Windows.Forms.CheckBox Goggles;
        private System.Windows.Forms.CheckBox Hat;
        private System.Windows.Forms.CheckBox Earmuffs;
        private System.Windows.Forms.CheckBox Coat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox chkBxs;
    }
}


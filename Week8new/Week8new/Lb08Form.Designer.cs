namespace Week8new
{
    partial class Lab08
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AgeTextbox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.OutPutlabel = new System.Windows.Forms.Label();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(89, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Lab08";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.AgeTextbox);
            this.InfoGroupBox.Controls.Add(this.AgeLabel);
            this.InfoGroupBox.Controls.Add(this.NameTextbox);
            this.InfoGroupBox.Controls.Add(this.Namelabel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGroupBox.Location = new System.Drawing.Point(13, 44);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(593, 200);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "groupBox1";
            this.InfoGroupBox.Enter += new System.EventHandler(this.InfoGroupBox_Enter);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(19, 34);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(168, 31);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Enter Name";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.Location = new System.Drawing.Point(193, 34);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(381, 38);
            this.NameTextbox.TabIndex = 1;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // AgeTextbox
            // 
            this.AgeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextbox.Location = new System.Drawing.Point(193, 81);
            this.AgeTextbox.Name = "AgeTextbox";
            this.AgeTextbox.Size = new System.Drawing.Size(381, 38);
            this.AgeTextbox.TabIndex = 2;
            this.AgeTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(19, 81);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(143, 31);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Enter Age";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.Aqua;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(485, 390);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(121, 39);
            this.BtnSubmit.TabIndex = 3;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // OutPutlabel
            // 
            this.OutPutlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutlabel.Location = new System.Drawing.Point(22, 390);
            this.OutPutlabel.Name = "OutPutlabel";
            this.OutPutlabel.Size = new System.Drawing.Size(427, 31);
            this.OutPutlabel.TabIndex = 3;
            this.OutPutlabel.Text = "Out Put Label";
            // 
            // Lab08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.OutPutlabel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Lab08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab08";
            this.Load += new System.EventHandler(this.Lab08_Load);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox AgeTextbox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label OutPutlabel;
    }
}


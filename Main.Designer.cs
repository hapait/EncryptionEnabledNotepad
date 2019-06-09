namespace EncryptionEnabledNotepad
{
    partial class Main
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
            this.Button_PersonalEncryption = new System.Windows.Forms.Button();
            this.TextBox_input = new System.Windows.Forms.TextBox();
            this.Label_output = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FileEncryptionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_PersonalEncryption
            // 
            this.Button_PersonalEncryption.Location = new System.Drawing.Point(118, 12);
            this.Button_PersonalEncryption.Name = "Button_PersonalEncryption";
            this.Button_PersonalEncryption.Size = new System.Drawing.Size(137, 23);
            this.Button_PersonalEncryption.TabIndex = 0;
            this.Button_PersonalEncryption.Text = "PersonalEncryption";
            this.Button_PersonalEncryption.UseVisualStyleBackColor = true;
            this.Button_PersonalEncryption.Click += new System.EventHandler(this.Button_PersonalEncryption_Click);
            // 
            // TextBox_input
            // 
            this.TextBox_input.Location = new System.Drawing.Point(12, 12);
            this.TextBox_input.Name = "TextBox_input";
            this.TextBox_input.Size = new System.Drawing.Size(100, 20);
            this.TextBox_input.TabIndex = 1;
            // 
            // Label_output
            // 
            this.Label_output.AutoSize = true;
            this.Label_output.Location = new System.Drawing.Point(261, 17);
            this.Label_output.Name = "Label_output";
            this.Label_output.Size = new System.Drawing.Size(35, 13);
            this.Label_output.TabIndex = 2;
            this.Label_output.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 335);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(421, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(331, 334);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FileEncryptionButton
            // 
            this.FileEncryptionButton.Location = new System.Drawing.Point(422, 36);
            this.FileEncryptionButton.Name = "FileEncryptionButton";
            this.FileEncryptionButton.Size = new System.Drawing.Size(141, 23);
            this.FileEncryptionButton.TabIndex = 5;
            this.FileEncryptionButton.Text = "FileEncryption";
            this.FileEncryptionButton.UseVisualStyleBackColor = true;
            this.FileEncryptionButton.Click += new System.EventHandler(this.FileEncryptionButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 517);
            this.Controls.Add(this.FileEncryptionButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label_output);
            this.Controls.Add(this.TextBox_input);
            this.Controls.Add(this.Button_PersonalEncryption);
            this.Name = "Main";
            this.Text = "CryptoPad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_PersonalEncryption;
        private System.Windows.Forms.TextBox TextBox_input;
        private System.Windows.Forms.Label Label_output;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button FileEncryptionButton;
    }
}


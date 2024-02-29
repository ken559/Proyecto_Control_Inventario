namespace Proyecto_Control_Inventario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginButton = new Button();
            PasswordtextBox = new TextBox();
            UserListBox = new ListBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Bold);
            loginButton.Location = new Point(172, 418);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(198, 69);
            loginButton.TabIndex = 0;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(118, 352);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(328, 23);
            PasswordtextBox.TabIndex = 1;
            // 
            // UserListBox
            // 
            UserListBox.FormattingEnabled = true;
            UserListBox.ItemHeight = 15;
            UserListBox.Location = new Point(118, 267);
            UserListBox.Name = "UserListBox";
            UserListBox.Size = new Size(328, 19);
            UserListBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.log_in;
            pictureBox1.Location = new Point(185, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 20.25F);
            label1.Location = new Point(234, 230);
            label1.Name = "label1";
            label1.Size = new Size(70, 34);
            label1.TabIndex = 4;
            label1.Text = "USER";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 20.25F);
            label2.Location = new Point(199, 315);
            label2.Name = "label2";
            label2.Size = new Size(132, 34);
            label2.TabIndex = 5;
            label2.Text = "PASSWORD";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(524, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(562, 508);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(UserListBox);
            Controls.Add(PasswordtextBox);
            Controls.Add(loginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "LOGIN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox PasswordtextBox;
        private ListBox UserListBox;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}

namespace Log_in_And_Sign_Up_Form
{
    partial class signUpForm
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
            panel1 = new Panel();
            button1 = new Button();
            textBoxCPass = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxCPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(241, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 369);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(73, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 11;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxCPass
            // 
            textBoxCPass.Location = new Point(25, 263);
            textBoxCPass.Name = "textBoxCPass";
            textBoxCPass.Size = new Size(171, 23);
            textBoxCPass.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(26, 239);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 9;
            label4.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(25, 116);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(26, 177);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(25, 201);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(171, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(25, 140);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(171, 23);
            textBoxUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(56, 33);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._710174__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(695, 454);
            Controls.Add(panel1);
            Name = "signUpForm";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private Label label1;
        private Button button1;
        private TextBox textBoxCPass;
        private Label label4;
    }
}
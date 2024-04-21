namespace Log_in_And_Sign_Up_Form
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            label1 = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(59, 42);
            label1.Name = "label1";
            label1.Size = new Size(106, 33);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(25, 140);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(171, 23);
            textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(25, 207);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(171, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(25, 183);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            linkLabel1.ForeColor = Color.Transparent;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.MediumSlateBlue;
            linkLabel1.Location = new Point(137, 292);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(25, 292);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 6;
            label4.Text = "Make an account?";
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(238, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 369);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(68, 250);
            button1.Name = "button1";
            button1.Size = new Size(84, 28);
            button1.TabIndex = 9;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(691, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LogInForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label2;
        private Panel panel1;
        private Button button1;
    }
}

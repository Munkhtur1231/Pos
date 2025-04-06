namespace Pos
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            button_Login = new Button();
            label1 = new Label();
            UserbindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)UserbindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox_Username
            // 
            textBox_Username.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Username.Location = new Point(67, 110);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.PlaceholderText = "Username";
            textBox_Username.Size = new Size(224, 39);
            textBox_Username.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Password.Location = new Point(67, 172);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.PlaceholderText = "Password";
            textBox_Password.Size = new Size(224, 39);
            textBox_Password.TabIndex = 1;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.SteelBlue;
            button_Login.Location = new Point(92, 240);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(168, 42);
            button_Login.TabIndex = 2;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 37);
            label1.Name = "label1";
            label1.Size = new Size(112, 47);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // UserbindingSource
            // 
            UserbindingSource.DataSource = typeof(PosLibrary.User);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 332);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(button_Login);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)UserbindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Button button_Login;
        private Label label1;
        private BindingSource UserbindingSource;
    }
}
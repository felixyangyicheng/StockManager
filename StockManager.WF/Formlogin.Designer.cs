namespace StockManager.WF
{
    partial class Formlogin
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
            this.textBoxEmployeeCode = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.labelEmployeeCode = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmployeeCode
            // 
            this.textBoxEmployeeCode.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmployeeCode.Font = new System.Drawing.Font("Candara Light", 20F);
            this.textBoxEmployeeCode.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmployeeCode.Location = new System.Drawing.Point(374, 113);
            this.textBoxEmployeeCode.Name = "textBoxEmployeeCode";
            this.textBoxEmployeeCode.Size = new System.Drawing.Size(205, 40);
            this.textBoxEmployeeCode.TabIndex = 0;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Candara Light", 20F);
            this.textBoxEmployeeName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmployeeName.Location = new System.Drawing.Point(374, 159);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(205, 40);
            this.textBoxEmployeeName.TabIndex = 1;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassWord.Font = new System.Drawing.Font("Candara Light", 20F);
            this.textBoxPassWord.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxPassWord.Location = new System.Drawing.Point(374, 207);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(205, 40);
            this.textBoxPassWord.TabIndex = 2;
            // 
            // labelEmployeeCode
            // 
            this.labelEmployeeCode.AutoSize = true;
            this.labelEmployeeCode.Font = new System.Drawing.Font("Candara Light", 20F);
            this.labelEmployeeCode.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelEmployeeCode.Location = new System.Drawing.Point(136, 116);
            this.labelEmployeeCode.Name = "labelEmployeeCode";
            this.labelEmployeeCode.Size = new System.Drawing.Size(232, 33);
            this.labelEmployeeCode.TabIndex = 3;
            this.labelEmployeeCode.Text = "Code d\'employee : ";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Candara Light", 20F);
            this.labelEmployeeName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelEmployeeName.Location = new System.Drawing.Point(279, 162);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(89, 33);
            this.labelEmployeeName.TabIndex = 4;
            this.labelEmployeeName.Text = "Nom : ";
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.Font = new System.Drawing.Font("Candara Light", 20F);
            this.labelPassWord.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPassWord.Location = new System.Drawing.Point(181, 210);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(187, 33);
            this.labelPassWord.TabIndex = 5;
            this.labelPassWord.Text = "Mot de passe : ";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxGrade.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(374, 261);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrade.TabIndex = 6;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Candara Light", 20F);
            this.labelGrade.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGrade.Location = new System.Drawing.Point(266, 249);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(102, 33);
            this.labelGrade.TabIndex = 7;
            this.labelGrade.Text = "Grade : ";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Candara Light", 20F);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogin.Location = new System.Drawing.Point(374, 301);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(218, 54);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Se connecter";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMinimize.Location = new System.Drawing.Point(719, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(23, 23);
            this.buttonMinimize.TabIndex = 9;
            this.buttonMinimize.Text = "__";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Location = new System.Drawing.Point(739, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(23, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.labelPassWord);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.labelEmployeeCode);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.textBoxEmployeeCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formlogin";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Formlogin_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmployeeCode;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Label labelEmployeeCode;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
    }
}
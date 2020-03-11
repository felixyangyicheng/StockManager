namespace StockManager.WF
{
    partial class FormManageStaff
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
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfStaff = new System.Windows.Forms.ListBox();
            this.labelStaffID = new System.Windows.Forms.Label();
            this.labelStaffName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelStaffGrade = new System.Windows.Forms.Label();
            this.textBoxStaffID = new System.Windows.Forms.TextBox();
            this.textBoxStaffName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxStaffGrade = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMinimize.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMinimize.Location = new System.Drawing.Point(756, 2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(27, 27);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.Text = "__";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExit.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Location = new System.Drawing.Point(780, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(29, 27);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion des employés";
            // 
            // listOfStaff
            // 
            this.listOfStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listOfStaff.Font = new System.Drawing.Font("Candara Light", 11F);
            this.listOfStaff.FormattingEnabled = true;
            this.listOfStaff.ItemHeight = 18;
            this.listOfStaff.Location = new System.Drawing.Point(70, 84);
            this.listOfStaff.Name = "listOfStaff";
            this.listOfStaff.Size = new System.Drawing.Size(222, 292);
            this.listOfStaff.TabIndex = 3;
            this.listOfStaff.SelectedIndexChanged += new System.EventHandler(this.listOfStaff_SelectedIndexChanged);
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Font = new System.Drawing.Font("Candara", 11F);
            this.labelStaffID.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStaffID.Location = new System.Drawing.Point(380, 99);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(86, 18);
            this.labelStaffID.TabIndex = 4;
            this.labelStaffID.Text = "Employé ID :";
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.Font = new System.Drawing.Font("Candara", 11F);
            this.labelStaffName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStaffName.Location = new System.Drawing.Point(380, 130);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(114, 18);
            this.labelStaffName.TabIndex = 5;
            this.labelStaffName.Text = "Nom d\'employé :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Candara", 11F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPassword.Location = new System.Drawing.Point(380, 161);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 18);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Mot de passe :";
            // 
            // labelStaffGrade
            // 
            this.labelStaffGrade.AutoSize = true;
            this.labelStaffGrade.Font = new System.Drawing.Font("Candara", 11F);
            this.labelStaffGrade.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStaffGrade.Location = new System.Drawing.Point(380, 192);
            this.labelStaffGrade.Name = "labelStaffGrade";
            this.labelStaffGrade.Size = new System.Drawing.Size(52, 18);
            this.labelStaffGrade.TabIndex = 7;
            this.labelStaffGrade.Text = "Grade :";
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxStaffID.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxStaffID.Location = new System.Drawing.Point(512, 96);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.Size = new System.Drawing.Size(151, 25);
            this.textBoxStaffID.TabIndex = 8;
            // 
            // textBoxStaffName
            // 
            this.textBoxStaffName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxStaffName.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxStaffName.Location = new System.Drawing.Point(512, 127);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.Size = new System.Drawing.Size(151, 25);
            this.textBoxStaffName.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxPassword.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxPassword.Location = new System.Drawing.Point(512, 158);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(151, 25);
            this.textBoxPassword.TabIndex = 10;
            // 
            // textBoxStaffGrade
            // 
            this.textBoxStaffGrade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxStaffGrade.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxStaffGrade.Location = new System.Drawing.Point(512, 189);
            this.textBoxStaffGrade.Name = "textBoxStaffGrade";
            this.textBoxStaffGrade.Size = new System.Drawing.Size(151, 25);
            this.textBoxStaffGrade.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDelete.Location = new System.Drawing.Point(370, 315);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(136, 61);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdate.Font = new System.Drawing.Font("Candara", 15F);
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonUpdate.Location = new System.Drawing.Point(512, 315);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(134, 61);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Mettre à jour";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.Font = new System.Drawing.Font("Candara", 15F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAdd.Location = new System.Drawing.Point(652, 315);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 61);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(811, 460);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxStaffGrade);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxStaffName);
            this.Controls.Add(this.textBoxStaffID);
            this.Controls.Add(this.labelStaffGrade);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelStaffName);
            this.Controls.Add(this.labelStaffID);
            this.Controls.Add(this.listOfStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMinimize);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageStaff";
            this.Text = "FormManageStaff";
            this.Load += new System.EventHandler(this.FormManageStaff_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormManageStaff_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOfStaff;
        private System.Windows.Forms.Label labelStaffID;
        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelStaffGrade;
        private System.Windows.Forms.TextBox textBoxStaffID;
        private System.Windows.Forms.TextBox textBoxStaffName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxStaffGrade;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
    }
}
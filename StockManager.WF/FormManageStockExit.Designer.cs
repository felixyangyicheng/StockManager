namespace StockManager.WF
{
    partial class FormManageStockExit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageStockExit));
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelManageStockExit = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelManipulator = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMinimize.Location = new System.Drawing.Point(755, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(23, 23);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.Text = "__";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Location = new System.Drawing.Point(777, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(23, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelManageStockExit
            // 
            this.labelManageStockExit.AutoSize = true;
            this.labelManageStockExit.Font = new System.Drawing.Font("Candara Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageStockExit.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelManageStockExit.Location = new System.Drawing.Point(169, 0);
            this.labelManageStockExit.Name = "labelManageStockExit";
            this.labelManageStockExit.Size = new System.Drawing.Size(457, 49);
            this.labelManageStockExit.TabIndex = 2;
            this.labelManageStockExit.Text = "Gestion de sortie de stock";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(52, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 251);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSell.Font = new System.Drawing.Font("Candara Light", 15F);
            this.buttonSell.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSell.Location = new System.Drawing.Point(436, 191);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(224, 38);
            this.buttonSell.TabIndex = 5;
            this.buttonSell.Text = "Vendre ce porduit";
            this.buttonSell.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Font = new System.Drawing.Font("Candara Light", 15F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(436, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 32);
            this.textBox1.TabIndex = 6;
            // 
            // labelManipulator
            // 
            this.labelManipulator.AutoSize = true;
            this.labelManipulator.Font = new System.Drawing.Font("Candara Light", 15F);
            this.labelManipulator.ForeColor = System.Drawing.SystemColors.Window;
            this.labelManipulator.Location = new System.Drawing.Point(352, 396);
            this.labelManipulator.Name = "labelManipulator";
            this.labelManipulator.Size = new System.Drawing.Size(135, 24);
            this.labelManipulator.TabIndex = 7;
            this.labelManipulator.Text = "Manipulateur : ";
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Font = new System.Drawing.Font("Candara Light", 15F);
            this.labelStaff.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStaff.Location = new System.Drawing.Point(548, 395);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(58, 24);
            this.labelStaff.TabIndex = 8;
            this.labelStaff.Text = "label2";
            // 
            // FormManageStockExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.labelManipulator);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelManageStockExit);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageStockExit";
            this.Text = "FormManageStockExit";
            this.Load += new System.EventHandler(this.FormManageStockExit_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormManageStockExit_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelManageStockExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelManipulator;
        private System.Windows.Forms.Label labelStaff;
    }
}
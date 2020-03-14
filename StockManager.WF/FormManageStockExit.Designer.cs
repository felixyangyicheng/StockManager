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
            this.listOfProduct = new System.Windows.Forms.ListBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelManipulator = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
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
            // listOfProduct
            // 
            this.listOfProduct.FormattingEnabled = true;
            this.listOfProduct.Location = new System.Drawing.Point(52, 95);
            this.listOfProduct.Name = "listOfProduct";
            this.listOfProduct.Size = new System.Drawing.Size(319, 251);
            this.listOfProduct.TabIndex = 3;
            this.listOfProduct.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSell.Font = new System.Drawing.Font("Candara Light", 15F);
            this.buttonSell.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSell.Location = new System.Drawing.Point(436, 244);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(224, 38);
            this.buttonSell.TabIndex = 5;
            this.buttonSell.Text = "Vendre ce porduit";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxProductName.Font = new System.Drawing.Font("Candara Light", 15F);
            this.textBoxProductName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxProductName.Location = new System.Drawing.Point(436, 144);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(224, 32);
            this.textBoxProductName.TabIndex = 6;
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
            // textBoxProductID
            // 
            this.textBoxProductID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxProductID.Font = new System.Drawing.Font("Candara Light", 15F);
            this.textBoxProductID.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxProductID.Location = new System.Drawing.Point(436, 98);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(224, 32);
            this.textBoxProductID.TabIndex = 9;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxQuantity.Font = new System.Drawing.Font("Candara Light", 15F);
            this.textBoxQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxQuantity.Location = new System.Drawing.Point(436, 196);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 32);
            this.textBoxQuantity.TabIndex = 10;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuqntity_TextChanged);
            // 
            // FormManageStockExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.labelManipulator);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.listOfProduct);
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
        private System.Windows.Forms.ListBox listOfProduct;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelManipulator;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxQuantity;
    }
}
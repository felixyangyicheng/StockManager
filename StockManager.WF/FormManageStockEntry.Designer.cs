namespace StockManager.WF
{
    partial class FormManageStockEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageStockEntry));
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelManageStockEntry = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listOfProduct = new System.Windows.Forms.ListBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelManipulator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMinimize.Location = new System.Drawing.Point(753, 0);
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
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Location = new System.Drawing.Point(775, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(23, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelManageStockEntry
            // 
            this.labelManageStockEntry.AutoSize = true;
            this.labelManageStockEntry.Font = new System.Drawing.Font("Candara Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageStockEntry.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelManageStockEntry.Location = new System.Drawing.Point(-3, 0);
            this.labelManageStockEntry.Name = "labelManageStockEntry";
            this.labelManageStockEntry.Size = new System.Drawing.Size(452, 49);
            this.labelManageStockEntry.TabIndex = 2;
            this.labelManageStockEntry.Text = "Gestion d\'entrée de stock";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.Font = new System.Drawing.Font("Candara Light", 15F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAdd.Location = new System.Drawing.Point(475, 300);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(235, 37);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Ajouter une quantité";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listOfProduct
            // 
            this.listOfProduct.FormattingEnabled = true;
            this.listOfProduct.Location = new System.Drawing.Point(44, 52);
            this.listOfProduct.Name = "listOfProduct";
            this.listOfProduct.Size = new System.Drawing.Size(243, 368);
            this.listOfProduct.TabIndex = 4;
            this.listOfProduct.SelectedIndexChanged += new System.EventHandler(this.listOfProduct_SelectedIndexChanged);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxProductName.Font = new System.Drawing.Font("Candara Light", 15F);
            this.textBoxProductName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxProductName.Location = new System.Drawing.Point(512, 154);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(235, 32);
            this.textBoxProductName.TabIndex = 5;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxQuantity.Font = new System.Drawing.Font("Candara Light", 15F);
            this.textBoxQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxQuantity.Location = new System.Drawing.Point(512, 192);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(235, 32);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProductName.Location = new System.Drawing.Point(334, 162);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(115, 18);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "Nom du produit : ";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Candara", 11F);
            this.labelQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.labelQuantity.Location = new System.Drawing.Point(334, 200);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(172, 18);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Changement de quantité : ";
            // 
            // labelManipulator
            // 
            this.labelManipulator.AutoSize = true;
            this.labelManipulator.Font = new System.Drawing.Font("Candara Light", 11F);
            this.labelManipulator.ForeColor = System.Drawing.SystemColors.Window;
            this.labelManipulator.Location = new System.Drawing.Point(572, 414);
            this.labelManipulator.Name = "labelManipulator";
            this.labelManipulator.Size = new System.Drawing.Size(101, 18);
            this.labelManipulator.TabIndex = 9;
            this.labelManipulator.Text = "Manipulateur : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(679, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductID.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProductID.Location = new System.Drawing.Point(334, 124);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(96, 18);
            this.labelProductID.TabIndex = 11;
            this.labelProductID.Text = "ID de Produit :";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxProductID.Font = new System.Drawing.Font("Candara Light", 15F);
            this.textBoxProductID.Location = new System.Drawing.Point(512, 116);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(235, 32);
            this.textBoxProductID.TabIndex = 12;
            // 
            // FormManageStockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelManipulator);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.listOfProduct);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelManageStockEntry);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageStockEntry";
            this.Text = "FormManageStockEntry";
            this.Load += new System.EventHandler(this.FormManageStockEntry_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormManageStockEntry_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelManageStockEntry;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listOfProduct;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelManipulator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.TextBox textBoxProductID;
    }
}
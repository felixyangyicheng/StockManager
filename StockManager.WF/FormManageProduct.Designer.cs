namespace StockManager.WF
{
    partial class FormManageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageProduct));
            this.labelManageProduct = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listOfProduct = new System.Windows.Forms.ListBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductReference = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductReference = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxProductCategory = new System.Windows.Forms.TextBox();
            this.labelProductCategory = new System.Windows.Forms.Label();
            this.textBoxProductCategoryID = new System.Windows.Forms.TextBox();
            this.labelProductCategoryID = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonManageEntry = new System.Windows.Forms.Button();
            this.listOfCategory = new System.Windows.Forms.ListBox();
            this.textBoxCategory2 = new System.Windows.Forms.TextBox();
            this.labelCategoryID2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelManageProduct
            // 
            this.labelManageProduct.AutoSize = true;
            this.labelManageProduct.Font = new System.Drawing.Font("Candara Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageProduct.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelManageProduct.Location = new System.Drawing.Point(313, 45);
            this.labelManageProduct.Name = "labelManageProduct";
            this.labelManageProduct.Size = new System.Drawing.Size(367, 49);
            this.labelManageProduct.TabIndex = 0;
            this.labelManageProduct.Text = "Gestion des produits";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMinimize.Location = new System.Drawing.Point(755, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(23, 23);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "__";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(776, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(23, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listOfProduct
            // 
            this.listOfProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listOfProduct.Font = new System.Drawing.Font("Candara", 11F);
            this.listOfProduct.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listOfProduct.FormattingEnabled = true;
            this.listOfProduct.ItemHeight = 18;
            this.listOfProduct.Location = new System.Drawing.Point(22, 16);
            this.listOfProduct.Name = "listOfProduct";
            this.listOfProduct.Size = new System.Drawing.Size(237, 346);
            this.listOfProduct.TabIndex = 3;
            this.listOfProduct.SelectedIndexChanged += new System.EventHandler(this.listOfProduct_SelectedIndexChanged);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxProductName.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxProductName.Location = new System.Drawing.Point(447, 168);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(257, 25);
            this.textBoxProductName.TabIndex = 4;
            // 
            // textBoxProductReference
            // 
            this.textBoxProductReference.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxProductReference.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxProductReference.Location = new System.Drawing.Point(447, 194);
            this.textBoxProductReference.Name = "textBoxProductReference";
            this.textBoxProductReference.Size = new System.Drawing.Size(257, 25);
            this.textBoxProductReference.TabIndex = 5;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxProductPrice.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxProductPrice.Location = new System.Drawing.Point(447, 220);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(257, 25);
            this.textBoxProductPrice.TabIndex = 6;
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxProductDescription.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxProductDescription.Location = new System.Drawing.Point(447, 246);
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(257, 25);
            this.textBoxProductDescription.TabIndex = 7;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductName.Location = new System.Drawing.Point(303, 171);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(112, 18);
            this.labelProductName.TabIndex = 8;
            this.labelProductName.Text = "Nom de produit :";
            // 
            // labelProductReference
            // 
            this.labelProductReference.AutoSize = true;
            this.labelProductReference.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductReference.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductReference.Location = new System.Drawing.Point(303, 197);
            this.labelProductReference.Name = "labelProductReference";
            this.labelProductReference.Size = new System.Drawing.Size(81, 18);
            this.labelProductReference.TabIndex = 9;
            this.labelProductReference.Text = "Référence :";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductPrice.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductPrice.Location = new System.Drawing.Point(303, 223);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(46, 18);
            this.labelProductPrice.TabIndex = 10;
            this.labelProductPrice.Text = "Price :";
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.AutoSize = true;
            this.labelProductDescription.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductDescription.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductDescription.Location = new System.Drawing.Point(303, 249);
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(86, 18);
            this.labelProductDescription.TabIndex = 11;
            this.labelProductDescription.Text = "Description :";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductID.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductID.Location = new System.Drawing.Point(303, 148);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(77, 18);
            this.labelProductID.TabIndex = 12;
            this.labelProductID.Text = "ID Produit :";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxProductID.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxProductID.Location = new System.Drawing.Point(447, 142);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(257, 25);
            this.textBoxProductID.TabIndex = 13;
            // 
            // textBoxProductCategory
            // 
            this.textBoxProductCategory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxProductCategory.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxProductCategory.Location = new System.Drawing.Point(447, 298);
            this.textBoxProductCategory.Name = "textBoxProductCategory";
            this.textBoxProductCategory.Size = new System.Drawing.Size(257, 25);
            this.textBoxProductCategory.TabIndex = 14;
            // 
            // labelProductCategory
            // 
            this.labelProductCategory.AutoSize = true;
            this.labelProductCategory.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductCategory.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductCategory.Location = new System.Drawing.Point(303, 301);
            this.labelProductCategory.Name = "labelProductCategory";
            this.labelProductCategory.Size = new System.Drawing.Size(138, 18);
            this.labelProductCategory.TabIndex = 15;
            this.labelProductCategory.Text = "Catégory de produit :";
            // 
            // textBoxProductCategoryID
            // 
            this.textBoxProductCategoryID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxProductCategoryID.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxProductCategoryID.Location = new System.Drawing.Point(447, 272);
            this.textBoxProductCategoryID.Name = "textBoxProductCategoryID";
            this.textBoxProductCategoryID.Size = new System.Drawing.Size(257, 25);
            this.textBoxProductCategoryID.TabIndex = 16;
            // 
            // labelProductCategoryID
            // 
            this.labelProductCategoryID.AutoSize = true;
            this.labelProductCategoryID.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductCategoryID.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductCategoryID.Location = new System.Drawing.Point(303, 275);
            this.labelProductCategoryID.Name = "labelProductCategoryID";
            this.labelProductCategoryID.Size = new System.Drawing.Size(92, 18);
            this.labelProductCategoryID.TabIndex = 17;
            this.labelProductCategoryID.Text = "Catégorie ID :";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdate.Font = new System.Drawing.Font("Candara", 11F);
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonUpdate.Location = new System.Drawing.Point(671, 368);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(107, 44);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Mettre à jour";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Font = new System.Drawing.Font("Candara", 11F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDelete.Location = new System.Drawing.Point(41, 368);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 44);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Suppprimer";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.Font = new System.Drawing.Font("Candara", 11F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAdd.Location = new System.Drawing.Point(551, 368);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 44);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonManageEntry
            // 
            this.buttonManageEntry.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonManageEntry.Font = new System.Drawing.Font("Candara", 11F);
            this.buttonManageEntry.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonManageEntry.Location = new System.Drawing.Point(306, 368);
            this.buttonManageEntry.Name = "buttonManageEntry";
            this.buttonManageEntry.Size = new System.Drawing.Size(195, 44);
            this.buttonManageEntry.TabIndex = 21;
            this.buttonManageEntry.Text = "Gérer l\'entrée du produit";
            this.buttonManageEntry.UseVisualStyleBackColor = false;
            this.buttonManageEntry.Click += new System.EventHandler(this.buttonManageEntry_Click);
            // 
            // listOfCategory
            // 
            this.listOfCategory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listOfCategory.Font = new System.Drawing.Font("Candara", 11F);
            this.listOfCategory.FormattingEnabled = true;
            this.listOfCategory.ItemHeight = 18;
            this.listOfCategory.Location = new System.Drawing.Point(22, 469);
            this.listOfCategory.Name = "listOfCategory";
            this.listOfCategory.Size = new System.Drawing.Size(247, 94);
            this.listOfCategory.TabIndex = 23;
            this.listOfCategory.SelectedIndexChanged += new System.EventHandler(this.listOfCategory_SelectedIndexChanged);
            // 
            // textBoxCategory2
            // 
            this.textBoxCategory2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxCategory2.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxCategory2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCategory2.Location = new System.Drawing.Point(447, 526);
            this.textBoxCategory2.Name = "textBoxCategory2";
            this.textBoxCategory2.Size = new System.Drawing.Size(257, 25);
            this.textBoxCategory2.TabIndex = 24;
            // 
            // labelCategoryID2
            // 
            this.labelCategoryID2.AutoSize = true;
            this.labelCategoryID2.Font = new System.Drawing.Font("Candara", 11F);
            this.labelCategoryID2.ForeColor = System.Drawing.SystemColors.Window;
            this.labelCategoryID2.Location = new System.Drawing.Point(303, 529);
            this.labelCategoryID2.Name = "labelCategoryID2";
            this.labelCategoryID2.Size = new System.Drawing.Size(92, 18);
            this.labelCategoryID2.TabIndex = 25;
            this.labelCategoryID2.Text = "Catégorie ID :";
            this.labelCategoryID2.Click += new System.EventHandler(this.labelCategoryID2_Click);
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.labelCategoryID2);
            this.Controls.Add(this.textBoxCategory2);
            this.Controls.Add(this.listOfCategory);
            this.Controls.Add(this.buttonManageEntry);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelProductCategoryID);
            this.Controls.Add(this.textBoxProductCategoryID);
            this.Controls.Add(this.labelProductCategory);
            this.Controls.Add(this.textBoxProductCategory);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelProductDescription);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.labelProductReference);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxProductDescription);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.textBoxProductReference);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.listOfProduct);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.labelManageProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageProduct";
            this.Text = "FormManageProduct";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormManageProduct_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageProduct;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listOfProduct;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductReference;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductReference;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductDescription;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxProductCategory;
        private System.Windows.Forms.Label labelProductCategory;
        private System.Windows.Forms.TextBox textBoxProductCategoryID;
        private System.Windows.Forms.Label labelProductCategoryID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonManageEntry;
        private System.Windows.Forms.ListBox listOfCategory;
        private System.Windows.Forms.TextBox textBoxCategory2;
        private System.Windows.Forms.Label labelCategoryID2;
    }
}
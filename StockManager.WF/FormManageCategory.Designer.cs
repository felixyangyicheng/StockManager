namespace StockManager.WF
{
    partial class FormManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageCategory));
            this.labelManageCategory = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.ListOfCategory = new System.Windows.Forms.ListBox();
            this.ListOfProduct = new System.Windows.Forms.ListBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryID = new System.Windows.Forms.TextBox();
            this.labelListCategory = new System.Windows.Forms.Label();
            this.labelCategotyLabel = new System.Windows.Forms.Label();
            this.labelCategoryID = new System.Windows.Forms.Label();
            this.labelProductList = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonDelectCategory = new System.Windows.Forms.Button();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageCategory
            // 
            this.labelManageCategory.AutoSize = true;
            this.labelManageCategory.Font = new System.Drawing.Font("Candara Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageCategory.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelManageCategory.Location = new System.Drawing.Point(132, 0);
            this.labelManageCategory.Name = "labelManageCategory";
            this.labelManageCategory.Size = new System.Drawing.Size(586, 49);
            this.labelManageCategory.TabIndex = 0;
            this.labelManageCategory.Text = "Gestion des catégories de produit";
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
            this.buttonExit.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Location = new System.Drawing.Point(777, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(23, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ListOfCategory
            // 
            this.ListOfCategory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ListOfCategory.Font = new System.Drawing.Font("Candara", 11F);
            this.ListOfCategory.FormattingEnabled = true;
            this.ListOfCategory.ItemHeight = 18;
            this.ListOfCategory.Location = new System.Drawing.Point(28, 83);
            this.ListOfCategory.Name = "ListOfCategory";
            this.ListOfCategory.Size = new System.Drawing.Size(130, 274);
            this.ListOfCategory.TabIndex = 3;
            this.ListOfCategory.SelectedIndexChanged += new System.EventHandler(this.ListOfCategory_SelectedIndexChanged);
            // 
            // ListOfProduct
            // 
            this.ListOfProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ListOfProduct.Font = new System.Drawing.Font("Candara", 11F);
            this.ListOfProduct.FormattingEnabled = true;
            this.ListOfProduct.ItemHeight = 18;
            this.ListOfProduct.Location = new System.Drawing.Point(520, 83);
            this.ListOfProduct.Name = "ListOfProduct";
            this.ListOfProduct.Size = new System.Drawing.Size(223, 274);
            this.ListOfProduct.TabIndex = 4;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxCategoryName.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxCategoryName.Location = new System.Drawing.Point(178, 83);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(317, 25);
            this.textBoxCategoryName.TabIndex = 5;
            // 
            // textBoxCategoryID
            // 
            this.textBoxCategoryID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxCategoryID.Font = new System.Drawing.Font("Candara", 11F);
            this.textBoxCategoryID.Location = new System.Drawing.Point(178, 138);
            this.textBoxCategoryID.Name = "textBoxCategoryID";
            this.textBoxCategoryID.Size = new System.Drawing.Size(317, 25);
            this.textBoxCategoryID.TabIndex = 6;
            // 
            // labelListCategory
            // 
            this.labelListCategory.AutoSize = true;
            this.labelListCategory.Font = new System.Drawing.Font("Candara", 11F);
            this.labelListCategory.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelListCategory.Location = new System.Drawing.Point(28, 62);
            this.labelListCategory.Name = "labelListCategory";
            this.labelListCategory.Size = new System.Drawing.Size(130, 18);
            this.labelListCategory.TabIndex = 7;
            this.labelListCategory.Text = "Liste des catégories";
            // 
            // labelCategotyLabel
            // 
            this.labelCategotyLabel.AutoSize = true;
            this.labelCategotyLabel.Font = new System.Drawing.Font("Candara", 11F);
            this.labelCategotyLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCategotyLabel.Location = new System.Drawing.Point(175, 62);
            this.labelCategotyLabel.Name = "labelCategotyLabel";
            this.labelCategotyLabel.Size = new System.Drawing.Size(119, 18);
            this.labelCategotyLabel.TabIndex = 8;
            this.labelCategotyLabel.Text = "Nom de catégorie";
            // 
            // labelCategoryID
            // 
            this.labelCategoryID.AutoSize = true;
            this.labelCategoryID.Font = new System.Drawing.Font("Candara", 11F);
            this.labelCategoryID.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCategoryID.Location = new System.Drawing.Point(175, 117);
            this.labelCategoryID.Name = "labelCategoryID";
            this.labelCategoryID.Size = new System.Drawing.Size(153, 18);
            this.labelCategoryID.TabIndex = 9;
            this.labelCategoryID.Text = "Identifiant de catégorie";
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Font = new System.Drawing.Font("Candara", 11F);
            this.labelProductList.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProductList.Location = new System.Drawing.Point(517, 62);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(187, 18);
            this.labelProductList.TabIndex = 10;
            this.labelProductList.Text = "Liste des produits concernés ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddCategory.Font = new System.Drawing.Font("Candara", 11F);
            this.buttonAddCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAddCategory.Location = new System.Drawing.Point(274, 184);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(106, 32);
            this.buttonAddCategory.TabIndex = 12;
            this.buttonAddCategory.Text = "Ajouter";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonDelectCategory
            // 
            this.buttonDelectCategory.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelectCategory.Font = new System.Drawing.Font("Candara", 11F);
            this.buttonDelectCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDelectCategory.Location = new System.Drawing.Point(31, 363);
            this.buttonDelectCategory.Name = "buttonDelectCategory";
            this.buttonDelectCategory.Size = new System.Drawing.Size(106, 32);
            this.buttonDelectCategory.TabIndex = 13;
            this.buttonDelectCategory.Text = "Supprimer";
            this.buttonDelectCategory.UseVisualStyleBackColor = false;
            this.buttonDelectCategory.Click += new System.EventHandler(this.buttonDelectCategory_Click);
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdateCategory.Font = new System.Drawing.Font("Candara", 11F);
            this.buttonUpdateCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonUpdateCategory.Location = new System.Drawing.Point(386, 184);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(109, 32);
            this.buttonUpdateCategory.TabIndex = 14;
            this.buttonUpdateCategory.Text = "Mettre à jour";
            this.buttonUpdateCategory.UseVisualStyleBackColor = false;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // FormManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateCategory);
            this.Controls.Add(this.buttonDelectCategory);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.labelCategoryID);
            this.Controls.Add(this.labelCategotyLabel);
            this.Controls.Add(this.labelListCategory);
            this.Controls.Add(this.textBoxCategoryID);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.ListOfProduct);
            this.Controls.Add(this.ListOfCategory);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.labelManageCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageCategory";
            this.Text = "GestionCategory";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormManageCategory_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageCategory;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox ListOfCategory;
        private System.Windows.Forms.ListBox ListOfProduct;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryID;
        private System.Windows.Forms.Label labelListCategory;
        private System.Windows.Forms.Label labelCategotyLabel;
        private System.Windows.Forms.Label labelCategoryID;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonDelectCategory;
        private System.Windows.Forms.Button buttonUpdateCategory;
    }
}
namespace StockManager.WF
{
    partial class FormResearchProduct
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
            this.labelResearchProduct = new System.Windows.Forms.Label();
            this.textBoxResearch = new System.Windows.Forms.TextBox();
            this.listBoxFound = new System.Windows.Forms.ListBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMinimize.Location = new System.Drawing.Point(752, 1);
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
            this.buttonExit.Location = new System.Drawing.Point(775, 1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(23, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelResearchProduct
            // 
            this.labelResearchProduct.AutoSize = true;
            this.labelResearchProduct.Font = new System.Drawing.Font("Candara Light", 30F);
            this.labelResearchProduct.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelResearchProduct.Location = new System.Drawing.Point(26, 1);
            this.labelResearchProduct.Name = "labelResearchProduct";
            this.labelResearchProduct.Size = new System.Drawing.Size(396, 49);
            this.labelResearchProduct.TabIndex = 2;
            this.labelResearchProduct.Text = "Rechercher un produit";
            // 
            // textBoxResearch
            // 
            this.textBoxResearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxResearch.Font = new System.Drawing.Font("Candara Light", 20F);
            this.textBoxResearch.Location = new System.Drawing.Point(109, 64);
            this.textBoxResearch.Name = "textBoxResearch";
            this.textBoxResearch.Size = new System.Drawing.Size(370, 40);
            this.textBoxResearch.TabIndex = 3;
            // 
            // listBoxFound
            // 
            this.listBoxFound.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxFound.Font = new System.Drawing.Font("Candara", 10F);
            this.listBoxFound.FormattingEnabled = true;
            this.listBoxFound.ItemHeight = 15;
            this.listBoxFound.Location = new System.Drawing.Point(109, 110);
            this.listBoxFound.Name = "listBoxFound";
            this.listBoxFound.Size = new System.Drawing.Size(546, 229);
            this.listBoxFound.TabIndex = 4;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRechercher.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonRechercher.FlatAppearance.BorderSize = 3;
            this.buttonRechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRechercher.Font = new System.Drawing.Font("Candara Light", 20F);
            this.buttonRechercher.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRechercher.Location = new System.Drawing.Point(485, 63);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(170, 41);
            this.buttonRechercher.TabIndex = 5;
            this.buttonRechercher.Text = "Chercher";
            this.buttonRechercher.UseVisualStyleBackColor = false;
            // 
            // FormResearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.listBoxFound);
            this.Controls.Add(this.textBoxResearch);
            this.Controls.Add(this.labelResearchProduct);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResearchProduct";
            this.Text = "FormResearchProduct";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormResearchProduct_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelResearchProduct;
        private System.Windows.Forms.TextBox textBoxResearch;
        private System.Windows.Forms.ListBox listBoxFound;
        private System.Windows.Forms.Button buttonRechercher;
    }
}
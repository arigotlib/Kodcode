namespace Shabes_Gast
{
    partial class Form2
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
            this.dgvAllGuestsChoice = new System.Windows.Forms.DataGridView();
            this.btnGoRight = new System.Windows.Forms.Button();
            this.btnGoLeft = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuestsChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllGuestsChoice
            // 
            this.dgvAllGuestsChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllGuestsChoice.Location = new System.Drawing.Point(89, 66);
            this.dgvAllGuestsChoice.Name = "dgvAllGuestsChoice";
            this.dgvAllGuestsChoice.RowHeadersWidth = 51;
            this.dgvAllGuestsChoice.RowTemplate.Height = 24;
            this.dgvAllGuestsChoice.Size = new System.Drawing.Size(924, 459);
            this.dgvAllGuestsChoice.TabIndex = 0;
            this.dgvAllGuestsChoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllGuestsChoice_CellContentClick);
            // 
            // btnGoRight
            // 
            this.btnGoRight.Location = new System.Drawing.Point(818, 531);
            this.btnGoRight.Name = "btnGoRight";
            this.btnGoRight.Size = new System.Drawing.Size(195, 53);
            this.btnGoRight.TabIndex = 1;
            this.btnGoRight.Text = ">>>>";
            this.btnGoRight.UseVisualStyleBackColor = true;
            this.btnGoRight.Click += new System.EventHandler(this.btnGoRight_Click);
            // 
            // btnGoLeft
            // 
            this.btnGoLeft.Location = new System.Drawing.Point(89, 531);
            this.btnGoLeft.Name = "btnGoLeft";
            this.btnGoLeft.Size = new System.Drawing.Size(194, 53);
            this.btnGoLeft.TabIndex = 2;
            this.btnGoLeft.Text = "<<<<";
            this.btnGoLeft.UseVisualStyleBackColor = true;
            this.btnGoLeft.Click += new System.EventHandler(this.btnGoLeft_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(509, 47);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(44, 16);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 589);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnGoLeft);
            this.Controls.Add(this.btnGoRight);
            this.Controls.Add(this.dgvAllGuestsChoice);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuestsChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllGuestsChoice;
        private System.Windows.Forms.Button btnGoRight;
        private System.Windows.Forms.Button btnGoLeft;
        private System.Windows.Forms.Label lblCategory;
    }
}
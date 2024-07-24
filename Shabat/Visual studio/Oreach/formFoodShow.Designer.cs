namespace Oreach
{
    partial class formFoodShow
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
            this.dgvMyChoice = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGoRight = new System.Windows.Forms.Button();
            this.btnGoLeft = new System.Windows.Forms.Button();
            this.lblAllGuestsChoice = new System.Windows.Forms.Label();
            this.lblMyChoice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuestsChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllGuestsChoice
            // 
            this.dgvAllGuestsChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllGuestsChoice.Location = new System.Drawing.Point(257, 62);
            this.dgvAllGuestsChoice.Name = "dgvAllGuestsChoice";
            this.dgvAllGuestsChoice.RowHeadersWidth = 51;
            this.dgvAllGuestsChoice.RowTemplate.Height = 24;
            this.dgvAllGuestsChoice.Size = new System.Drawing.Size(653, 210);
            this.dgvAllGuestsChoice.TabIndex = 0;
            // 
            // dgvMyChoice
            // 
            this.dgvMyChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyChoice.Location = new System.Drawing.Point(257, 458);
            this.dgvMyChoice.Name = "dgvMyChoice";
            this.dgvMyChoice.RowHeadersWidth = 51;
            this.dgvMyChoice.RowTemplate.Height = 24;
            this.dgvMyChoice.Size = new System.Drawing.Size(653, 205);
            this.dgvMyChoice.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(553, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(44, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "הוספת בחירה";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "אישור";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGoRight
            // 
            this.btnGoRight.Location = new System.Drawing.Point(834, 689);
            this.btnGoRight.Name = "btnGoRight";
            this.btnGoRight.Size = new System.Drawing.Size(75, 23);
            this.btnGoRight.TabIndex = 6;
            this.btnGoRight.Text = ">>";
            this.btnGoRight.UseVisualStyleBackColor = true;
            // 
            // btnGoLeft
            // 
            this.btnGoLeft.Location = new System.Drawing.Point(257, 689);
            this.btnGoLeft.Name = "btnGoLeft";
            this.btnGoLeft.Size = new System.Drawing.Size(75, 23);
            this.btnGoLeft.TabIndex = 7;
            this.btnGoLeft.Text = "<<";
            this.btnGoLeft.UseVisualStyleBackColor = true;
            // 
            // lblAllGuestsChoice
            // 
            this.lblAllGuestsChoice.AutoSize = true;
            this.lblAllGuestsChoice.Location = new System.Drawing.Point(898, 40);
            this.lblAllGuestsChoice.Name = "lblAllGuestsChoice";
            this.lblAllGuestsChoice.Size = new System.Drawing.Size(141, 16);
            this.lblAllGuestsChoice.TabIndex = 8;
            this.lblAllGuestsChoice.Text = "הבחירה של כל האורחים";
            // 
            // lblMyChoice
            // 
            this.lblMyChoice.AutoSize = true;
            this.lblMyChoice.Location = new System.Drawing.Point(901, 436);
            this.lblMyChoice.Name = "lblMyChoice";
            this.lblMyChoice.Size = new System.Drawing.Size(76, 16);
            this.lblMyChoice.TabIndex = 9;
            this.lblMyChoice.Text = "הבחירה שלי";
            // 
            // formFoodShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 724);
            this.Controls.Add(this.lblMyChoice);
            this.Controls.Add(this.lblAllGuestsChoice);
            this.Controls.Add(this.btnGoLeft);
            this.Controls.Add(this.btnGoRight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dgvMyChoice);
            this.Controls.Add(this.dgvAllGuestsChoice);
            this.Name = "formFoodShow";
            this.Text = "formFoodShow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuestsChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllGuestsChoice;
        private System.Windows.Forms.DataGridView dgvMyChoice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGoRight;
        private System.Windows.Forms.Button btnGoLeft;
        private System.Windows.Forms.Label lblAllGuestsChoice;
        private System.Windows.Forms.Label lblMyChoice;
    }
}
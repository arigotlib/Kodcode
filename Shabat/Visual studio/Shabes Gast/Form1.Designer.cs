namespace Shabes_Gast
{
    partial class Form1
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(723, 137);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(193, 68);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "הוסף";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(257, 137);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(193, 68);
            this.btn.TabIndex = 1;
            this.btn.Text = "מחיקה";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(445, 52);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(282, 22);
            this.txtCategory.TabIndex = 2;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "הכנס קטגריות";
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 16;
            this.listBoxCategory.Location = new System.Drawing.Point(445, 270);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(282, 292);
            this.listBoxCategory.TabIndex = 4;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            this.listBoxCategory.DoubleClick += new System.EventHandler(this.listBoxCategory_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 97);
            this.button1.TabIndex = 5;
            this.button1.Text = "הסתכל בהזמנה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 699);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnAddCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Button button1;
    }
}


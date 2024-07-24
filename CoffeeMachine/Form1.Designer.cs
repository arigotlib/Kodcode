namespace CoffeeMachine
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuger = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblMillk = new System.Windows.Forms.Label();
            this.lblCocoa = new System.Windows.Forms.Label();
            this.lbkPrice = new System.Windows.Forms.Label();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.cmbSuger = new System.Windows.Forms.ComboBox();
            this.cmbCoffee = new System.Windows.Forms.ComboBox();
            this.cmbMillk = new System.Windows.Forms.ComboBox();
            this.cmbCocoa = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvAllDrinks = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.DrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1087, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "שם השתיה";
            // 
            // lblSuger
            // 
            this.lblSuger.AutoSize = true;
            this.lblSuger.Location = new System.Drawing.Point(1201, 65);
            this.lblSuger.Name = "lblSuger";
            this.lblSuger.Size = new System.Drawing.Size(34, 16);
            this.lblSuger.TabIndex = 1;
            this.lblSuger.Text = "סוכר";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(1054, 65);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(29, 16);
            this.lblCoffee.TabIndex = 3;
            this.lblCoffee.Text = "קפה";
            // 
            // lblMillk
            // 
            this.lblMillk.AutoSize = true;
            this.lblMillk.Location = new System.Drawing.Point(894, 65);
            this.lblMillk.Name = "lblMillk";
            this.lblMillk.Size = new System.Drawing.Size(31, 16);
            this.lblMillk.TabIndex = 5;
            this.lblMillk.Text = "חלב";
            // 
            // lblCocoa
            // 
            this.lblCocoa.AutoSize = true;
            this.lblCocoa.Location = new System.Drawing.Point(758, 65);
            this.lblCocoa.Name = "lblCocoa";
            this.lblCocoa.Size = new System.Drawing.Size(34, 16);
            this.lblCocoa.TabIndex = 7;
            this.lblCocoa.Text = "קקאו";
            // 
            // lbkPrice
            // 
            this.lbkPrice.AutoSize = true;
            this.lbkPrice.Location = new System.Drawing.Point(595, 65);
            this.lbkPrice.Name = "lbkPrice";
            this.lbkPrice.Size = new System.Drawing.Size(35, 16);
            this.lbkPrice.TabIndex = 9;
            this.lbkPrice.Text = "מחיר";
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(852, 9);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(229, 22);
            this.txtDrinkName.TabIndex = 10;
            this.txtDrinkName.TextChanged += new System.EventHandler(this.txtDrinkName_TextChanged);
            // 
            // cmbSuger
            // 
            this.cmbSuger.FormattingEnabled = true;
            this.cmbSuger.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0"});
            this.cmbSuger.Location = new System.Drawing.Point(1174, 105);
            this.cmbSuger.Name = "cmbSuger";
            this.cmbSuger.Size = new System.Drawing.Size(71, 24);
            this.cmbSuger.TabIndex = 11;
            this.cmbSuger.Text = "1.0";
            // 
            // cmbCoffee
            // 
            this.cmbCoffee.FormattingEnabled = true;
            this.cmbCoffee.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0"});
            this.cmbCoffee.Location = new System.Drawing.Point(1029, 105);
            this.cmbCoffee.Name = "cmbCoffee";
            this.cmbCoffee.Size = new System.Drawing.Size(69, 24);
            this.cmbCoffee.TabIndex = 12;
            this.cmbCoffee.Text = "1.0";
            // 
            // cmbMillk
            // 
            this.cmbMillk.FormattingEnabled = true;
            this.cmbMillk.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0"});
            this.cmbMillk.Location = new System.Drawing.Point(875, 105);
            this.cmbMillk.Name = "cmbMillk";
            this.cmbMillk.Size = new System.Drawing.Size(86, 24);
            this.cmbMillk.TabIndex = 13;
            this.cmbMillk.Text = "1.0";
            // 
            // cmbCocoa
            // 
            this.cmbCocoa.FormattingEnabled = true;
            this.cmbCocoa.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0"});
            this.cmbCocoa.Location = new System.Drawing.Point(722, 105);
            this.cmbCocoa.Name = "cmbCocoa";
            this.cmbCocoa.Size = new System.Drawing.Size(80, 24);
            this.cmbCocoa.TabIndex = 15;
            this.cmbCocoa.Text = "1.0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 19);
            this.button1.TabIndex = 18;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 21);
            this.button2.TabIndex = 19;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvAllDrinks
            // 
            this.dgvAllDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDrinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrinkName,
            this.suger,
            this.coffee,
            this.milk,
            this.cocoa,
            this.price});
            this.dgvAllDrinks.Location = new System.Drawing.Point(12, 152);
            this.dgvAllDrinks.Name = "dgvAllDrinks";
            this.dgvAllDrinks.RowHeadersWidth = 51;
            this.dgvAllDrinks.RowTemplate.Height = 24;
            this.dgvAllDrinks.Size = new System.Drawing.Size(1203, 289);
            this.dgvAllDrinks.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 40);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(225, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 40);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 39);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(585, 105);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(73, 22);
            this.txtPrice.TabIndex = 25;
            this.txtPrice.Text = "4.0";
            // 
            // DrinkName
            // 
            this.DrinkName.HeaderText = "שם משקה";
            this.DrinkName.MinimumWidth = 6;
            this.DrinkName.Name = "DrinkName";
            this.DrinkName.Width = 125;
            // 
            // suger
            // 
            this.suger.HeaderText = "סוכר";
            this.suger.MinimumWidth = 6;
            this.suger.Name = "suger";
            this.suger.Width = 125;
            // 
            // coffee
            // 
            this.coffee.HeaderText = "קפה";
            this.coffee.MinimumWidth = 6;
            this.coffee.Name = "coffee";
            this.coffee.Width = 125;
            // 
            // milk
            // 
            this.milk.HeaderText = "חלב";
            this.milk.MinimumWidth = 6;
            this.milk.Name = "milk";
            this.milk.Width = 125;
            // 
            // cocoa
            // 
            this.cocoa.HeaderText = "קקאו";
            this.cocoa.MinimumWidth = 6;
            this.cocoa.Name = "cocoa";
            this.cocoa.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "מחיר";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 558);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAllDrinks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCocoa);
            this.Controls.Add(this.cmbMillk);
            this.Controls.Add(this.cmbCoffee);
            this.Controls.Add(this.cmbSuger);
            this.Controls.Add(this.txtDrinkName);
            this.Controls.Add(this.lbkPrice);
            this.Controls.Add(this.lblCocoa);
            this.Controls.Add(this.lblMillk);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblSuger);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuger;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblMillk;
        private System.Windows.Forms.Label lblCocoa;
        private System.Windows.Forms.Label lbkPrice;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.ComboBox cmbSuger;
        private System.Windows.Forms.ComboBox cmbCoffee;
        private System.Windows.Forms.ComboBox cmbMillk;
        private System.Windows.Forms.ComboBox cmbCocoa;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvAllDrinks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrinkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn suger;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn milk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}


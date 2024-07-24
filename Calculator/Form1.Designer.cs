namespace Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblresult = new System.Windows.Forms.Label();
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.textNumber2 = new System.Windows.Forms.TextBox();
            this.btnEqull = new System.Windows.Forms.Button();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMinuss = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDevid = new System.Windows.Forms.Button();
            this.btnPluss = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.Controls.Add(this.lblresult, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textNumber1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textNumber2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEqull, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbOperator, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(645, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(39, 16);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "result";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(3, 3);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(186, 22);
            this.textNumber1.TabIndex = 0;
            this.textNumber1.TextChanged += new System.EventHandler(this.textNumber1_TextChanged);
            this.textNumber1.Enter += new System.EventHandler(this.textNumber1_Enter);
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(345, 3);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(144, 22);
            this.textNumber2.TabIndex = 2;
            this.textNumber2.Enter += new System.EventHandler(this.textNumber2_Enter);
            // 
            // btnEqull
            // 
            this.btnEqull.Location = new System.Drawing.Point(495, 3);
            this.btnEqull.Name = "btnEqull";
            this.btnEqull.Size = new System.Drawing.Size(75, 23);
            this.btnEqull.TabIndex = 5;
            this.btnEqull.Text = "=";
            this.btnEqull.UseVisualStyleBackColor = true;
            this.btnEqull.Click += new System.EventHandler(this.btnEqull_Click);
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(195, 3);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(121, 24);
            this.cmbOperator.TabIndex = 6;
            this.cmbOperator.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnMinuss, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnMulti, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDevid, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnPluss, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(761, 166);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(119, 322);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnMinuss
            // 
            this.btnMinuss.Location = new System.Drawing.Point(3, 93);
            this.btnMinuss.Name = "btnMinuss";
            this.btnMinuss.Size = new System.Drawing.Size(92, 41);
            this.btnMinuss.TabIndex = 1;
            this.btnMinuss.Text = "-";
            this.btnMinuss.UseVisualStyleBackColor = true;
            this.btnMinuss.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(3, 177);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(92, 33);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnDevid
            // 
            this.btnDevid.Location = new System.Drawing.Point(3, 274);
            this.btnDevid.Name = "btnDevid";
            this.btnDevid.Size = new System.Drawing.Size(92, 32);
            this.btnDevid.TabIndex = 3;
            this.btnDevid.Text = "/";
            this.btnDevid.UseVisualStyleBackColor = true;
            this.btnDevid.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnPluss
            // 
            this.btnPluss.Location = new System.Drawing.Point(3, 3);
            this.btnPluss.Name = "btnPluss";
            this.btnPluss.Size = new System.Drawing.Size(92, 40);
            this.btnPluss.TabIndex = 0;
            this.btnPluss.Text = "+";
            this.btnPluss.UseVisualStyleBackColor = true;
            this.btnPluss.Click += new System.EventHandler(this.button11_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button7, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button15, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button16, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 139);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 491);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 128);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 128);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 128);
            this.button4.TabIndex = 3;
            this.button4.Text = "5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(417, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 128);
            this.button5.TabIndex = 4;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(201, 128);
            this.button6.TabIndex = 5;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(417, 271);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(203, 125);
            this.button7.TabIndex = 6;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(210, 271);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(201, 125);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 271);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(201, 125);
            this.button9.TabIndex = 8;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 402);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(201, 86);
            this.button10.TabIndex = 9;
            this.button10.Text = ".";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(210, 402);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(201, 86);
            this.button15.TabIndex = 10;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(417, 402);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(203, 86);
            this.button16.TabIndex = 11;
            this.button16.Text = "00";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 128);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClikGlobal);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 733);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox textNumber1;
        private System.Windows.Forms.Button btnEqull;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPluss;
        private System.Windows.Forms.Button btnMinuss;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDevid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.ComboBox cmbOperator;
    }
}


namespace Oreach
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ברוכים הבאים";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(408, 146);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(333, 22);
            this.txtGuestName.TabIndex = 2;
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 16;
            this.listBoxNames.Location = new System.Drawing.Point(510, 251);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(132, 196);
            this.listBoxNames.TabIndex = 3;
            this.listBoxNames.DoubleClick += new System.EventHandler(this.listBoxNames_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "הכנס שם אורח";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Label label2;
    }
}


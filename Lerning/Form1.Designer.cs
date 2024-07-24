namespace Lernung
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startDogs = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnStartRuning = new System.Windows.Forms.Button();
            this.btnStartEating = new System.Windows.Forms.Button();
            this.btnStartPlaying = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 22);
            this.textBox1.TabIndex = 1;
            // 
            // startDogs
            // 
            this.startDogs.Location = new System.Drawing.Point(640, 243);
            this.startDogs.Name = "startDogs";
            this.startDogs.Size = new System.Drawing.Size(121, 42);
            this.startDogs.TabIndex = 10;
            this.startDogs.Text = "start Dogs";
            this.startDogs.UseVisualStyleBackColor = true;
            this.startDogs.Click += new System.EventHandler(this.startDogs_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(531, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 9;
            // 
            // btnStartRuning
            // 
            this.btnStartRuning.Location = new System.Drawing.Point(640, 291);
            this.btnStartRuning.Name = "btnStartRuning";
            this.btnStartRuning.Size = new System.Drawing.Size(121, 34);
            this.btnStartRuning.TabIndex = 11;
            this.btnStartRuning.Text = "Start Runing";
            this.btnStartRuning.UseVisualStyleBackColor = true;
            this.btnStartRuning.Click += new System.EventHandler(this.btnStartRuning_Click);
            // 
            // btnStartEating
            // 
            this.btnStartEating.Location = new System.Drawing.Point(640, 331);
            this.btnStartEating.Name = "btnStartEating";
            this.btnStartEating.Size = new System.Drawing.Size(121, 44);
            this.btnStartEating.TabIndex = 12;
            this.btnStartEating.Text = "Start Eating";
            this.btnStartEating.UseVisualStyleBackColor = true;
            this.btnStartEating.Click += new System.EventHandler(this.btnStartEating_Click);
            // 
            // btnStartPlaying
            // 
            this.btnStartPlaying.Location = new System.Drawing.Point(640, 381);
            this.btnStartPlaying.Name = "btnStartPlaying";
            this.btnStartPlaying.Size = new System.Drawing.Size(121, 46);
            this.btnStartPlaying.TabIndex = 13;
            this.btnStartPlaying.Text = "Start Playing";
            this.btnStartPlaying.UseVisualStyleBackColor = true;
            this.btnStartPlaying.Click += new System.EventHandler(this.btnStartPlaying_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 445);
            this.Controls.Add(this.btnStartPlaying);
            this.Controls.Add(this.btnStartEating);
            this.Controls.Add(this.btnStartRuning);
            this.Controls.Add(this.startDogs);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startDogs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnStartRuning;
        private System.Windows.Forms.Button btnStartEating;
        private System.Windows.Forms.Button btnStartPlaying;
    }
}


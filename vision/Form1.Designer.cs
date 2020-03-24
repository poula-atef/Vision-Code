namespace vision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.wait = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.arabic = new System.Windows.Forms.RadioButton();
            this.english = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(110, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tekton Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your words";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "continue";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wait
            // 
            this.wait.BackColor = System.Drawing.Color.Black;
            this.wait.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wait.ForeColor = System.Drawing.Color.White;
            this.wait.Location = new System.Drawing.Point(12, 144);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(75, 28);
            this.wait.TabIndex = 6;
            this.wait.Text = "wait";
            this.wait.UseVisualStyleBackColor = false;
            this.wait.Visible = false;
            this.wait.Click += new System.EventHandler(this.wait_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Black;
            this.start.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(12, 98);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 28);
            this.start.TabIndex = 5;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // arabic
            // 
            this.arabic.AutoSize = true;
            this.arabic.Font = new System.Drawing.Font("Tekton Pro", 12F, System.Drawing.FontStyle.Bold);
            this.arabic.ForeColor = System.Drawing.Color.White;
            this.arabic.Location = new System.Drawing.Point(16, 12);
            this.arabic.Name = "arabic";
            this.arabic.Size = new System.Drawing.Size(69, 23);
            this.arabic.TabIndex = 8;
            this.arabic.TabStop = true;
            this.arabic.Text = "Arabic";
            this.arabic.UseVisualStyleBackColor = true;
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Font = new System.Drawing.Font("Tekton Pro", 12F, System.Drawing.FontStyle.Bold);
            this.english.ForeColor = System.Drawing.Color.White;
            this.english.Location = new System.Drawing.Point(131, 12);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(72, 23);
            this.english.TabIndex = 9;
            this.english.TabStop = true;
            this.english.Text = "english";
            this.english.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(244, 132);
            this.Controls.Add(this.english);
            this.Controls.Add(this.arabic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button wait;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RadioButton arabic;
        private System.Windows.Forms.RadioButton english;

    }
}


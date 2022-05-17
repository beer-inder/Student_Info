namespace Student_Info
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
            this.LB_Student = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Update_Record = new System.Windows.Forms.Button();
            this.Delete_Record = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Student
            // 
            this.LB_Student.FormattingEnabled = true;
            this.LB_Student.ItemHeight = 16;
            this.LB_Student.Location = new System.Drawing.Point(708, 15);
            this.LB_Student.Margin = new System.Windows.Forms.Padding(4);
            this.LB_Student.Name = "LB_Student";
            this.LB_Student.Size = new System.Drawing.Size(273, 404);
            this.LB_Student.TabIndex = 0;
            this.LB_Student.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LB_Student_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student FName";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student LName";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Record
            // 
            this.Update_Record.Location = new System.Drawing.Point(348, 251);
            this.Update_Record.Name = "Update_Record";
            this.Update_Record.Size = new System.Drawing.Size(162, 38);
            this.Update_Record.TabIndex = 8;
            this.Update_Record.Text = "Update";
            this.Update_Record.UseVisualStyleBackColor = true;
            this.Update_Record.Click += new System.EventHandler(this.Update_Record_Click);
            // 
            // Delete_Record
            // 
            this.Delete_Record.Location = new System.Drawing.Point(204, 351);
            this.Delete_Record.Name = "Delete_Record";
            this.Delete_Record.Size = new System.Drawing.Size(214, 31);
            this.Delete_Record.TabIndex = 9;
            this.Delete_Record.Text = "Delete";
            this.Delete_Record.UseVisualStyleBackColor = true;
            this.Delete_Record.Click += new System.EventHandler(this.Delete_Record_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.Delete_Record);
            this.Controls.Add(this.Update_Record);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LB_Student);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Student;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update_Record;
        private System.Windows.Forms.Button Delete_Record;
    }
}


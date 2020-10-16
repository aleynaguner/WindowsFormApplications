using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Kontrolleri kendimiz girmek için yapmamız gerekenler;

            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            //label
            //
            this.label1.AutoSize = true;
            this.label1.Location = new Point(108, 24);
            this.label1.Name = "label1";
            this.label1.Size = new Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            //
            //button1
            //
            this.button1.Location = new System.Drawing.Point(27, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            //
            //button2
            //
            this.button2.Location = new System.Drawing.Point(127, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            //
            //button3
            //
            this.button3.Location = new System.Drawing.Point(77, 48);
            this.button3.Name = "button1";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sıfırla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            //
            //Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);
            a++;
            label1.Text = a.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(label1.Text);
            b--;
            label1.Text = b.ToString();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label  label1;

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}

﻿namespace DesafioAsenjo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(12, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(347, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(12, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(347, 23);
            textBox3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite aqui:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Texto Criptografado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 3;
            label3.Text = "Texto Decriptado:";
            // 
            // button1
            // 
            button1.Location = new Point(89, 240);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Encriptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 240);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Decriptar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(89, 269);
            button3.Name = "button3";
            button3.Size = new Size(177, 23);
            button3.TabIndex = 4;
            button3.Text = "Limpar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 322);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

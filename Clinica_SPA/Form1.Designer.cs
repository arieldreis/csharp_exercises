namespace Clinica_SPA
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(690, 14);
            label1.Name = "label1";
            label1.Size = new Size(153, 54);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(251, 246, 255);
            textBox1.Location = new Point(654, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(664, 105);
            label2.Name = "label2";
            label2.Size = new Size(57, 16);
            label2.TabIndex = 2;
            label2.Text = "Seu Nome";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(251, 246, 255);
            textBox2.Location = new Point(654, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(664, 155);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 4;
            label3.Text = "Sobrenome";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(251, 246, 255);
            textBox3.Location = new Point(654, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(664, 196);
            label4.Name = "label4";
            label4.Size = new Size(36, 16);
            label4.TabIndex = 6;
            label4.Text = "E-mail";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(251, 246, 255);
            textBox4.Location = new Point(654, 242);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(664, 244);
            label5.Name = "label5";
            label5.Size = new Size(54, 16);
            label5.TabIndex = 8;
            label5.Text = "WhatsApp";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(635, 280);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(266, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Eu concordo em receber os termos de saúde. ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(729, 362);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1683, 450);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Padding = new Padding(0, 5, 0, 0);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private CheckBox checkBox1;
        private Label label6;
    }
}

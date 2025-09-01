namespace form5
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(111, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 134);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 1;
            label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(559, 134);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(433, 43);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 3;
            label4.Text = "Telefone";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(527, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(295, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(634, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 227);
            label5.Name = "label5";
            label5.Size = new Size(61, 22);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 303);
            label6.Name = "label6";
            label6.Size = new Size(142, 22);
            label6.TabIndex = 9;
            label6.Text = "Data Cadastro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(465, 228);
            label7.Name = "label7";
            label7.Size = new Size(98, 22);
            label7.TabIndex = 10;
            label7.Text = "Endereço";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(180, 227);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(582, 226);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(232, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(259, 302);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(270, 23);
            textBox7.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1062, 450);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}

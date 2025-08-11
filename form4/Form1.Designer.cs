namespace form4
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(353, 24);
            label1.Name = "label1";
            label1.Size = new Size(456, 81);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harlow Solid Italic", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(462, 105);
            label2.Name = "label2";
            label2.Size = new Size(209, 45);
            label2.TabIndex = 1;
            label2.Text = "spar aeroflear";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 211);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 2;
            label3.Text = "Período";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 288);
            label4.Name = "label4";
            label4.Size = new Size(225, 22);
            label4.TabIndex = 3;
            label4.Text = "Atividades Contratadas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 378);
            label5.Name = "label5";
            label5.Size = new Size(124, 22);
            label5.TabIndex = 4;
            label5.Text = "Alimentação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(632, 204);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 5;
            label6.Text = "Acomodação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(606, 351);
            label7.Name = "label7";
            label7.Size = new Size(225, 22);
            label7.TabIndex = 6;
            label7.Text = "Quantidade de Pessoas";
            label7.Click += label7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 29);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(390, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 29);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(299, 375);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 29);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(789, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 29);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(837, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(293, 29);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(560, 520);
            button1.Name = "button1";
            button1.Size = new Size(111, 62);
            button1.TabIndex = 12;
            button1.Text = "Valor";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1371, 660);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
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
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}

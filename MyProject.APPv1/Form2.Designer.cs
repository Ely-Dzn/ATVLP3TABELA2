namespace MyProject.APPv1
{
    partial class Form2
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(566, 231);
            button3.Name = "button3";
            button3.Size = new Size(116, 53);
            button3.TabIndex = 9;
            button3.Text = "Listar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(566, 329);
            button2.Name = "button2";
            button2.Size = new Size(116, 53);
            button2.TabIndex = 7;
            button2.Text = "Atualização";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(566, 430);
            button1.Name = "button1";
            button1.Size = new Size(116, 53);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 52);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 5;
            label1.Text = "Cadastro de Projetos";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 122);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 11;
            label2.Text = "Nome do Projeto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 125);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 13;
            label3.Text = "Nome do Gerente do Projeto";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(509, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 191);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 15;
            label4.Text = "Data inicio do Projeto";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 329);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 17;
            label5.Text = "Resumo do Projeto";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 250);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 19;
            label6.Text = "Data fim do Projeto";
            label6.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(85, 364);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(308, 129);
            textBox6.TabIndex = 20;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(187, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 23);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(187, 250);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(237, 23);
            dateTimePicker2.TabIndex = 22;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}
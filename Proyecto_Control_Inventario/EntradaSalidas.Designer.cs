namespace Proyecto_Control_Inventario
{
    partial class EntradaSalidas
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
            label9 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox9 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            BuscarButton = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            numericUpDown2 = new NumericUpDown();
            label10 = new Label();
            textBox3 = new TextBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label9.Location = new Point(25, 67);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 70;
            label9.Text = "RESPONSABLE";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label1.Location = new Point(25, 119);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 72;
            label1.Text = "FECHA";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label2.Location = new Point(25, 174);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 74;
            label2.Text = "NOTA";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox9.Location = new Point(25, 200);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(200, 119);
            textBox9.TabIndex = 75;
            textBox9.Text = "INGRESE NOTA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label3.Location = new Point(25, 325);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 76;
            label3.Text = "TIPO DE CARGO";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox1.Location = new Point(283, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 21);
            textBox1.TabIndex = 77;
            textBox1.Text = "INGRESE CÓDIGO DE PRODUCTO";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 93);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 20);
            listBox1.TabIndex = 78;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(25, 351);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(200, 20);
            listBox2.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 16);
            label4.Name = "label4";
            label4.Size = new Size(276, 34);
            label4.TabIndex = 80;
            label4.Text = "ENTRADAS Y SALIDAS";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 439);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(571, 150);
            dataGridView1.TabIndex = 81;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label5.Location = new Point(283, 67);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 82;
            label5.Text = "PRODUCTO";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BuscarButton
            // 
            BuscarButton.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarButton.Location = new Point(500, 90);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 83;
            BuscarButton.Text = "BUSCAR";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label6.Location = new Point(283, 125);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 85;
            label6.Text = "DESCRIPCIÓN";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox2.Location = new Point(283, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 21);
            textBox2.TabIndex = 84;
            textBox2.Text = "INGRESE DESCRIPCION DE PRODUCTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label7.Location = new Point(283, 177);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 87;
            label7.Text = "CANTIDAD";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(283, 200);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 21);
            numericUpDown1.TabIndex = 86;
            // 
            // button1
            // 
            button1.Cursor = Cursors.SizeAll;
            button1.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(283, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 88;
            button1.Text = "AÑADIR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.SizeAll;
            button2.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(521, 627);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 89;
            button2.Text = "PROCESAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.SizeAll;
            button3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(440, 627);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 90;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label8.Location = new Point(283, 235);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 92;
            label8.Text = "PRECIO";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            numericUpDown2.Location = new Point(283, 258);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 21);
            numericUpDown2.TabIndex = 91;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label10.Location = new Point(283, 293);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 94;
            label10.Text = "LOTE";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox3.Location = new Point(283, 316);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 21);
            textBox3.TabIndex = 93;
            textBox3.Text = "INGRESE LOTE";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(283, 128);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(200, 124);
            listBox3.TabIndex = 95;
            // 
            // listBox4
            // 
            listBox4.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(25, 413);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(200, 20);
            listBox4.TabIndex = 97;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label11.Location = new Point(25, 387);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 96;
            label11.Text = "BODEGA";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EntradaSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(618, 689);
            Controls.Add(listBox4);
            Controls.Add(label11);
            Controls.Add(listBox3);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(numericUpDown2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(BuscarButton);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox9);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EntradaSalidas";
            Text = "EntradaSalidas";
            Load += EntradaSalidas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox9;
        private Label label3;
        private TextBox textBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Button BuscarButton;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private Label label10;
        private TextBox textBox3;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label11;
    }
}
namespace Proyecto_Control_Inventario
{
    partial class PuntoVentas
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            BuscarButton = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 413);
            dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 25;
            label3.Text = "CÓDIGO";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BuscarButton
            // 
            BuscarButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            BuscarButton.Location = new Point(353, 72);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 24;
            BuscarButton.Text = "BUSCAR";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox1.Location = new Point(12, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 21);
            textBox1.TabIndex = 23;
            textBox1.Text = "INGRESE CODIGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(235, 34);
            label4.TabIndex = 81;
            label4.Text = "PUNTO DE VENTAS";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(475, 108);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(266, 323);
            dataGridView2.TabIndex = 82;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Medium Cond", 9F);
            button1.Location = new Point(475, 521);
            button1.Name = "button1";
            button1.Size = new Size(262, 45);
            button1.TabIndex = 83;
            button1.Text = "FINALIZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label1.Location = new Point(655, 72);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 84;
            label1.Text = "CORRELATIVO";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(475, 445);
            label5.Name = "label5";
            label5.Size = new Size(52, 24);
            label5.TabIndex = 86;
            label5.Text = "TOTAL";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(689, 445);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 87;
            label2.Text = "0.00";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.Font = new Font("Franklin Gothic Medium Cond", 9F);
            button2.Location = new Point(664, 34);
            button2.Name = "button2";
            button2.Size = new Size(77, 21);
            button2.TabIndex = 89;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox2.Location = new Point(475, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 21);
            textBox2.TabIndex = 88;
            textBox2.Text = "INDIQUE CLIENTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 535);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 90;
            label6.Text = "NombreUsuario";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(112, 533);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 21);
            dateTimePicker1.TabIndex = 91;
            // 
            // button3
            // 
            button3.Cursor = Cursors.SizeAll;
            button3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(677, 577);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 92;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Franklin Gothic Medium Cond", 9F);
            button4.Location = new Point(475, 476);
            button4.Name = "button4";
            button4.Size = new Size(262, 45);
            button4.TabIndex = 93;
            button4.Text = "PROCESAR";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(475, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 94);
            listBox1.TabIndex = 94;
            // 
            // PuntoVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(764, 612);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BuscarButton);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PuntoVentas";
            Text = "PuntoVentas";
            Load += PuntoVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private Button BuscarButton;
        private TextBox textBox1;
        private Label label4;
        private DataGridView dataGridView2;
        private Button button1;
        private Label label1;
        private Label label5;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
    }
}
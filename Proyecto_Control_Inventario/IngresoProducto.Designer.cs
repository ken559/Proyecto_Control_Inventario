namespace Proyecto_Control_Inventario
{
    partial class IngresoProducto
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
            Guardarbutton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            BuscarButton = new Button();
            EditarButton = new Button();
            BorrarButton = new Button();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Guardarbutton
            // 
            Guardarbutton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            Guardarbutton.Location = new Point(22, 357);
            Guardarbutton.Name = "Guardarbutton";
            Guardarbutton.Size = new Size(75, 23);
            Guardarbutton.TabIndex = 0;
            Guardarbutton.Text = "GUARDAR";
            Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox1.Location = new Point(22, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 21);
            textBox1.TabIndex = 1;
            textBox1.Text = "INGRESE CODIGO";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox2.Location = new Point(22, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(416, 21);
            textBox2.TabIndex = 2;
            textBox2.Text = "INGRESE DESCRIPCION DE PRODUCTO";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox5.Location = new Point(22, 269);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(276, 21);
            textBox5.TabIndex = 5;
            textBox5.Text = "INGRESE PRESENTACION (UNIDAD, PAQUETE, ETC.)";
            // 
            // BuscarButton
            // 
            BuscarButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            BuscarButton.Location = new Point(363, 100);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 6;
            BuscarButton.Text = "BUSCAR";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // EditarButton
            // 
            EditarButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            EditarButton.Location = new Point(184, 357);
            EditarButton.Name = "EditarButton";
            EditarButton.Size = new Size(75, 23);
            EditarButton.TabIndex = 7;
            EditarButton.Text = "EDITAR";
            EditarButton.UseVisualStyleBackColor = true;
            // 
            // BorrarButton
            // 
            BorrarButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            BorrarButton.Location = new Point(103, 357);
            BorrarButton.Name = "BorrarButton";
            BorrarButton.Size = new Size(75, 23);
            BorrarButton.TabIndex = 8;
            BorrarButton.Text = "BORRAR";
            BorrarButton.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(318, 269);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 21);
            numericUpDown1.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(189, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "¿Este producto lleva impuesto?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 30);
            label2.Name = "label2";
            label2.Size = new Size(304, 34);
            label2.TabIndex = 21;
            label2.Text = "INGRESO DE PRODUCTO";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label3.Location = new Point(22, 77);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 22;
            label3.Text = "CÓDIGO";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label4.Location = new Point(22, 134);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 23;
            label4.Text = "DESCRIPCIÓN";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label1.Location = new Point(318, 246);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 24;
            label1.Text = "PRECIO";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label5.Location = new Point(22, 246);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 25;
            label5.Text = "PRESENTACIÓN";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.Cursor = Cursors.SizeAll;
            button3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(363, 393);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 91;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label6.Location = new Point(22, 189);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 93;
            label6.Text = "MARCA";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox3.Location = new Point(22, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 21);
            textBox3.TabIndex = 92;
            textBox3.Text = "INGRESE DESCRIPCION DE PRODUCTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label7.Location = new Point(249, 189);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 95;
            label7.Text = "MODELO";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Italic);
            textBox4.Location = new Point(249, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 21);
            textBox4.TabIndex = 94;
            textBox4.Text = "INGRESE DESCRIPCION DE PRODUCTO";
            // 
            // IngresoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(464, 439);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(BorrarButton);
            Controls.Add(EditarButton);
            Controls.Add(BuscarButton);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Guardarbutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IngresoProducto";
            Text = "IngresoProducto";
            Load += IngresoProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guardarbutton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private Button BuscarButton;
        private Button EditarButton;
        private Button BorrarButton;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label5;
        private Button button3;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
    }
}
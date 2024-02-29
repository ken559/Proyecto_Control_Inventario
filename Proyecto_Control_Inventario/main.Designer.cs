namespace Proyecto_Control_Inventario
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            pictureBox1 = new PictureBox();
            Userlabel = new Label();
            Puestolabel = new Label();
            productoButton = new Button();
            entrdaSalidabutton = new Button();
            kardexbutton = new Button();
            InformeVentabutton = new Button();
            UsuarioButton = new Button();
            ProveedorButton = new Button();
            EmpleadosButton = new Button();
            BodegaButton = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Userlabel
            // 
            Userlabel.AutoSize = true;
            Userlabel.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userlabel.Location = new Point(38, 216);
            Userlabel.Name = "Userlabel";
            Userlabel.Size = new Size(115, 24);
            Userlabel.TabIndex = 1;
            Userlabel.Text = "USER NAME";
            // 
            // Puestolabel
            // 
            Puestolabel.AutoSize = true;
            Puestolabel.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Puestolabel.Location = new Point(65, 240);
            Puestolabel.Name = "Puestolabel";
            Puestolabel.Size = new Size(53, 20);
            Puestolabel.TabIndex = 2;
            Puestolabel.Text = "puesto";
            // 
            // productoButton
            // 
            productoButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            productoButton.Location = new Point(234, 29);
            productoButton.Name = "productoButton";
            productoButton.Size = new Size(164, 137);
            productoButton.TabIndex = 3;
            productoButton.Text = "INGRESO DE PRODUCTO";
            productoButton.UseVisualStyleBackColor = true;
            productoButton.Click += productoButton_Click;
            // 
            // entrdaSalidabutton
            // 
            entrdaSalidabutton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            entrdaSalidabutton.Location = new Point(443, 29);
            entrdaSalidabutton.Name = "entrdaSalidabutton";
            entrdaSalidabutton.Size = new Size(164, 137);
            entrdaSalidabutton.TabIndex = 4;
            entrdaSalidabutton.Text = "ENTRADA Y SALIDA";
            entrdaSalidabutton.UseVisualStyleBackColor = true;
            // 
            // kardexbutton
            // 
            kardexbutton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            kardexbutton.Location = new Point(443, 198);
            kardexbutton.Name = "kardexbutton";
            kardexbutton.Size = new Size(164, 143);
            kardexbutton.TabIndex = 6;
            kardexbutton.Text = "KARDEX";
            kardexbutton.UseVisualStyleBackColor = true;
            kardexbutton.Click += kardexbutton_Click;
            // 
            // InformeVentabutton
            // 
            InformeVentabutton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            InformeVentabutton.Location = new Point(234, 373);
            InformeVentabutton.Name = "InformeVentabutton";
            InformeVentabutton.Size = new Size(164, 143);
            InformeVentabutton.TabIndex = 7;
            InformeVentabutton.Text = "INFORME DE VENTAS";
            InformeVentabutton.UseVisualStyleBackColor = true;
            // 
            // UsuarioButton
            // 
            UsuarioButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            UsuarioButton.Location = new Point(32, 297);
            UsuarioButton.Name = "UsuarioButton";
            UsuarioButton.Size = new Size(131, 23);
            UsuarioButton.TabIndex = 8;
            UsuarioButton.Text = "USUARIOS";
            UsuarioButton.UseVisualStyleBackColor = true;
            // 
            // ProveedorButton
            // 
            ProveedorButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            ProveedorButton.Location = new Point(32, 341);
            ProveedorButton.Name = "ProveedorButton";
            ProveedorButton.Size = new Size(131, 23);
            ProveedorButton.TabIndex = 9;
            ProveedorButton.Text = "PROVEEDOR";
            ProveedorButton.UseVisualStyleBackColor = true;
            // 
            // EmpleadosButton
            // 
            EmpleadosButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            EmpleadosButton.Location = new Point(32, 385);
            EmpleadosButton.Name = "EmpleadosButton";
            EmpleadosButton.Size = new Size(131, 23);
            EmpleadosButton.TabIndex = 10;
            EmpleadosButton.Text = "EMPLEADOS";
            EmpleadosButton.UseVisualStyleBackColor = true;
            // 
            // BodegaButton
            // 
            BodegaButton.Font = new Font("Franklin Gothic Medium Cond", 9F);
            BodegaButton.Location = new Point(32, 429);
            BodegaButton.Name = "BodegaButton";
            BodegaButton.Size = new Size(131, 23);
            BodegaButton.TabIndex = 11;
            BodegaButton.Text = "BODEGA";
            BodegaButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Medium Cond", 9F);
            button1.Location = new Point(234, 198);
            button1.Name = "button1";
            button1.Size = new Size(164, 143);
            button1.TabIndex = 13;
            button1.Text = "PUNTO DE VENTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Franklin Gothic Medium Cond", 9F);
            button2.Location = new Point(488, 532);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 14;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(643, 567);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BodegaButton);
            Controls.Add(EmpleadosButton);
            Controls.Add(ProveedorButton);
            Controls.Add(UsuarioButton);
            Controls.Add(InformeVentabutton);
            Controls.Add(kardexbutton);
            Controls.Add(entrdaSalidabutton);
            Controls.Add(productoButton);
            Controls.Add(Puestolabel);
            Controls.Add(Userlabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "main";
            Text = "main";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Userlabel;
        private Label Puestolabel;
        private Button productoButton;
        private Button entrdaSalidabutton;
        private Button kardexbutton;
        private Button InformeVentabutton;
        private Button UsuarioButton;
        private Button ProveedorButton;
        private Button EmpleadosButton;
        private Button BodegaButton;
        private Button button1;
        private Button button2;
    }
}
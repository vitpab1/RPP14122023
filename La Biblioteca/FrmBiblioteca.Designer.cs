namespace La_Biblioteca
{
    partial class FrmBiblioteca
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
            lstLibros = new ListBox();
            rchTextBox = new RichTextBox();
            btnIngresar = new Button();
            btnListar = new Button();
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            printDialog1 = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstLibros
            // 
            lstLibros.FormattingEnabled = true;
            lstLibros.ItemHeight = 15;
            lstLibros.Location = new Point(12, 14);
            lstLibros.Name = "lstLibros";
            lstLibros.Size = new Size(411, 559);
            lstLibros.TabIndex = 0;
            // 
            // rchTextBox
            // 
            rchTextBox.Location = new Point(429, 320);
            rchTextBox.Name = "rchTextBox";
            rchTextBox.Size = new Size(524, 253);
            rchTextBox.TabIndex = 1;
            rchTextBox.Text = "";
            rchTextBox.TextChanged += richTextBox1_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(429, 229);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(167, 85);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar Libro";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(786, 229);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(167, 85);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar Biblioteca";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(602, 229);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 85);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Dar de baja libro seleccionado";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(602, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 177);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 589);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnListar);
            Controls.Add(btnIngresar);
            Controls.Add(rchTextBox);
            Controls.Add(lstLibros);
            Name = "FrmBiblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmBiblioteca_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstLibros;
        private RichTextBox rchTextBox;
        private Button btnIngresar;
        private Button btnListar;
        private Button btnEliminar;
        private PictureBox pictureBox1;
        private PrintDialog printDialog1;
    }
}
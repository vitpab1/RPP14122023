namespace La_Biblioteca
{
    partial class AltaLibro
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
            txtNombre = new TextBox();
            edicionBtn = new CheckBox();
            colorBtn = new CheckBox();
            btnCrear = new Button();
            cmbTipoLibro = new ComboBox();
            cmbDificultad = new ComboBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(11, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 23);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Nombre del libro";
            // 
            // edicionBtn
            // 
            edicionBtn.AutoSize = true;
            edicionBtn.Location = new Point(22, 166);
            edicionBtn.Name = "edicionBtn";
            edicionBtn.Size = new Size(134, 19);
            edicionBtn.TabIndex = 3;
            edicionBtn.Text = "¿Es edicion especial?";
            edicionBtn.UseVisualStyleBackColor = true;
            // 
            // colorBtn
            // 
            colorBtn.AutoSize = true;
            colorBtn.Location = new Point(22, 211);
            colorBtn.Name = "colorBtn";
            colorBtn.Size = new Size(74, 19);
            colorBtn.TabIndex = 4;
            colorBtn.Text = "¿A color?";
            colorBtn.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(23, 305);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(235, 113);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // cmbTipoLibro
            // 
            cmbTipoLibro.FormattingEnabled = true;
            cmbTipoLibro.Location = new Point(23, 12);
            cmbTipoLibro.Name = "cmbTipoLibro";
            cmbTipoLibro.Size = new Size(121, 23);
            cmbTipoLibro.TabIndex = 6;
            // 
            // cmbDificultad
            // 
            cmbDificultad.FormattingEnabled = true;
            cmbDificultad.Location = new Point(22, 121);
            cmbDificultad.Name = "cmbDificultad";
            cmbDificultad.Size = new Size(121, 23);
            cmbDificultad.TabIndex = 7;
            // 
            // AltaLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Controls.Add(cmbDificultad);
            Controls.Add(cmbTipoLibro);
            Controls.Add(btnCrear);
            Controls.Add(colorBtn);
            Controls.Add(edicionBtn);
            Controls.Add(txtNombre);
            Name = "AltaLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaLibro";
            Load += AltaLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private CheckBox edicionBtn;
        private CheckBox colorBtn;
        private Button btnCrear;
        private ComboBox cmbTipoLibro;
        private ComboBox cmbDificultad;
    }
}
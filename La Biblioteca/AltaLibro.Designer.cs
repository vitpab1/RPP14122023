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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            edicionBtn = new CheckBox();
            colorBtn = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(245, 23);
            comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Nombre del libro";
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
            // button1
            // 
            button1.Location = new Point(23, 305);
            button1.Name = "button1";
            button1.Size = new Size(235, 113);
            button1.TabIndex = 5;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            // 
            // AltaLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Controls.Add(button1);
            Controls.Add(colorBtn);
            Controls.Add(edicionBtn);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "AltaLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaLibro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private CheckBox edicionBtn;
        private CheckBox colorBtn;
        private Button button1;
    }
}
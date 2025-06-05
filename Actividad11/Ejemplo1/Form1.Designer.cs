namespace Ejemplo1
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
            btnRegistrar = new Button();
            lbResultado = new Label();
            tbResultado = new TextBox();
            btnPromedio = new Button();
            tbRegistrar = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Adobe Myungjo Std M", 10F);
            btnRegistrar.Location = new Point(289, 34);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(110, 50);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Adobe Myungjo Std M", 15.75F);
            lbResultado.Location = new Point(47, 144);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(109, 22);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // tbResultado
            // 
            tbResultado.Font = new Font("Adobe Myungjo Std M", 15F);
            tbResultado.Location = new Point(47, 180);
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(352, 47);
            tbResultado.TabIndex = 2;
            // 
            // btnPromedio
            // 
            btnPromedio.Font = new Font("Adobe Myungjo Std M", 10F);
            btnPromedio.Location = new Point(289, 104);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(110, 50);
            btnPromedio.TabIndex = 3;
            btnPromedio.Text = "Mostrar Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            // 
            // tbRegistrar
            // 
            tbRegistrar.Font = new Font("Adobe Myungjo Std M", 15F);
            tbRegistrar.Location = new Point(47, 34);
            tbRegistrar.Name = "tbRegistrar";
            tbRegistrar.Size = new Size(217, 47);
            tbRegistrar.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 382);
            Controls.Add(tbRegistrar);
            Controls.Add(btnPromedio);
            Controls.Add(tbResultado);
            Controls.Add(lbResultado);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label lbResultado;
        private TextBox tbResultado;
        private Button btnPromedio;
        private TextBox tbRegistrar;
    }
}

namespace pryCalculadora
{
    partial class frmCalculadora
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
            txtN1 = new TextBox();
            label1 = new Label();
            txtN2 = new TextBox();
            label2 = new Label();
            txtResultado = new TextBox();
            label3 = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // txtN1
            // 
            txtN1.Font = new Font("Segoe UI", 13.8F);
            txtN1.Location = new Point(282, 75);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(327, 38);
            txtN1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(131, 75);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 1;
            label1.Text = "Número 1";
            // 
            // txtN2
            // 
            txtN2.Font = new Font("Segoe UI", 13.8F);
            txtN2.Location = new Point(279, 144);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(330, 38);
            txtN2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(131, 135);
            label2.Name = "label2";
            label2.Size = new Size(115, 31);
            label2.TabIndex = 3;
            label2.Text = "Número 2";
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 13.8F);
            txtResultado.Location = new Point(282, 338);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(330, 38);
            txtResultado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(131, 338);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 13.8F);
            btnSumar.Location = new Point(279, 275);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(127, 48);
            btnSumar.TabIndex = 6;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(279, 212);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(127, 47);
            btnRestar.TabIndex = 7;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(469, 212);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(140, 46);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "Múltiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(469, 275);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(140, 48);
            btnDividir.TabIndex = 9;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(txtN2);
            Controls.Add(label1);
            Controls.Add(txtN1);
            Name = "frmCalculadora";
            Text = "Calculadora de operaciones básicas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN1;
        private Label label1;
        private TextBox txtN2;
        private Label label2;
        private TextBox txtResultado;
        private Label label3;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}

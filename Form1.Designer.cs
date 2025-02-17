namespace DIVIDE_BY_ZERO
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
            BTNdividir = new Button();
            textBoxNumero1 = new TextBox();
            textBoxNumero2 = new TextBox();
            textBoxResultado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BTNdividir
            // 
            BTNdividir.Location = new Point(436, 30);
            BTNdividir.Name = "BTNdividir";
            BTNdividir.Size = new Size(48, 29);
            BTNdividir.TabIndex = 0;
            BTNdividir.Text = "=";
            BTNdividir.UseVisualStyleBackColor = true;
            BTNdividir.Click += BTNdividir_Click;
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(92, 30);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(125, 27);
            textBoxNumero1.TabIndex = 1;
            textBoxNumero1.TextChanged += textBoxNumero1_TextChanged;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(305, 32);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(125, 27);
            textBoxNumero2.TabIndex = 2;
            textBoxNumero2.TextChanged += textBoxNumero2_TextChanged;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(511, 31);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(125, 27);
            textBoxResultado.TabIndex = 3;
            textBoxResultado.TextChanged += textBoxResultado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 31);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 4;
            label1.Text = "/";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxNumero2);
            Controls.Add(textBoxNumero1);
            Controls.Add(BTNdividir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNdividir;
        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
        private TextBox textBoxResultado;
        private Label label1;
    }
}

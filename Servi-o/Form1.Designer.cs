namespace Servi_o
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
            txvalor1 = new TextBox();
            txvalor2 = new TextBox();
            lblValor01 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            btnSoma = new Button();
            btnMultiplicação = new Button();
            btnSub = new Button();
            SuspendLayout();
            // 
            // txvalor1
            // 
            txvalor1.Location = new Point(110, 72);
            txvalor1.Name = "txvalor1";
            txvalor1.Size = new Size(100, 23);
            txvalor1.TabIndex = 0;
            // 
            // txvalor2
            // 
            txvalor2.Location = new Point(110, 123);
            txvalor2.Name = "txvalor2";
            txvalor2.Size = new Size(100, 23);
            txvalor2.TabIndex = 1;
            // 
            // lblValor01
            // 
            lblValor01.AutoSize = true;
            lblValor01.Location = new Point(42, 80);
            lblValor01.Name = "lblValor01";
            lblValor01.Size = new Size(45, 15);
            lblValor01.TabIndex = 2;
            lblValor01.Text = "valor01";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 131);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "valor02";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 166);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "total";
            label3.Click += label3_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(133, 166);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(16, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "...";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(57, 220);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 23);
            btnSoma.TabIndex = 6;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnMultiplicação
            // 
            btnMultiplicação.Location = new Point(154, 220);
            btnMultiplicação.Name = "btnMultiplicação";
            btnMultiplicação.Size = new Size(75, 23);
            btnMultiplicação.TabIndex = 7;
            btnMultiplicação.Text = "Multiplicação";
            btnMultiplicação.UseVisualStyleBackColor = true;
            btnMultiplicação.Click += btnMultiplicação_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(246, 220);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 8;
            btnSub.Text = "Subtração";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSub);
            Controls.Add(btnMultiplicação);
            Controls.Add(btnSoma);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblValor01);
            Controls.Add(txvalor2);
            Controls.Add(txvalor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txvalor1;
        private TextBox txvalor2;
        private Label lblValor01;
        private Label label2;
        private Label label3;
        private Label lblResultado;
        private Button btnSoma;
        private Button btnMultiplicação;
        private Button btnSub;
    }
}

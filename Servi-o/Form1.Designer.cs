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
            lbtotal = new Label();
            lbresultado = new Label();
            btnSoma = new Button();
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
            // lbtotal
            // 
            lbtotal.AutoSize = true;
            lbtotal.Location = new Point(42, 166);
            lbtotal.Name = "lbtotal";
            lbtotal.Size = new Size(31, 15);
            lbtotal.TabIndex = 4;
            lbtotal.Text = "total";
            lbtotal.Click += label3_Click;
            // 
            // lbresultado
            // 
            lbresultado.AutoSize = true;
            lbresultado.Location = new Point(133, 166);
            lbresultado.Name = "lbresultado";
            lbresultado.Size = new Size(16, 15);
            lbresultado.TabIndex = 5;
            lbresultado.Text = "...";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(42, 203);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 23);
            btnSoma.TabIndex = 6;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSoma);
            Controls.Add(lbresultado);
            Controls.Add(lbtotal);
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
        private Label lbtotal;
        private Label lbresultado;
        private Button btnSoma;
    }
}

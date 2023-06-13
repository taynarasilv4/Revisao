namespace Revisao
{
    partial class Divisao
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
            this.tx_valor1 = new System.Windows.Forms.TextBox();
            this.tx_valor2 = new System.Windows.Forms.TextBox();
            this.tx_Calcular = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.tx_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_valor1
            // 
            this.tx_valor1.Location = new System.Drawing.Point(315, 134);
            this.tx_valor1.Name = "tx_valor1";
            this.tx_valor1.Size = new System.Drawing.Size(144, 27);
            this.tx_valor1.TabIndex = 0;
            // 
            // tx_valor2
            // 
            this.tx_valor2.Location = new System.Drawing.Point(315, 267);
            this.tx_valor2.Name = "tx_valor2";
            this.tx_valor2.Size = new System.Drawing.Size(144, 27);
            this.tx_valor2.TabIndex = 1;
            // 
            // tx_Calcular
            // 
            this.tx_Calcular.Location = new System.Drawing.Point(338, 353);
            this.tx_Calcular.Name = "tx_Calcular";
            this.tx_Calcular.Size = new System.Drawing.Size(94, 29);
            this.tx_Calcular.TabIndex = 2;
            this.tx_Calcular.Text = "Calcular";
            this.tx_Calcular.UseVisualStyleBackColor = true;
            this.tx_Calcular.Click += new System.EventHandler(this.tx_Calcular_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(535, 273);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 20);
            this.lb_resultado.TabIndex = 3;
            // 
            // tx_Resultado
            // 
            this.tx_Resultado.AutoSize = true;
            this.tx_Resultado.Location = new System.Drawing.Point(602, 232);
            this.tx_Resultado.Name = "tx_Resultado";
            this.tx_Resultado.Size = new System.Drawing.Size(50, 20);
            this.tx_Resultado.TabIndex = 4;
            this.tx_Resultado.Text = "label1";
            // 
            // Divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_Resultado);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.tx_Calcular);
            this.Controls.Add(this.tx_valor2);
            this.Controls.Add(this.tx_valor1);
            this.Name = "Divisao";
            this.Text = "Divisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tx_valor1;
        private TextBox tx_valor2;
        private Button tx_Calcular;
        private Label lb_resultado;
        private Label tx_Resultado;
    }
}
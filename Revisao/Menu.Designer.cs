namespace Revisao
{
    partial class Menu
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
            this.tx_Divisao = new System.Windows.Forms.Button();
            this.feminino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_Divisao
            // 
            this.tx_Divisao.Location = new System.Drawing.Point(322, 307);
            this.tx_Divisao.Name = "tx_Divisao";
            this.tx_Divisao.Size = new System.Drawing.Size(94, 29);
            this.tx_Divisao.TabIndex = 0;
            this.tx_Divisao.Text = "Divisao";
            this.tx_Divisao.UseVisualStyleBackColor = true;
            this.tx_Divisao.Click += new System.EventHandler(this.tx_Divisao_Click);
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.Location = new System.Drawing.Point(325, 95);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(91, 24);
            this.feminino.TabIndex = 1;
            this.feminino.TabStop = true;
            this.feminino.Text = "Feminino";
            this.feminino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(325, 153);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(97, 24);
            this.Masculino.TabIndex = 2;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.feminino);
            this.Controls.Add(this.tx_Divisao);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tx_Divisao;
        private RadioButton feminino;
        private RadioButton Masculino;
        private Button button1;
    }
}
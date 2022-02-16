using System;

namespace ValidacaoWorkAreas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInformeArquivo = new System.Windows.Forms.Label();
            this.btnValidaWa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblInformeArquivo
            // 
            this.lblInformeArquivo.AutoSize = true;
            this.lblInformeArquivo.Location = new System.Drawing.Point(13, 13);
            this.lblInformeArquivo.Name = "lblInformeArquivo";
            this.lblInformeArquivo.Size = new System.Drawing.Size(177, 13);
            this.lblInformeArquivo.TabIndex = 0;
            this.lblInformeArquivo.Text = "Selecione o arquivo para validar . . .";
            this.lblInformeArquivo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnValidaWa
            // 
            this.btnValidaWa.Location = new System.Drawing.Point(16, 42);
            this.btnValidaWa.Name = "btnValidaWa";
            this.btnValidaWa.Size = new System.Drawing.Size(142, 27);
            this.btnValidaWa.TabIndex = 1;
            this.btnValidaWa.Text = "Validar WorkAreas";
            this.btnValidaWa.UseVisualStyleBackColor = true;
            this.btnValidaWa.Click += new System.EventHandler(this.btnValidaWa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nenhum arquivo selecionado";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(210, 190);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(149, 52);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 245);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 256);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidaWa);
            this.Controls.Add(this.lblInformeArquivo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar Planilhas de Upload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label lblInformeArquivo;
        private System.Windows.Forms.Button btnValidaWa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}


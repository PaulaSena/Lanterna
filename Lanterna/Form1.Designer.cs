
namespace Lanterna
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
            this.components = new System.ComponentModel.Container();
            this.progBarBateria = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ptBLigada = new System.Windows.Forms.PictureBox();
            this.ptBDesligada = new System.Windows.Forms.PictureBox();
            this.btnTrocarB = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptBLigada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBDesligada)).BeginInit();
            this.SuspendLayout();
            // 
            // progBarBateria
            // 
            this.progBarBateria.Location = new System.Drawing.Point(277, 351);
            this.progBarBateria.Name = "progBarBateria";
            this.progBarBateria.Size = new System.Drawing.Size(256, 41);
            this.progBarBateria.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(67, 97);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(110, 41);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(360, 318);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(63, 13);
            this.lblDuracao.TabIndex = 2;
            this.lblDuracao.Text = "Bateria...0%";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(383, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // ptBLigada
            // 
            this.ptBLigada.Image = global::Lanterna.Properties.Resources.lanternaLigada;
            this.ptBLigada.Location = new System.Drawing.Point(245, 63);
            this.ptBLigada.Name = "ptBLigada";
            this.ptBLigada.Size = new System.Drawing.Size(288, 232);
            this.ptBLigada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBLigada.TabIndex = 6;
            this.ptBLigada.TabStop = false;
            this.ptBLigada.Visible = false;
            this.ptBLigada.WaitOnLoad = true;
            // 
            // ptBDesligada
            // 
            this.ptBDesligada.Image = global::Lanterna.Properties.Resources.lanternaDesligada;
            this.ptBDesligada.Location = new System.Drawing.Point(245, 63);
            this.ptBDesligada.Name = "ptBDesligada";
            this.ptBDesligada.Size = new System.Drawing.Size(288, 232);
            this.ptBDesligada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBDesligada.TabIndex = 5;
            this.ptBDesligada.TabStop = false;
            this.ptBDesligada.Visible = false;
            // 
            // btnTrocarB
            // 
            this.btnTrocarB.Location = new System.Drawing.Point(67, 191);
            this.btnTrocarB.Name = "btnTrocarB";
            this.btnTrocarB.Size = new System.Drawing.Size(110, 41);
            this.btnTrocarB.TabIndex = 8;
            this.btnTrocarB.Text = "Trocar Bateria";
            this.btnTrocarB.UseVisualStyleBackColor = true;
            this.btnTrocarB.Click += new System.EventHandler(this.btnTrocarB_Click);
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.AutoSize = true;
            this.lblStatusDesc.Location = new System.Drawing.Point(429, 21);
            this.lblStatusDesc.Name = "lblStatusDesc";
            this.lblStatusDesc.Size = new System.Drawing.Size(0, 13);
            this.lblStatusDesc.TabIndex = 9;
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(67, 144);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(110, 41);
            this.btnDesligar.TabIndex = 10;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 421);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.lblStatusDesc);
            this.Controls.Add(this.btnTrocarB);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.progBarBateria);
            this.Controls.Add(this.ptBLigada);
            this.Controls.Add(this.ptBDesligada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptBLigada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBDesligada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progBarBateria;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox ptBDesligada;
        private System.Windows.Forms.PictureBox ptBLigada;
        private System.Windows.Forms.Button btnTrocarB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Button btnDesligar;
    }
}


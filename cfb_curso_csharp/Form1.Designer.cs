
namespace CFB___Cursos___Aulas
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
            this.btn_canal = new System.Windows.Forms.Button();
            this.lb_linkcanal = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_canal
            // 
            this.btn_canal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_canal.Location = new System.Drawing.Point(15, 33);
            this.btn_canal.Name = "btn_canal";
            this.btn_canal.Size = new System.Drawing.Size(170, 23);
            this.btn_canal.TabIndex = 0;
            this.btn_canal.Text = "CFB - Cursos\r\n";
            this.btn_canal.UseVisualStyleBackColor = false;
            // 
            // lb_linkcanal
            // 
            this.lb_linkcanal.AutoSize = true;
            this.lb_linkcanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_linkcanal.Location = new System.Drawing.Point(12, 9);
            this.lb_linkcanal.Name = "lb_linkcanal";
            this.lb_linkcanal.Size = new System.Drawing.Size(173, 20);
            this.lb_linkcanal.TabIndex = 1;
            this.lb_linkcanal.Text = "youtube.com/cfbcursos";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(16, 63);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(169, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_linkcanal);
            this.Controls.Add(this.btn_canal);
            this.Name = "Form1";
            this.Text = "Curso de C# - CFB Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_canal;
        private System.Windows.Forms.Label lb_linkcanal;
        private System.Windows.Forms.TextBox tb_nome;
    }
}


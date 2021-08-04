
namespace Sistema
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.DgvCategoria = new System.Windows.Forms.DataGridView();
            this.BtnSair = new CustomControls.RJControls.BotaoCustomizado();
            this.BtnExcluir = new CustomControls.RJControls.BotaoCustomizado();
            this.BtnCadastrar = new CustomControls.RJControls.BotaoCustomizado();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.lbl_categoria.Location = new System.Drawing.Point(12, 18);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(80, 18);
            this.lbl_categoria.TabIndex = 13;
            this.lbl_categoria.Text = "Categoria";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.TxtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCategoria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.TxtCategoria.Location = new System.Drawing.Point(98, 16);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(234, 25);
            this.TxtCategoria.TabIndex = 14;
            // 
            // DgvCategoria
            // 
            this.DgvCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.DgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategoria.Location = new System.Drawing.Point(12, 115);
            this.DgvCategoria.Name = "DgvCategoria";
            this.DgvCategoria.RowTemplate.Height = 25;
            this.DgvCategoria.Size = new System.Drawing.Size(610, 254);
            this.DgvCategoria.TabIndex = 21;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.BtnSair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.BtnSair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSair.BorderRadius = 6;
            this.BtnSair.BorderSize = 0;
            this.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(242, 68);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(90, 25);
            this.BtnSair.TabIndex = 22;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextColor = System.Drawing.Color.White;
            this.BtnSair.UseVisualStyleBackColor = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.BtnExcluir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.BtnExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExcluir.BorderRadius = 6;
            this.BtnExcluir.BorderSize = 0;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(127, 68);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(90, 25);
            this.BtnExcluir.TabIndex = 23;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextColor = System.Drawing.Color.White;
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.BtnCadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.BtnCadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCadastrar.BorderRadius = 6;
            this.BtnCadastrar.BorderSize = 0;
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(12, 68);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(90, 25);
            this.BtnCadastrar.TabIndex = 24;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.TextColor = System.Drawing.Color.White;
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.DgvCategoria);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.lbl_categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frm_categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.DataGridView DgvCategoria;
        private CustomControls.RJControls.BotaoCustomizado BtnSair;
        private CustomControls.RJControls.BotaoCustomizado BtnExcluir;
        private CustomControls.RJControls.BotaoCustomizado BtnCadastrar;
    }
}
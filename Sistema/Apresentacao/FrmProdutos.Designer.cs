
namespace Sistema
{
    partial class FrmProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_excluir = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_sair = new CustomControls.RJControls.BotaoCustomizado();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.lbl_descricao.Location = new System.Drawing.Point(21, 15);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(80, 18);
            this.lbl_descricao.TabIndex = 0;
            this.lbl_descricao.Text = "Descrição";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txt_nome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txt_nome.Location = new System.Drawing.Point(107, 12);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(669, 25);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txt_valor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txt_valor.Location = new System.Drawing.Point(527, 56);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(134, 25);
            this.txt_valor.TabIndex = 3;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.lbl_valor.Location = new System.Drawing.Point(473, 59);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(48, 18);
            this.lbl_valor.TabIndex = 2;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.lbl_categoria.Location = new System.Drawing.Point(21, 59);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(80, 18);
            this.lbl_categoria.TabIndex = 4;
            this.lbl_categoria.Text = "Categoria";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.cmb_Categoria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(107, 56);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(344, 26);
            this.cmb_Categoria.TabIndex = 5;
            // 
            // DgvProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.DgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProdutos.EnableHeadersVisualStyles = false;
            this.DgvProdutos.Location = new System.Drawing.Point(21, 159);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.RowHeadersVisible = false;
            this.DgvProdutos.RowTemplate.Height = 25;
            this.DgvProdutos.Size = new System.Drawing.Size(755, 279);
            this.DgvProdutos.TabIndex = 10;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cadastrar.BorderRadius = 6;
            this.btn_cadastrar.BorderSize = 0;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(107, 101);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(130, 40);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.TextColor = System.Drawing.Color.White;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_excluir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_excluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_excluir.BorderRadius = 6;
            this.btn_excluir.BorderSize = 0;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(263, 101);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(130, 40);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextColor = System.Drawing.Color.White;
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_sair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_sair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sair.BorderRadius = 6;
            this.btn_sair.BorderSize = 0;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(416, 101);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(130, 40);
            this.btn_sair.TabIndex = 13;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextColor = System.Drawing.Color.White;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_descricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private CustomControls.RJControls.BotaoCustomizado btn_cadastrar;
        private CustomControls.RJControls.BotaoCustomizado btn_excluir;
        private CustomControls.RJControls.BotaoCustomizado btn_sair;
    }
}
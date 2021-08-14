
namespace Sistema
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_status_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_status_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cad_produto = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_cad_categoria = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_cad_cliente = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_consulta_produto = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_cad_venda = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_relatorio = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_sair = new CustomControls.RJControls.BotaoCustomizado();
            this.btn_cad_funcionario = new CustomControls.RJControls.BotaoCustomizado();
            this.btnCompra = new CustomControls.RJControls.BotaoCustomizado();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status_data,
            this.lbl_status_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 315);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status_data
            // 
            this.lbl_status_data.Name = "lbl_status_data";
            this.lbl_status_data.Size = new System.Drawing.Size(31, 17);
            this.lbl_status_data.Text = "Data";
            // 
            // lbl_status_hora
            // 
            this.lbl_status_hora.Name = "lbl_status_hora";
            this.lbl_status_hora.Size = new System.Drawing.Size(33, 17);
            this.lbl_status_hora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cad_produto
            // 
            this.btn_cad_produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_produto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_produto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cad_produto.BorderRadius = 6;
            this.btn_cad_produto.BorderSize = 0;
            this.btn_cad_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produto.FlatAppearance.BorderSize = 0;
            this.btn_cad_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_produto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cad_produto.ForeColor = System.Drawing.Color.White;
            this.btn_cad_produto.Location = new System.Drawing.Point(38, 33);
            this.btn_cad_produto.Name = "btn_cad_produto";
            this.btn_cad_produto.Size = new System.Drawing.Size(115, 75);
            this.btn_cad_produto.TabIndex = 10;
            this.btn_cad_produto.Text = "Cadastrar Produto";
            this.btn_cad_produto.TextColor = System.Drawing.Color.White;
            this.btn_cad_produto.UseVisualStyleBackColor = false;
            this.btn_cad_produto.Click += new System.EventHandler(this.btn_cad_produto_Click);
            // 
            // btn_cad_categoria
            // 
            this.btn_cad_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_categoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_categoria.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cad_categoria.BorderRadius = 6;
            this.btn_cad_categoria.BorderSize = 0;
            this.btn_cad_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categoria.FlatAppearance.BorderSize = 0;
            this.btn_cad_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_categoria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cad_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_cad_categoria.Location = new System.Drawing.Point(205, 33);
            this.btn_cad_categoria.Name = "btn_cad_categoria";
            this.btn_cad_categoria.Size = new System.Drawing.Size(115, 75);
            this.btn_cad_categoria.TabIndex = 11;
            this.btn_cad_categoria.Text = "Cadastrar Categoria";
            this.btn_cad_categoria.TextColor = System.Drawing.Color.White;
            this.btn_cad_categoria.UseVisualStyleBackColor = false;
            this.btn_cad_categoria.Click += new System.EventHandler(this.btn_cad_categoria_Click);
            // 
            // btn_cad_cliente
            // 
            this.btn_cad_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_cliente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cad_cliente.BorderRadius = 6;
            this.btn_cad_cliente.BorderSize = 0;
            this.btn_cad_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cad_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_cliente.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cad_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cad_cliente.Location = new System.Drawing.Point(532, 33);
            this.btn_cad_cliente.Name = "btn_cad_cliente";
            this.btn_cad_cliente.Size = new System.Drawing.Size(115, 75);
            this.btn_cad_cliente.TabIndex = 13;
            this.btn_cad_cliente.Text = "Cadastrar Cliente";
            this.btn_cad_cliente.TextColor = System.Drawing.Color.White;
            this.btn_cad_cliente.UseVisualStyleBackColor = false;
            this.btn_cad_cliente.Click += new System.EventHandler(this.btn_cad_cliente_Click);
            // 
            // btn_consulta_produto
            // 
            this.btn_consulta_produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_consulta_produto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_consulta_produto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_consulta_produto.BorderRadius = 6;
            this.btn_consulta_produto.BorderSize = 0;
            this.btn_consulta_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consulta_produto.FlatAppearance.BorderSize = 0;
            this.btn_consulta_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consulta_produto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consulta_produto.ForeColor = System.Drawing.Color.White;
            this.btn_consulta_produto.Location = new System.Drawing.Point(369, 143);
            this.btn_consulta_produto.Name = "btn_consulta_produto";
            this.btn_consulta_produto.Size = new System.Drawing.Size(115, 75);
            this.btn_consulta_produto.TabIndex = 14;
            this.btn_consulta_produto.Text = "Consultar Estoque";
            this.btn_consulta_produto.TextColor = System.Drawing.Color.White;
            this.btn_consulta_produto.UseVisualStyleBackColor = false;
            this.btn_consulta_produto.Click += new System.EventHandler(this.btn_consulta_produto_Click);
            // 
            // btn_cad_venda
            // 
            this.btn_cad_venda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_venda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_venda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cad_venda.BorderRadius = 6;
            this.btn_cad_venda.BorderSize = 0;
            this.btn_cad_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_venda.FlatAppearance.BorderSize = 0;
            this.btn_cad_venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_venda.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cad_venda.ForeColor = System.Drawing.Color.White;
            this.btn_cad_venda.Location = new System.Drawing.Point(38, 143);
            this.btn_cad_venda.Name = "btn_cad_venda";
            this.btn_cad_venda.Size = new System.Drawing.Size(115, 75);
            this.btn_cad_venda.TabIndex = 15;
            this.btn_cad_venda.Text = "Venda";
            this.btn_cad_venda.TextColor = System.Drawing.Color.White;
            this.btn_cad_venda.UseVisualStyleBackColor = false;
            this.btn_cad_venda.Click += new System.EventHandler(this.btn_cad_venda_Click);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_relatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_relatorio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_relatorio.BorderRadius = 6;
            this.btn_relatorio.BorderSize = 0;
            this.btn_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_relatorio.FlatAppearance.BorderSize = 0;
            this.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_relatorio.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_relatorio.ForeColor = System.Drawing.Color.White;
            this.btn_relatorio.Location = new System.Drawing.Point(532, 143);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(115, 75);
            this.btn_relatorio.TabIndex = 16;
            this.btn_relatorio.Text = "Relatório de Vendas";
            this.btn_relatorio.TextColor = System.Drawing.Color.White;
            this.btn_relatorio.UseVisualStyleBackColor = false;
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
            this.btn_sair.Location = new System.Drawing.Point(261, 248);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(169, 43);
            this.btn_sair.TabIndex = 17;
            this.btn_sair.Text = "Sair do Programa";
            this.btn_sair.TextColor = System.Drawing.Color.White;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_cad_funcionario
            // 
            this.btn_cad_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_funcionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cad_funcionario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cad_funcionario.BorderRadius = 6;
            this.btn_cad_funcionario.BorderSize = 0;
            this.btn_cad_funcionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_funcionario.FlatAppearance.BorderSize = 0;
            this.btn_cad_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_funcionario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cad_funcionario.ForeColor = System.Drawing.Color.White;
            this.btn_cad_funcionario.Location = new System.Drawing.Point(369, 33);
            this.btn_cad_funcionario.Name = "btn_cad_funcionario";
            this.btn_cad_funcionario.Size = new System.Drawing.Size(115, 75);
            this.btn_cad_funcionario.TabIndex = 18;
            this.btn_cad_funcionario.Text = "Cadastrar Funcionário";
            this.btn_cad_funcionario.TextColor = System.Drawing.Color.White;
            this.btn_cad_funcionario.UseVisualStyleBackColor = false;
            this.btn_cad_funcionario.Click += new System.EventHandler(this.btn_cad_funcionario_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnCompra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCompra.BorderRadius = 6;
            this.btnCompra.BorderSize = 0;
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompra.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.Location = new System.Drawing.Point(205, 143);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(115, 75);
            this.btnCompra.TabIndex = 19;
            this.btnCompra.Text = "Compra";
            this.btnCompra.TextColor = System.Drawing.Color.White;
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(684, 337);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btn_cad_funcionario);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.btn_cad_venda);
            this.Controls.Add(this.btn_consulta_produto);
            this.Controls.Add(this.btn_cad_cliente);
            this.Controls.Add(this.btn_cad_categoria);
            this.Controls.Add(this.btn_cad_produto);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status_data;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.BotaoCustomizado btn_cad_produto;
        private CustomControls.RJControls.BotaoCustomizado btn_cad_categoria;
        private CustomControls.RJControls.BotaoCustomizado btn_cad_cliente;
        private CustomControls.RJControls.BotaoCustomizado btn_consulta_produto;
        private CustomControls.RJControls.BotaoCustomizado btn_cad_venda;
        private CustomControls.RJControls.BotaoCustomizado btn_relatorio;
        private CustomControls.RJControls.BotaoCustomizado btn_sair;
        private CustomControls.RJControls.BotaoCustomizado btn_cad_funcionario;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status_hora;
        private CustomControls.RJControls.BotaoCustomizado btnCompra;
    }
}


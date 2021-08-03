
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
            this.btn_cad_produto = new System.Windows.Forms.Button();
            this.btn_cad_categoria = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_usuario = new System.Windows.Forms.Button();
            this.btn_cad_cliente = new System.Windows.Forms.Button();
            this.btn_consulta_produto = new System.Windows.Forms.Button();
            this.btn_cad_venda = new System.Windows.Forms.Button();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_status_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cad_produto
            // 
            this.btn_cad_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_produto.Location = new System.Drawing.Point(35, 78);
            this.btn_cad_produto.Name = "btn_cad_produto";
            this.btn_cad_produto.Size = new System.Drawing.Size(106, 79);
            this.btn_cad_produto.TabIndex = 0;
            this.btn_cad_produto.Text = "Cadastrar Produto";
            this.btn_cad_produto.UseVisualStyleBackColor = true;
            this.btn_cad_produto.Click += new System.EventHandler(this.btn_cad_produto_Click);
            // 
            // btn_cad_categoria
            // 
            this.btn_cad_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_categoria.Location = new System.Drawing.Point(202, 78);
            this.btn_cad_categoria.Name = "btn_cad_categoria";
            this.btn_cad_categoria.Size = new System.Drawing.Size(106, 79);
            this.btn_cad_categoria.TabIndex = 1;
            this.btn_cad_categoria.Text = "Cadastrar Categoria";
            this.btn_cad_categoria.UseVisualStyleBackColor = true;
            this.btn_cad_categoria.Click += new System.EventHandler(this.btn_cad_categoria_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.produtoToolStripMenuItem1.Text = "Produtos";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // btn_cad_usuario
            // 
            this.btn_cad_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_usuario.Location = new System.Drawing.Point(370, 78);
            this.btn_cad_usuario.Name = "btn_cad_usuario";
            this.btn_cad_usuario.Size = new System.Drawing.Size(106, 79);
            this.btn_cad_usuario.TabIndex = 3;
            this.btn_cad_usuario.Text = "Cadastrar Usuário";
            this.btn_cad_usuario.UseVisualStyleBackColor = true;
            this.btn_cad_usuario.Click += new System.EventHandler(this.btn_cad_usuario_Click);
            // 
            // btn_cad_cliente
            // 
            this.btn_cad_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_cliente.Location = new System.Drawing.Point(538, 78);
            this.btn_cad_cliente.Name = "btn_cad_cliente";
            this.btn_cad_cliente.Size = new System.Drawing.Size(106, 79);
            this.btn_cad_cliente.TabIndex = 4;
            this.btn_cad_cliente.Text = "Cadastrar Cliente";
            this.btn_cad_cliente.UseVisualStyleBackColor = true;
            this.btn_cad_cliente.Click += new System.EventHandler(this.btn_cad_cliente_Click);
            // 
            // btn_consulta_produto
            // 
            this.btn_consulta_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consulta_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consulta_produto.Location = new System.Drawing.Point(35, 201);
            this.btn_consulta_produto.Name = "btn_consulta_produto";
            this.btn_consulta_produto.Size = new System.Drawing.Size(106, 79);
            this.btn_consulta_produto.TabIndex = 5;
            this.btn_consulta_produto.Text = "Consultar Produtos";
            this.btn_consulta_produto.UseVisualStyleBackColor = true;
            // 
            // btn_cad_venda
            // 
            this.btn_cad_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_venda.Location = new System.Drawing.Point(202, 201);
            this.btn_cad_venda.Name = "btn_cad_venda";
            this.btn_cad_venda.Size = new System.Drawing.Size(106, 79);
            this.btn_cad_venda.TabIndex = 6;
            this.btn_cad_venda.Text = "Cadastrar Venda";
            this.btn_cad_venda.UseVisualStyleBackColor = true;
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_relatorio.Location = new System.Drawing.Point(370, 201);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(106, 79);
            this.btn_relatorio.TabIndex = 7;
            this.btn_relatorio.Text = "Relatório de vendas";
            this.btn_relatorio.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Location = new System.Drawing.Point(538, 201);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(106, 79);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair do programa";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status_data});
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status_data
            // 
            this.lbl_status_data.Name = "lbl_status_data";
            this.lbl_status_data.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 349);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.btn_cad_venda);
            this.Controls.Add(this.btn_consulta_produto);
            this.Controls.Add(this.btn_cad_cliente);
            this.Controls.Add(this.btn_cad_usuario);
            this.Controls.Add(this.btn_cad_categoria);
            this.Controls.Add(this.btn_cad_produto);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cad_produto;
        private System.Windows.Forms.Button btn_cad_categoria;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_usuario;
        private System.Windows.Forms.Button btn_cad_cliente;
        private System.Windows.Forms.Button btn_consulta_produto;
        private System.Windows.Forms.Button btn_cad_venda;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status_data;
        private System.Windows.Forms.Timer timer1;
    }
}


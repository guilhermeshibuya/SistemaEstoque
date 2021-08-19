
namespace Sistema.Apresentacao
{
    partial class FrmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstoque = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.btnAdcProd = new CustomControls.RJControls.BotaoCustomizado();
            this.btnVenda = new CustomControls.RJControls.BotaoCustomizado();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantEstoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoverProd = new CustomControls.RJControls.BotaoCustomizado();
            this.btnSair = new CustomControls.RJControls.BotaoCustomizado();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(130, 13);
            this.cmbFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(325, 26);
            this.cmbFuncionario.TabIndex = 1;
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(575, 13);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(325, 26);
            this.cmbCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(505, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // cmbEstoque
            // 
            this.cmbEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.cmbEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.cmbEstoque.FormattingEnabled = true;
            this.cmbEstoque.Location = new System.Drawing.Point(130, 70);
            this.cmbEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstoque.Name = "cmbEstoque";
            this.cmbEstoque.Size = new System.Drawing.Size(770, 26);
            this.cmbEstoque.TabIndex = 5;
            this.cmbEstoque.SelectedIndexChanged += new System.EventHandler(this.cmbEstoque_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(560, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txtQuantidade.Location = new System.Drawing.Point(654, 119);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(90, 25);
            this.txtQuantidade.TabIndex = 7;
            // 
            // lstProdutos
            // 
            this.lstProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.lstProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.lstProdutos.HideSelection = false;
            this.lstProdutos.Location = new System.Drawing.Point(16, 238);
            this.lstProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProdutos.MultiSelect = false;
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(884, 287);
            this.lstProdutos.TabIndex = 8;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstProdutos_ColumnWidthChanging);
            // 
            // btnAdcProd
            // 
            this.btnAdcProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnAdcProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnAdcProd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdcProd.BorderRadius = 6;
            this.btnAdcProd.BorderSize = 0;
            this.btnAdcProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdcProd.FlatAppearance.BorderSize = 0;
            this.btnAdcProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdcProd.ForeColor = System.Drawing.Color.White;
            this.btnAdcProd.Location = new System.Drawing.Point(131, 172);
            this.btnAdcProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdcProd.Name = "btnAdcProd";
            this.btnAdcProd.Size = new System.Drawing.Size(153, 43);
            this.btnAdcProd.TabIndex = 9;
            this.btnAdcProd.Text = "Adicionar produto";
            this.btnAdcProd.TextColor = System.Drawing.Color.White;
            this.btnAdcProd.UseVisualStyleBackColor = false;
            this.btnAdcProd.Click += new System.EventHandler(this.btnAdcProd_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnVenda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVenda.BorderRadius = 6;
            this.btnVenda.BorderSize = 0;
            this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenda.ForeColor = System.Drawing.Color.White;
            this.btnVenda.Location = new System.Drawing.Point(513, 172);
            this.btnVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(173, 43);
            this.btnVenda.TabIndex = 10;
            this.btnVenda.Text = "Realizar venda";
            this.btnVenda.TextColor = System.Drawing.Color.White;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txtValor.Location = new System.Drawing.Point(130, 119);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(137, 25);
            this.txtValor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(76, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor";
            // 
            // txtQuantEstoque
            // 
            this.txtQuantEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtQuantEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txtQuantEstoque.Location = new System.Drawing.Point(459, 119);
            this.txtQuantEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantEstoque.Name = "txtQuantEstoque";
            this.txtQuantEstoque.ReadOnly = true;
            this.txtQuantEstoque.Size = new System.Drawing.Size(90, 25);
            this.txtQuantEstoque.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.label6.Location = new System.Drawing.Point(277, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantidade em estoque";
            // 
            // btnRemoverProd
            // 
            this.btnRemoverProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnRemoverProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnRemoverProd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoverProd.BorderRadius = 6;
            this.btnRemoverProd.BorderSize = 0;
            this.btnRemoverProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverProd.FlatAppearance.BorderSize = 0;
            this.btnRemoverProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverProd.ForeColor = System.Drawing.Color.White;
            this.btnRemoverProd.Location = new System.Drawing.Point(322, 172);
            this.btnRemoverProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoverProd.Name = "btnRemoverProd";
            this.btnRemoverProd.Size = new System.Drawing.Size(153, 43);
            this.btnRemoverProd.TabIndex = 15;
            this.btnRemoverProd.Text = "Remover produto";
            this.btnRemoverProd.TextColor = System.Drawing.Color.White;
            this.btnRemoverProd.UseVisualStyleBackColor = false;
            this.btnRemoverProd.Click += new System.EventHandler(this.btnRemoverProd_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnSair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnSair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSair.BorderRadius = 6;
            this.btnSair.BorderSize = 0;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(727, 172);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(173, 43);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txtData.Location = new System.Drawing.Point(812, 119);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(88, 25);
            this.txtData.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(766, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Data";
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(914, 540);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRemoverProd);
            this.Controls.Add(this.txtQuantEstoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnAdcProd);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ListView lstProdutos;
        private CustomControls.RJControls.BotaoCustomizado btnAdcProd;
        private CustomControls.RJControls.BotaoCustomizado btnVenda;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantEstoque;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.BotaoCustomizado btnRemoverProd;
        private CustomControls.RJControls.BotaoCustomizado btnSair;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label7;
    }
}
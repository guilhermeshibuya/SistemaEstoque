
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(90, 13);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(121, 23);
            this.cmbFuncionario.TabIndex = 1;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(296, 13);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(125, 23);
            this.cmbCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // cmbEstoque
            // 
            this.cmbEstoque.FormattingEnabled = true;
            this.cmbEstoque.Location = new System.Drawing.Point(90, 60);
            this.cmbEstoque.Name = "cmbEstoque";
            this.cmbEstoque.Size = new System.Drawing.Size(427, 23);
            this.cmbEstoque.TabIndex = 5;
            this.cmbEstoque.SelectedIndexChanged += new System.EventHandler(this.cmbEstoque_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(637, 18);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidade.TabIndex = 7;
            // 
            // lstProdutos
            // 
            this.lstProdutos.HideSelection = false;
            this.lstProdutos.Location = new System.Drawing.Point(14, 158);
            this.lstProdutos.MultiSelect = false;
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(774, 280);
            this.lstProdutos.TabIndex = 8;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdcProd
            // 
            this.btnAdcProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdcProd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdcProd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdcProd.BorderRadius = 0;
            this.btnAdcProd.BorderSize = 0;
            this.btnAdcProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdcProd.FlatAppearance.BorderSize = 0;
            this.btnAdcProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdcProd.ForeColor = System.Drawing.Color.White;
            this.btnAdcProd.Location = new System.Drawing.Point(34, 103);
            this.btnAdcProd.Name = "btnAdcProd";
            this.btnAdcProd.Size = new System.Drawing.Size(134, 36);
            this.btnAdcProd.TabIndex = 9;
            this.btnAdcProd.Text = "Adicionar produto";
            this.btnAdcProd.TextColor = System.Drawing.Color.White;
            this.btnAdcProd.UseVisualStyleBackColor = false;
            this.btnAdcProd.Click += new System.EventHandler(this.btnAdcProd_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVenda.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVenda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVenda.BorderRadius = 0;
            this.btnVenda.BorderSize = 0;
            this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenda.ForeColor = System.Drawing.Color.White;
            this.btnVenda.Location = new System.Drawing.Point(270, 103);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(151, 36);
            this.btnVenda.TabIndex = 10;
            this.btnVenda.Text = "Realizar venda";
            this.btnVenda.TextColor = System.Drawing.Color.White;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(637, 61);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor";
            // 
            // txtQuantEstoque
            // 
            this.txtQuantEstoque.Location = new System.Drawing.Point(619, 111);
            this.txtQuantEstoque.Name = "txtQuantEstoque";
            this.txtQuantEstoque.ReadOnly = true;
            this.txtQuantEstoque.Size = new System.Drawing.Size(100, 23);
            this.txtQuantEstoque.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantidade em estoque";
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVenda";
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
    }
}
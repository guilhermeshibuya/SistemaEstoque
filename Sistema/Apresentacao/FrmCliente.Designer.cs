
namespace Sistema.Apresentacao
{
    partial class FrmCliente
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.btn_cadastrar_cliente = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.lbl_nome.Location = new System.Drawing.Point(53, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 18);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txt_nome.Location = new System.Drawing.Point(100, 26);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(247, 25);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.lbl_telefone.Location = new System.Drawing.Point(21, 130);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(72, 18);
            this.lbl_telefone.TabIndex = 2;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.lbl_cpf.Location = new System.Drawing.Point(61, 81);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(32, 18);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "CPF";
            // 
            // btn_cadastrar_cliente
            // 
            this.btn_cadastrar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btn_cadastrar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cadastrar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrar_cliente.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastrar_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar_cliente.Location = new System.Drawing.Point(100, 174);
            this.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente";
            this.btn_cadastrar_cliente.Size = new System.Drawing.Size(96, 32);
            this.btn_cadastrar_cliente.TabIndex = 6;
            this.btn_cadastrar_cliente.Text = "Cadastrar";
            this.btn_cadastrar_cliente.UseVisualStyleBackColor = false;
            this.btn_cadastrar_cliente.Click += new System.EventHandler(this.btn_cadastrar_cliente_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefone.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txt_telefone.Location = new System.Drawing.Point(100, 128);
            this.txt_telefone.Mask = "+99 (99) 99999-9999";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(158, 25);
            this.txt_telefone.TabIndex = 7;
            // 
            // txt_cpf
            // 
            this.txt_cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cpf.Culture = new System.Globalization.CultureInfo("en-US");
            this.txt_cpf.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.txt_cpf.Location = new System.Drawing.Point(100, 79);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(150, 25);
            this.txt_cpf.TabIndex = 8;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(375, 245);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.btn_cadastrar_cliente);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCliente";
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Button btn_cadastrar_cliente;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
    }
}
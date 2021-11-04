
namespace Projeto3Camadas.Ui
{
    partial class frmCadastroMotor
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txtEngResponsavel = new System.Windows.Forms.TextBox();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtvMotores = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtAnoFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMotores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(9, 63);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(49, 13);
            this.lbl_codigo.TabIndex = 4;
            this.lbl_codigo.Text = "CODIGO";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(129, 63);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(45, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "MARCA";
            // 
            // txtEngResponsavel
            // 
            this.txtEngResponsavel.Location = new System.Drawing.Point(376, 78);
            this.txtEngResponsavel.Margin = new System.Windows.Forms.Padding(2);
            this.txtEngResponsavel.Name = "txtEngResponsavel";
            this.txtEngResponsavel.Size = new System.Drawing.Size(213, 20);
            this.txtEngResponsavel.TabIndex = 9;
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Location = new System.Drawing.Point(373, 63);
            this.lblQuarto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(161, 13);
            this.lblQuarto.TabIndex = 8;
            this.lblQuarto.Text = "ENGENHEIRO RESPONSAVEL";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(131, 78);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(213, 20);
            this.txtMarca.TabIndex = 11;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(35, 112);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(163, 26);
            this.btn_Cadastrar.TabIndex = 12;
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(229, 112);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 26);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(425, 112);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(163, 26);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtvMotores
            // 
            this.dtvMotores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMotores.Location = new System.Drawing.Point(35, 159);
            this.dtvMotores.Margin = new System.Windows.Forms.Padding(2);
            this.dtvMotores.Name = "dtvMotores";
            this.dtvMotores.RowHeadersWidth = 62;
            this.dtvMotores.RowTemplate.Height = 28;
            this.dtvMotores.Size = new System.Drawing.Size(553, 151);
            this.dtvMotores.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // txtAnoFabricacao
            // 
            this.txtAnoFabricacao.Location = new System.Drawing.Point(244, 27);
            this.txtAnoFabricacao.Name = "txtAnoFabricacao";
            this.txtAnoFabricacao.Size = new System.Drawing.Size(100, 20);
            this.txtAnoFabricacao.TabIndex = 18;
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Location = new System.Drawing.Point(241, 11);
            this.lblAnoFabricacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(118, 13);
            this.lblAnoFabricacao.TabIndex = 17;
            this.lblAnoFabricacao.Text = "ANO DE FABRICAÇÃO";
            // 
            // frmCadastroMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 330);
            this.Controls.Add(this.txtAnoFabricacao);
            this.Controls.Add(this.lblAnoFabricacao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dtvMotores);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtEngResponsavel);
            this.Controls.Add(this.lblQuarto);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_codigo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastroMotor";
            this.Text = "Cadastro de Motor";
            ((System.ComponentModel.ISupportInitialize)(this.dtvMotores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txtEngResponsavel;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtvMotores;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtAnoFabricacao;
        private System.Windows.Forms.Label lblAnoFabricacao;
    }
}
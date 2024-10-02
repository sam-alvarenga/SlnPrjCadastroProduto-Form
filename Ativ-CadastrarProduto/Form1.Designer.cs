namespace Ativ_CadastrarProduto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCadastrarProduto = new Label();
            lblNomeProduto = new Label();
            lblUnidade = new Label();
            lblQuantidade = new Label();
            lblValorCusto = new Label();
            label1 = new Label();
            lblDescrição = new Label();
            txtNomeProduto = new TextBox();
            cBoxUnidade = new ComboBox();
            numericQuantidade = new NumericUpDown();
            txtCusto = new TextBox();
            txtVenda = new TextBox();
            txtDescricaoProduto = new TextBox();
            pictureProduto = new PictureBox();
            btnCadastrarProduto = new Button();
            btnAddImg = new Button();
            dataGridInfoProduto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridInfoProduto).BeginInit();
            SuspendLayout();
            // 
            // lblCadastrarProduto
            // 
            lblCadastrarProduto.AutoSize = true;
            lblCadastrarProduto.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastrarProduto.Location = new Point(302, 26);
            lblCadastrarProduto.Name = "lblCadastrarProduto";
            lblCadastrarProduto.Size = new Size(209, 24);
            lblCadastrarProduto.TabIndex = 0;
            lblCadastrarProduto.Text = "Cadastrar Produtos";
            lblCadastrarProduto.Click += lblCadastrarProduto_Click;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeProduto.Location = new Point(266, 85);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(151, 18);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Nome do Produto:";
            lblNomeProduto.Click += lblNomeProduto_Click;
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnidade.Location = new Point(266, 120);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(79, 18);
            lblUnidade.TabIndex = 2;
            lblUnidade.Text = "Unidade:";
            lblUnidade.Click += lblUnidade_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(266, 155);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(106, 18);
            lblQuantidade.TabIndex = 3;
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.Click += lblQuantidade_Click;
            // 
            // lblValorCusto
            // 
            lblValorCusto.AutoSize = true;
            lblValorCusto.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorCusto.Location = new Point(266, 193);
            lblValorCusto.Name = "lblValorCusto";
            lblValorCusto.Size = new Size(128, 18);
            lblValorCusto.TabIndex = 4;
            lblValorCusto.Text = "Valor de custo:";
            lblValorCusto.Click += lblValorCusto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 233);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 5;
            label1.Text = "Valor de Venda:";
            // 
            // lblDescrição
            // 
            lblDescrição.AutoSize = true;
            lblDescrição.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescrição.Location = new Point(266, 270);
            lblDescrição.Name = "lblDescrição";
            lblDescrição.Size = new Size(95, 18);
            lblDescrição.TabIndex = 6;
            lblDescrição.Text = "Descrição:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = SystemColors.Info;
            txtNomeProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeProduto.Location = new Point(453, 83);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(181, 25);
            txtNomeProduto.TabIndex = 7;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // cBoxUnidade
            // 
            cBoxUnidade.BackColor = SystemColors.Info;
            cBoxUnidade.FormattingEnabled = true;
            cBoxUnidade.Items.AddRange(new object[] { "Cx", "Unidade", "Litro" });
            cBoxUnidade.Location = new Point(453, 120);
            cBoxUnidade.Name = "cBoxUnidade";
            cBoxUnidade.Size = new Size(121, 23);
            cBoxUnidade.TabIndex = 9;
            cBoxUnidade.SelectedIndexChanged += cBoxUnidade_SelectedIndexChanged;
            // 
            // numericQuantidade
            // 
            numericQuantidade.BackColor = SystemColors.Info;
            numericQuantidade.Location = new Point(453, 156);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(120, 23);
            numericQuantidade.TabIndex = 10;
            numericQuantidade.ValueChanged += numericQuantidade_ValueChanged;
            // 
            // txtCusto
            // 
            txtCusto.BackColor = SystemColors.Info;
            txtCusto.Location = new Point(453, 193);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(180, 23);
            txtCusto.TabIndex = 11;
            txtCusto.TextChanged += txtCusto_TextChanged;
            // 
            // txtVenda
            // 
            txtVenda.BackColor = SystemColors.Info;
            txtVenda.Font = new Font("Segoe UI", 10F);
            txtVenda.Location = new Point(453, 231);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(180, 25);
            txtVenda.TabIndex = 12;
            txtVenda.TextChanged += txtVenda_TextChanged;
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.BackColor = SystemColors.Info;
            txtDescricaoProduto.Font = new Font("Segoe UI", 10F);
            txtDescricaoProduto.Location = new Point(452, 268);
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(181, 25);
            txtDescricaoProduto.TabIndex = 13;
            txtDescricaoProduto.TextChanged += txtDescricaoProduto_TextChanged;
            // 
            // pictureProduto
            // 
            pictureProduto.Image = (Image)resources.GetObject("pictureProduto.Image");
            pictureProduto.Location = new Point(44, 85);
            pictureProduto.Name = "pictureProduto";
            pictureProduto.Size = new Size(170, 202);
            pictureProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProduto.TabIndex = 14;
            pictureProduto.TabStop = false;
            pictureProduto.Click += pictureProduto_Click;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.BackColor = SystemColors.ButtonHighlight;
            btnCadastrarProduto.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarProduto.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrarProduto.Location = new Point(342, 327);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(151, 31);
            btnCadastrarProduto.TabIndex = 15;
            btnCadastrarProduto.Text = "Cadastrar Produto";
            btnCadastrarProduto.UseVisualStyleBackColor = false;
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
            // 
            // btnAddImg
            // 
            btnAddImg.BackColor = SystemColors.ButtonFace;
            btnAddImg.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddImg.ForeColor = SystemColors.ControlText;
            btnAddImg.Location = new Point(61, 302);
            btnAddImg.Name = "btnAddImg";
            btnAddImg.Size = new Size(135, 41);
            btnAddImg.TabIndex = 16;
            btnAddImg.Text = "Adicionar Imagem do Produto";
            btnAddImg.UseVisualStyleBackColor = false;
            btnAddImg.Click += btnAddImg_Click;
            // 
            // dataGridInfoProduto
            // 
            dataGridInfoProduto.BackgroundColor = SystemColors.Info;
            dataGridInfoProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInfoProduto.Location = new Point(44, 383);
            dataGridInfoProduto.Name = "dataGridInfoProduto";
            dataGridInfoProduto.Size = new Size(641, 133);
            dataGridInfoProduto.TabIndex = 17;
            dataGridInfoProduto.CellContentClick += dataGridInfoProduto_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 537);
            Controls.Add(dataGridInfoProduto);
            Controls.Add(btnAddImg);
            Controls.Add(btnCadastrarProduto);
            Controls.Add(pictureProduto);
            Controls.Add(txtDescricaoProduto);
            Controls.Add(txtVenda);
            Controls.Add(txtCusto);
            Controls.Add(numericQuantidade);
            Controls.Add(cBoxUnidade);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblDescrição);
            Controls.Add(label1);
            Controls.Add(lblValorCusto);
            Controls.Add(lblQuantidade);
            Controls.Add(lblUnidade);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCadastrarProduto);
            Name = "Form1";
            Text = "Cadastro de Produtos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridInfoProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastrarProduto;
        private Label lblNomeProduto;
        private Label lblUnidade;
        private Label lblQuantidade;
        private Label lblValorCusto;
        private Label label1;
        private Label lblDescrição;
        private TextBox txtNomeProduto;
        private ComboBox cBoxUnidade;
        private NumericUpDown numericQuantidade;
        private TextBox txtCusto;
        private TextBox txtVenda;
        private TextBox txtDescricaoProduto;
        private PictureBox pictureProduto;
        private Button btnCadastrarProduto;
        private Button btnAddImg;
        private DataGridView dataGridInfoProduto;
    }
}

namespace Ativ_CadastrarProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image fotoProduto;
        string nomeProduto;
        string unidade;
        string quantidade;
        string valorC;
        string valorV;
        string descricao;

        private void lblNomeProduto_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastrarProduto_Click(object sender, EventArgs e)
        {

        }

        private void lblUnidade_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValorCusto_Click(object sender, EventArgs e)
        {

        }

        private void txtVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog objImg = new OpenFileDialog();

            objImg.Filter = "Arquivo de Imagem(*.jpg;*.jpeg;.png) | *.jpg;*jpeg;*.png;";

            if (objImg.ShowDialog() == DialogResult.OK)
            {
                fotoProduto = Image.FromFile(objImg.FileName);

                pictureProduto.Image = fotoProduto;
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            nomeProduto = txtNomeProduto.Text;
            unidade = cBoxUnidade.Text;
            quantidade = numericQuantidade.Text;
            valorC = txtCusto.Text;
            valorV = txtVenda.Text;
            descricao = txtDescricaoProduto.Text;

            //Adicionando os produto em cada coluna 
            dataGridInfoProduto.Rows.Add(nomeProduto, unidade, quantidade, valorC, valorV, descricao);
        }

        private void txtDescricaoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridInfoProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridInfoProduto.Columns.Add("Produto", "Produto");
            dataGridInfoProduto.Columns.Add("Unidade", "Unidade");
            dataGridInfoProduto.Columns.Add("Quantidade", "Quantidade");
            dataGridInfoProduto.Columns.Add("Valor de Custo", "Valor de Custo");
            dataGridInfoProduto.Columns.Add("Valor de Venda", "Valor de Venda");
            dataGridInfoProduto.Columns.Add("Descrição", "Descrição");
        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }
    }
}

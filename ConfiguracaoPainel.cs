using EstatisticasBuscaEmprego.Modelos;

namespace EstatisticasBuscaEmprego
{
    public partial class formConfiguracaoPainel : Form
    {
        private DBHelper dBHelper = new DBHelper();
        private int indiceLinha;

        public formConfiguracaoPainel()
        {
            InitializeComponent();
        }

        private void formConfiguracaoPainel_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            string cmd = "Select * from ESTATISTICAS_STACK_VAGAS";
            IEnumerable<DadosPesquisarEstatistica> ret = dBHelper.ExecutarComando<DadosPesquisarEstatistica>(cmd);
            dgvPesquisar.DataSource = ret;
            dgvPesquisar.AutoGenerateColumns = true;
            dgvPesquisar.Columns["item_stack"].Width = 450;
            dgvPesquisar.Columns["tecnologia"].Width = 150;
            dgvPesquisar.Refresh();
            if (ret.Count() > 0)
                dgvPesquisar.Rows[indiceLinha].Selected = true;
        }

        private void atualizarGrid(int id)
        {
            string cmd = String.Format("Select * from ESTATISTICAS_STACK_VAGAS where id ={0}", id);
            IEnumerable<DadosPesquisarEstatistica> ret = dBHelper.ExecutarComando<DadosPesquisarEstatistica>(cmd);
            dgvPesquisar.DataSource = ret;
            dgvPesquisar.AutoGenerateColumns = true;
            dgvPesquisar.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != string.Empty)
            {
                int id = int.Parse(txtPesquisar.Text);
                atualizarGrid(id);
            }
        }

        private void dgvPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            txtAtualizarTecnologia.Text = dgvPesquisar.CurrentRow.Cells[1].Value.ToString();
            txtAtualizarItem.Text = dgvPesquisar.CurrentRow.Cells[2].Value.ToString();
            txtDelTecnologia.Text = dgvPesquisar.CurrentRow.Cells[1].Value.ToString();
            txtIDelItem.Text = dgvPesquisar.CurrentRow.Cells[2].Value.ToString();
            indiceLinha = dgvPesquisar.CurrentRow.Index;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cmd = String.Format("INSERT INTO ESTATISTICAS_STACK_VAGAS (tecnologia,item_stack) VALUES('{0}','{1}')",
                txtAddTecnologia.Text, txtAddItem.Text);
            dBHelper.ExecutarComando(cmd);
            atualizarGrid();
            MessageBox.Show("Item adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvPesquisar.CurrentRow.Cells[0].Value;
            string cmd = String.Format("UPDATE ESTATISTICAS_STACK_VAGAS SET tecnologia = '{0}', item_stack ='{1}' where id ={2}",
                txtAtualizarTecnologia.Text, txtAtualizarItem.Text, id);
            dBHelper.ExecutarComando(cmd);
            atualizarGrid();
            MessageBox.Show("Item atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = (int)dgvPesquisar.CurrentRow.Cells[0].Value;
                string cmd = String.Format("DELETE ESTATISTICAS_STACK_VAGAS where id ={0}", id);
                dBHelper.ExecutarComando(cmd);
                atualizarGrid();
                MessageBox.Show("Item deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
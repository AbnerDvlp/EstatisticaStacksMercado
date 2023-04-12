using EstatisticasBuscaEmprego.Modelos;

namespace EstatisticasBuscaEmprego
{
    public partial class index : Form
    {
        private int indiceLinha;
        private DBHelper dBHelper = new DBHelper();

        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            atualizarGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = (int)dgvPainel.CurrentRow.Cells[0].Value;
            int valorAtualizado = (int)dgvPainel.CurrentRow.Cells[3].Value + 1;
            string cmd = string.Format("Update ESTATISTICAS_STACK_VAGAS SET pontos = {0} where id ={1}", valorAtualizado, id);
            dBHelper.ExecutarComando(cmd);
            atualizarGrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            indiceLinha = dgvPainel.CurrentRow.Index;
        }

        private void atualizarGrid()
        {
            btnAdd.Enabled = false;
            btnRmv.Enabled = false;
            string cmd = "Select * from ESTATISTICAS_STACK_VAGAS";
            IEnumerable<Estatistica> ret = dBHelper.ExecutarComando<Estatistica>(cmd);
            dgvPainel.DataSource = ret;
            dgvPainel.AutoGenerateColumns = true;
            dgvPainel.Columns["item_stack"].Width = 300;
            dgvPainel.Columns["tecnologia"].Width = 150;
            dgvPainel.Refresh();

            if (ret.Count() > 0)
            {
                dgvPainel.Rows[indiceLinha].Selected = true;
                btnAdd.Enabled = true;
                btnRmv.Enabled = true;
            }
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            int id = (int)dgvPainel.CurrentRow.Cells[0].Value;
            int valorAtualizado = (int)dgvPainel.CurrentRow.Cells[3].Value - 1;

            string cmd = string.Format("Update ESTATISTICAS_STACK_VAGAS SET pontos = {0} where id ={1}", valorAtualizado, id);
            dBHelper.ExecutarComando(cmd);
            atualizarGrid();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            formConfiguracaoPainel formConfiguracaoPainel = new formConfiguracaoPainel();
            formConfiguracaoPainel.ShowDialog();
        }

        private void index_Activated(object sender, EventArgs e)
        {
            atualizarGrid();
        }
    }
}
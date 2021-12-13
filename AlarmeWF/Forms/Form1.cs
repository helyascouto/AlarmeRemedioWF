using AlarmeWF.Data;
using AlarmeWF.Model;

namespace AlarmeWF
{
    public partial class FrmAlarme : Form
    {
        ArquivoTxt arquivo = new ArquivoTxt();
        Alarme alarme = new Alarme();
        Label lbnId = new Label();
        TextBox txbId = new TextBox();
        Label lbnNomeRemedio = new Label();
        TextBox txbNomeRemedio = new TextBox();
        Label lbnHorario = new Label();
        TextBox txbHorario = new TextBox();


        public FrmAlarme()
        {
            InitializeComponent();
        }


        private void btnMais_Click(object sender, EventArgs e)
        {
            alarme.AdicionarHoras(mktHoras.Text);
            mktHoras.Text = "";
            mktHoras.Focus();
        }

        private void BotaoEnabilitado()
        {
            btnExcluir.Visible = true;
            btnLimpar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = true;
            btnAtualizar.Visible = true;
            btnEditar.Hide();
            btnSalvar.Hide();



        }

        private void BotaoDisabilitado()
        {
            btnExcluir.Hide();
            btnLimpar.Hide();
            btnExcluir.Hide();
            btnAtualizar.Hide();
            btnEditar.Visible = true;
            btnSalvar.Visible = true;

        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (alarme.retornaHoras() == string.Empty)
            {

                alarme.horarios = mktHoras.Text;
            }
            else
            {
                alarme.horarios = alarme.retornaHoras();
            }
            alarme.NomeRemedio = txbRemedio.Text;
            arquivo.EscreverArquivo(alarme);
            txbRemedio.Text = "";
            alarme.MostrarAlarme(dataGridView1);

        }


        private void tmRelogio_Tick(object sender, EventArgs e)
        {
            lbnHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            lbnData.Text = DateTime.Now.ToString("D");
        }

        private void tmVerificaHoras_Tick(object sender, EventArgs e)
        {
            arquivo.VerificaHoras();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            arquivo.VerificaHoras();
        }

        private void FrmAlarme_Load(object sender, EventArgs e)
        {
            arquivo.LerArquivo();
            alarme.MostrarAlarme(dataGridView1);
            BotaoDisabilitado();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                txbId.Text = row.Cells[0].Value.ToString();
                txbNomeRemedio.Text = row.Cells[1].Value.ToString();
                txbHorario.Text = row.Cells[2].Value.ToString();

            }
            else
            {
                txbId.Text = String.Empty;
                txbNomeRemedio.Text = String.Empty;
                txbHorario.Text = String.Empty;

            }

        }

        private void limparCampos()
        {
            txbId.Text = string.Empty;
            txbNomeRemedio.Text = string.Empty;
            txbHorario.Text = string.Empty;
        }



        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            BotaoEnabilitado();
            AbilitarPanel();
            this.Height = 400;

            lbnId.Location = new Point(0, 0);
            lbnId.Text = "Id:";
            txbId.Width = 50;
            txbId.Enabled = false;
            txbId.Text = "";
            txbId.Location = new Point(0, 25);


            lbnNomeRemedio.Location = new Point(0, 0);
            lbnNomeRemedio.Text = "Nome:";

            txbNomeRemedio.Text = "";
            txbNomeRemedio.Location = new Point(0, 25);
            txbNomeRemedio.Width = 140;


            lbnHorario.Location = new Point(0, 0);
            lbnHorario.Text = "Horario:";

            txbHorario.Text = "";
            txbHorario.Location = new Point(0, 25);
            txbHorario.Width = 140;



            panelID.Controls.Add(lbnId);
            panelID.Controls.Add(txbId);

            panelNome.Controls.Add(lbnNomeRemedio);
            panelNome.Controls.Add(txbNomeRemedio);

            panelHorario.Controls.Add(lbnHorario);
            panelHorario.Controls.Add(txbHorario);


        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                alarme = alarme.retornaAlarme(int.Parse(txbId.Text));
                if (alarme != null)
                {

                    alarme.atualizarAlarme(int.Parse(txbId.Text), txbNomeRemedio.Text, txbHorario.Text);
                    limparCampos();
                    alarme.MostrarAlarme(dataGridView1);

                }

                else
                {
                    MessageBox.Show("O Alarme não foi encontrado (404)!", "Alarme não encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            DesabilitarPanel();
            BotaoDisabilitado();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                alarme.id = int.Parse(txbId.Text);
                alarme = alarme.retornaAlarme(alarme.id);
                if (alarme == null)
                {
                    MessageBox.Show("O Alarme não foi encontrado (404)!", "Erro ao excluir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool retorno = alarme.excluirAlarme(alarme.id);
                if (retorno == true)
                {
                    alarme.MostrarAlarme(dataGridView1);

                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao executar a exclusão!", "Erro ao excluir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            DesabilitarPanel();
            BotaoDisabilitado();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void AbilitarPanel()
        {

            panelID.Visible = true;
            panelNome.Visible = true;
            panelHorario.Visible = true;
        }
        private void DesabilitarPanel()
        {
            panelID.Hide();
            panelNome.Hide();
            panelHorario.Hide();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            if (alarme.retornaHoras() == string.Empty)
            {

                alarme.horarios = row.Cells[2].Value.ToString();
            }
            else
            {
                alarme.horarios = alarme.retornaHoras();
            }
            alarme.NomeRemedio = row.Cells[1].Value.ToString();
            arquivo.EscreverArquivo(alarme);
            txbRemedio.Text = "";
            alarme.MostrarAlarme(dataGridView1);
        }
    }
}
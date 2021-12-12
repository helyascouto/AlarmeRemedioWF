using AlarmeWF.Data;
using AlarmeWF.Model;
using Timer = System.Threading.Timer;

namespace AlarmeWF
{
    public partial class FrmAlarme : Form
    {
        ArquivoTxt arquivo = new ArquivoTxt();
        Remedio remedio = new Remedio();
       
        public FrmAlarme()
        {
            InitializeComponent();
        }


        private void btnMais_Click(object sender, EventArgs e)
        {
            remedio.AdicionarHoras(mktHoras.Text);
            mktHoras.Text = "";
            mktHoras.Focus();
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            remedio.NomeRemedio = txbRemedio.Text;
            remedio.horas = remedio.retornaHoras();
            arquivo.EscreverArquivo(remedio);
            txbRemedio.Text = "";
  
        }

 
        private void btnImportar_Click(object sender, EventArgs e)
        {       
            arquivo.PopularDatagrid(dataGridView1);
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
        }
    }
}
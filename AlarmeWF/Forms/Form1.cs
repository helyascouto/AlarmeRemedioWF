using AlarmeWF.Data;
using AlarmeWF.Model;

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

            FrmAlarme frm = new FrmAlarme();
            frm.Refresh();
            txbRemedio.Text = "";
            mktHoras.Text = default;
        }

        private void FrmAlarme_Load(object sender, EventArgs e)
        {
            //arquivo.LerArquivo();
        }

       

        private void btnImportar_Click(object sender, EventArgs e)
        {
            arquivo.LerArquivo();
            arquivo.PopularDatagrid(dataGridView1);
           

        }
    }
}
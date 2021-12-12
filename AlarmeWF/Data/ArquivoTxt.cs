using AlarmeWF.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmeWF.Data
{
    internal class ArquivoTxt
    {
        StreamReader sr = new StreamReader(@"C:\Users\Elias Couto\source\repos\AlarmeWF\AlarmeWF\Data\Arquivo.txt");
        StreamWriter sw;
        Remedio remedio = new Remedio();
        List<string> listaDados = new List<string>();
        string linha, horas, texto;

        public void LerArquivo()
        {


            try
            {
                linha = sr.ReadLine();
                while (linha != null)
                {
                    remedio.horas = "";
                    string[] subs = linha.Split('-');
                    remedio.NomeRemedio = subs[0];
                    //listaDados.Add(subs[0]);

                    //remedio.horas = subs[1];

                    for (int i = 1; i < subs.Length; i++)
                    {

                        remedio.horas += "-" + subs[i];
                    }

                    listaDados.Add(remedio.NomeRemedio + remedio.horas);
                    //listaDados.Add(remedio.NomeRemedio + "-" + remedio.NomeRemedio);

                    linha = sr.ReadLine();


                }
                sr.Close();
                remedio.NomeRemedio = remedio.horas = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        public void EscreverArquivo(Remedio remedio)
        {

            try
            {

                sw = new StreamWriter(@"C:\Users\Elias Couto\source\repos\AlarmeWF\AlarmeWF\Data\Arquivo.txt");
                //remedio.horas = remedio.retornaHoras();
                listaDados.Add(remedio.NomeRemedio + remedio.horas);

                //foreach (string item in listaDados)
                //{
                
                for (int i = 0; i < listaDados.Count; i++)
                {
                    texto = "";
                    texto += listaDados[i];
                    sw.WriteLine(texto);
                    //texto += "-" + subs[i];
                }


                //}


                MessageBox.Show("Alarme cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Close();
            }

        }
        public void PopularDatagrid(DataGridView dataGridView)
        {
        
            //dataGridView.DataSource = listaDados.Select(x => new { Value = x }).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("column name");

            dt.Rows.Add(new object[] { "Item 1" });
            dt.Rows.Add(new object[] { "Item 2" });
            dt.Rows.Add(new object[] { "Item 3" });
        }

    }
}

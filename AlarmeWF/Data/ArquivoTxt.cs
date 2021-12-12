using AlarmeWF.Model;
using System;
using System.Collections.Generic;
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
            linha = sr.ReadLine();

            try
            {
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

                sw = new StreamWriter(@"C:\Users\Elias Couto\source\repos\AlarmeWF\AlarmeWF\Data\Arquivo2.txt");
                //remedio.horas = remedio.retornaHoras();
                listaDados.Add(remedio.NomeRemedio + remedio.horas);

                foreach (string item in listaDados)
                {

                    for (int i = 0; i < listaDados.Count; i++)
                    {
                        texto = "";
                        texto += listaDados[i];
                        sw.WriteLine(texto);
                        //texto += "-" + subs[i];
                    }


                }


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

    }
}

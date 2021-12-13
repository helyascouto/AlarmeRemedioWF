using AlarmeWF.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmeWF.Data
{
    internal class ArquivoTxt
    {
        StreamReader sr = new StreamReader(@"C:\Users\Elias Couto\source\repos\AlarmeWF\AlarmeWF\Data\Arquivo.txt");
        StreamWriter sw;
        Alarme remedio = new Alarme();
        List<string> listaDados = new List<string>();
        string linha, horas, texto;

        public void LerArquivo()
        {

            try
            {
                linha = sr.ReadLine();
                while (linha != null)
                {
                    remedio.horarios = "";
                    string[] subs = linha.Split('-');
                    remedio.NomeRemedio = subs[0];

                    for (int i = 1; i < subs.Length; i++)
                    {

                        remedio.horarios += "-" + subs[i];
                    }

                    listaDados.Add(remedio.NomeRemedio + remedio.horarios);
                    
                    linha = sr.ReadLine();


                }
                remedio.NomeRemedio = remedio.horarios = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();

            }


        }

        public void EscreverArquivo(Alarme remedio)
        {

            try
            {

                sw = new StreamWriter(@"C:\Users\Elias Couto\source\repos\AlarmeWF\AlarmeWF\Data\Arquivo.txt");
                listaDados.Add(remedio.NomeRemedio + remedio.horarios);

                for (int i = 0; i < listaDados.Count; i++)
                {
                    texto = "";
                    texto += listaDados[i];
                    sw.WriteLine(texto);
                }
                remedio.gravarAlarmes();

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

        public void VerificaHoras()
        {
            string horario = DateTime.Now.ToString("HH:mm");
            for (int i = 0; i < listaDados.Count; i++)
            {
                if (listaDados[i].Contains(horario))
                {
                    MessageBox.Show(listaDados[i],"Hora do remedinho!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
               
        }

    }
}

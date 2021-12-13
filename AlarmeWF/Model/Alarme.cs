using AlarmeWF.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmeWF.Model
{
    internal class Alarme
    {
        public int id { get; set; }
        public string NomeRemedio { get; set; }
        public string horarios { get; set; }

        string texto = "";

        public Alarme()
        {

        }
        public Alarme(int id, string nomeRemedio, string horarios)
        {
            this.id = id;
            NomeRemedio = nomeRemedio;
            this.horarios = horarios;
        }

        public void AdicionarHoras(string hora)
        {
            horarios = "-" + hora;
            texto += horarios;
        }
        public string retornaHoras()
        {
            return texto;
        }
        public bool gravarAlarmes()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = " insert into Alarme values (@nome, @fk_horarios)";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@fk_horarios", SqlDbType.VarChar);
            command.Parameters[0].Value = this.NomeRemedio;
            command.Parameters[1].Value = this.horarios;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();

                return false;
            }

            finally
            {
                bd.fecharConexao();
            }

        }
        public void MostrarAlarme(DataGridView dataGridView)
        {
            try
            {
                Banco db = new Banco();
                string sql = "select * from Alarme";

                DataTable dt = new DataTable();
                dt = db.executarColsultaGenerica(sql);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public bool excluirAlarme(int ID)
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Alarme where id = @id";
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters[0].Value = ID;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();

                return false;
            }

            finally
            {
                bd.fecharConexao();
            }
        }

        public bool atualizarAlarme(int _id, string _nomeRemedio, string _horario)
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update Alarme set nome=@nome,horarios= @horarios where id = @id";
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@horarios", SqlDbType.VarChar);

            command.Parameters[0].Value = _id;
            command.Parameters[1].Value = _nomeRemedio;
            command.Parameters[2].Value = _horario;


            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Alarme Atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();

                return false;
            }

            finally
            {
                bd.fecharConexao();
            }

        }

        private void MostrarAlarme(object dataGridView1)
        {
            throw new NotImplementedException();
        }

        public Alarme retornaAlarme(int id)
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("SELECT * from Alarme", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        id = reader.GetInt32(0);
                        NomeRemedio = reader.GetString(1);
                        horarios = reader.GetString(2);

                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}

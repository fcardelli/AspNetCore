using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBasico
{
    public partial class CadastraCliente : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = CrudBasico; Data Source = localhost;";
        private string strSql = string.Empty;
        public CadastraCliente()
        {
            InitializeComponent();

            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtCpf.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtCpf.Enabled = true;
            txtTelefone.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO Cliente VALUES (" +
                                                    "@Nome, " +
                                                    "@Email," +
                                                    "@Cpf," +
                                                    "@Telefone" +
                                                    ")";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = txtCpf.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                LimpaCampos();
            }

        }
        private void LimpaCampos()
        {
            lblId.Text = String.Empty;
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            strSql = "UPDATE Cliente SET Nome = @Nome, Email = @Email, Cpf = @Cpf, Telefone = @Telefone WHERE Id = @Id";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(lblId.Text);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = txtCpf.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                LimpaCampos();
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (!txtNome.Enabled)
            {

                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtCpf.Enabled = true;
                txtTelefone.Enabled = true;

            }
            else
            {
                strSql = "SELECT TOP 1 Id, Nome, Email, Cpf, Telefone FROM Cliente WHERE Nome = @Nome";

                sqlCon = new SqlConnection(strCon);

                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;

                try
                {
                    if (txtNome.Text == string.Empty)
                    {
                        MessageBox.Show("Favor preencher o campo nome para realizar a pesquisa.");
                    }

                    sqlCon.Open();

                    SqlDataReader dataReader = comando.ExecuteReader();

                    if (dataReader.HasRows == false)
                    {
                        throw new Exception("Nome não encontrado.");
                    }

                    dataReader.Read();

                    lblId.Text = Convert.ToString(dataReader["Id"]);
                    txtNome.Text = Convert.ToString(dataReader["Nome"]);
                    txtEmail.Text = Convert.ToString(dataReader["Email"]);
                    txtCpf.Text = Convert.ToString(dataReader["Cpf"]);
                    txtTelefone.Text = Convert.ToString(dataReader["Telefone"]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM Cliente WHERE Id = @Id";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = lblId.Text;

            try
            {
                if (lblId.Text == String.Empty)
                {
                    MessageBox.Show("É necessário pesquisar primeiro um registro para excluir.");
                }
                else
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro de Cliente excluido com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                LimpaCampos();
            }
        }
    }
}

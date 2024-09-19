using MySql.Data.MySqlClient;

namespace Funcionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();

                    cadFuncionarios.Name = txtNome.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Cpf = txtCPF.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcion�rio {cadFuncionarios.Name} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();


                    }
                    else
                    {
                        MessageBox.Show("N�o foi possivel cadastrar Funcion�rio!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preecher todos os campos corretamente!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();

                    txtNome.Focus();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar funcion�rio: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Cpf = txtCPF.Text;

                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblid.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcion�rio n�o encontrado");
                            txtNome.Clear();
                            txtEmail.Clear();
                            txtCPF.Clear();
                            txtEndereco.Clear();
                            txtCPF.Focus();
                            lblid.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcion�rio n�o encontrado");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                        lblid.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CPF para realizar a pesquisa!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                    lblid.Text = "";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao encontrar funcion�rio: " + ex.Message);


            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtNome.Focus();
            lblid.Text = "";

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblid.Text);
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("Os dados do funcion�rio foram atualizados com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtCPF.Focus();
                        lblid.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("N�o foi possivel atulizar as informa��es do funcion�rio");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtCPF.Focus();
                        lblid.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcion�rio que deseja atualizar as informa��es");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    txtCPF.Focus();
                    lblid.Text = "";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar dados do funcion�rio: " + ex.Message);
                txtNome.Clear();
                txtEmail.Clear();
                txtCPF.Clear();
                txtEndereco.Clear();
                txtCPF.Focus();
                lblid.Text = "";
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblid.Text);

                    if(cadFuncionarios.deletarFuncionario())
                    {
                        MessageBox.Show("O funcionario foi excluido com sucesso");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                        lblid.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("N�o foi possivel excluir funcion�rio");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblid.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar qual funcion�rio deseja excluir");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    lblid.Text = "";
                    txtCPF.Focus();
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ao excluir funcion�rios: " + ex.Message); 
            }
        }
    }

}

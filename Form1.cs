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
                        MessageBox.Show($"O funcionário {cadFuncionarios.Name} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();


                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar Funcionário!");
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

                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
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
                            MessageBox.Show("Funcionário não encontrado");
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
                        MessageBox.Show("Funcionário não encontrado");
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

                MessageBox.Show("Erro ao encontrar funcionário: " + ex.Message);


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
                        MessageBox.Show("Os dados do funcionário foram atualizados com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtCPF.Focus();
                        lblid.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel atulizar as informações do funcionário");
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
                    MessageBox.Show("Favor localizar o funcionário que deseja atualizar as informações");
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

                MessageBox.Show("Erro ao atualizar dados do funcionário: " + ex.Message);
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
                        MessageBox.Show("Não foi possivel excluir funcionário");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblid.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar qual funcionário deseja excluir");
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

                MessageBox.Show("Error ao excluir funcionários: " + ex.Message); 
            }
        }
    }

}

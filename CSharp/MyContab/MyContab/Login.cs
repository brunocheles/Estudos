using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContab
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTNLogar_Click(object sender, EventArgs e)
        {
            if (TBUsuario.Text == "" || TBSenha.Text == "")
            {
                MessageBox.Show("Usuário ou senha vazios!\nPor favor, preencha os campos para acessar!", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TBSenha.Clear();
                TBUsuario.Focus();
            }else
            {
                DataBase con = new DataBase();

                try
                {
                    con.connect();

                    string sql = "SELECT * FROM usuarios_tb WHERE usuario = '" + TBUsuario.Text + "' AND senha = '" + TBSenha.Text + "'";

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                    DataTable dt = new DataTable();

                    dataAdapter.Fill(dt); //Passando os dados de retorno do DataAdapter para o DataTable

                    if(dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Dados de usuário inválidos!", "Erro ao realizar Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TBSenha.Clear();
                        TBUsuario.Focus();
                    }else
                    {
                        string nome = dt.Rows[0]["nome"].ToString();
                        string sobrenome = dt.Rows[0]["sobrenome"].ToString();

                        MessageBox.Show("Bem-vindo(a) " + nome + " " + sobrenome + "!", "Login realizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);

                        TBUsuario.Clear();
                        TBSenha.Clear();

                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Closed += (s, args) => this.Close(); ;
                        mainForm.Show();
                    }
                    con.disconnect();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBUsuario.Clear();
                    TBSenha.Clear();
                }
            }
        }
    }
}

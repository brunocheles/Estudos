using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UpdateAno();
            string anoAtual = this.CBAno.SelectedValue.ToString();

            UpdateMes(anoAtual);
            string numMes = NumMes(this.CBMes.SelectedValue.ToString());

            UpdateAtivos(anoAtual, numMes);
            UpdatePassivos(anoAtual, numMes);
            AtualizaValorMes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoAtivo novoAtivo = new NovoAtivo();

            novoAtivo.ShowDialog();
        }

        private void BTNAddPassivo_Click(object sender, EventArgs e)
        {
            NovoPassivo novoPassivo= new NovoPassivo();

            novoPassivo.ShowDialog();
        }

        private void BTNAtivarAnoMes_Click(object sender, EventArgs e)
        {
            ActiveForm activeForm = new ActiveForm();

            this.Hide();

            activeForm.ShowDialog();

            this.Show();
        }

        private void UpdateAno() // Atualiza os anos ativos
        {
            DataBase con = new DataBase();

            try
            {
                con.connect();

                string sql = "SELECT * FROM ano_tb WHERE situacao = 'A'";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);

                if (ds.Tables.Count <= 0)
                {
                    MessageBox.Show("Sem ano ativo!\nPor favor, ative um novo ano.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    con.disconnect();
                }
                else
                {
                    this.CBAno.DataSource = ds.Tables[0];
                    this.CBAno.DisplayMember = "ano";
                    this.CBAno.ValueMember = "ano";
                }
                con.disconnect();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateMes(string ano) // Atualiza os meses ativos daquele ano
        {
            DataBase con = new DataBase();

            try
            {
                con.connect();

                string sql = "SELECT * FROM meses_tb WHERE situacao = 'A' AND ano = '" + ano + "'";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    this.CBMes.DataSource = ds.Tables[0];
                    this.CBMes.DisplayMember = "mes";
                    this.CBMes.ValueMember = "mes";
                }
                con.disconnect();
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private string NumMes(string nomeMes)// Pega o número do mês pelo nome
        {
            string mesAtual;

            switch (nomeMes)
            {
                case "Janeiro":
                    mesAtual = "01";
                    break;
                case "Fevereiro":
                    mesAtual = "02";
                    break;
                case "Março":
                    mesAtual = "03";
                    break;
                case "Abril":
                    mesAtual = "04";
                    break;
                case "Maio":
                    mesAtual = "05";
                    break;
                case "Junho":
                    mesAtual = "06";
                    break;
                case "Julho":
                    mesAtual = "07";
                    break;
                case "Agosto":
                    mesAtual = "08";
                    break;
                case "Setembro":
                    mesAtual = "09";
                    break;
                case "Outubro":
                    mesAtual = "10";
                    break;
                case "Novembro":
                    mesAtual = "11";
                    break;
                case "Dezembro":
                    mesAtual = "12";
                    break;
                default:
                    mesAtual = "99";
                    break;
            }
            return mesAtual;
        }

        private void UpdateAtivos(string ano, string mes) // Atualiza a lista de ativos
        {
            DataBase con = new DataBase();

            try
            {
                con.connect();

                LBLSomaAtivos.Text = "";
                LVAtivos.Items.Clear();

                string sql = "SELECT * FROM ativos_tb WHERE ano_mes = '" + ano + mes + "'";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);

                double somaValores = 0.0;
                if (ds.Tables.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        LVAtivos.Items.Add(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                        LVAtivos.Items[i].SubItems.Add(ds.Tables[0].Rows[i].ItemArray[3].ToString());

                        somaValores += Convert.ToDouble(LVAtivos.Items[i].SubItems[1].Text);
                    }

                    LBLSomaAtivos.Text = "R$ " + somaValores.ToString();
                }else
                {
                    LBLSomaAtivos.Text = "R$ 0";
                }
                con.disconnect();
                return;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdatePassivos(string ano, string mes) //Atualiza a lista de passivos
        {
            DataBase con = new DataBase();

            try
            {
                con.connect();

                LBLSomaPassivos.Text = "";
                LVPassivos.Items.Clear();

                string sql = "SELECT * FROM passivos_tb WHERE ano_mes = '" + ano + mes + "'";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);

                double somaValores = 0.0;
                if (ds.Tables.Count > 0)
                {
                    int i;
                    for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        LVPassivos.Items.Add(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                        LVPassivos.Items[i].SubItems.Add(ds.Tables[0].Rows[i].ItemArray[3].ToString());

                        somaValores += Convert.ToDouble(LVPassivos.Items[i].SubItems[1].Text);
                    }

                    LBLSomaPassivos.Text = "R$ " + somaValores.ToString();
                }else
                {
                    LBLSomaPassivos.Text = "R$ 0";
                }
                con.disconnect();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AtualizaValorMes()
        {
            double somaTotal;

            if(LBLSomaAtivos.Text.Length > 0)
            {
                somaTotal = Convert.ToDouble(LBLSomaAtivos.Text.Substring(2, LBLSomaAtivos.Text.Length - 2));
                somaTotal -= Convert.ToDouble(LBLSomaPassivos.Text.Substring(2, LBLSomaPassivos.Text.Length - 2));

                LBLSomaTotal.Text = "R$ " + somaTotal.ToString();
            }else
            {
                LBLSomaTotal.Text = "R$ 0";
            }
        }

        private void CBMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string anoAtual = CBAno.SelectedValue.ToString();
            string numMes = NumMes(CBMes.SelectedValue.ToString());

            UpdateAtivos(anoAtual, numMes);
            UpdatePassivos(anoAtual, numMes);
            AtualizaValorMes();
        }

        private void CBAno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string anoAtual = CBAno.SelectedValue.ToString();
            string numMes = NumMes(CBMes.SelectedValue.ToString());

            UpdateAtivos(anoAtual, numMes);
            UpdatePassivos(anoAtual, numMes);
            AtualizaValorMes();
        }
    }
}

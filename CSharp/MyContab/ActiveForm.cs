using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContab
{
    public partial class ActiveForm : Form
    {
        bool ignoreEvent = true;
        DataBase con = new DataBase();
        SQLiteTransaction transaction;
        public ActiveForm()
        {
            InitializeComponent();
            //con.connect();
            //transaction = con.beginTran();

            NUDAnoAtivo.Value = Convert.ToInt32(DateTime.Today.Year);
            AtualizaAnosAtivos();
            AtualizaMesesAtivos();
            ignoreEvent = false;
            con.disconnect();
        }

        private void NUDAnoAtivo_ValueChanged(object sender, EventArgs e)
        {
            AtualizaAtivarAnos();
            AtualizaMesesAtivos();
        }

        private void BTNHabilitar_Click(object sender, EventArgs e)
        {
            string nudAno = this.NUDAnoAtivo.Value.ToString();

            try
            {
                con.connect();
                string sql = "INSERT INTO ano_tb(ano, situacao) VALUES(" + nudAno + ", 'A')";

                con.insertOrUpdate(sql);

                AtualizaAtivarAnos();
                AtualizaAnosAtivos();
                AtualizaMesesAtivos();

                con.disconnect();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizaAnosAtivos()
        {
            try
            {
                con.connect();
                LVAnosAtivos.Items.Clear();

                string sql = "SELECT ano FROM ano_tb WHERE situacao = 'A' ORDER BY ano DESC";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    LVAnosAtivos.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    //LVAnosAtivos.Items[i].SubItems.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                }
                con.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizaAtivarAnos()
        {
            string nudAno = this.NUDAnoAtivo.Value.ToString();

            try
            {
                con.connect();
                string sql = "SELECT ano, situacao FROM ano_tb WHERE ano =" + nudAno;

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);

                string sit = ds.Tables[0].Rows[0].ItemArray[1].ToString();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    BTNHabilitar.Enabled = false;
                    RBAtivarAno.Enabled = true;
                    RBDesativarAno.Enabled = true;

                    if (sit == "A") //Atualiza o RadioButton de acordo com situacao do ano
                    {
                        AtualizaRadioButton("Active", false);
                    }
                    else
                    {
                        AtualizaRadioButton("Inactive", false);
                    }
                }
                con.disconnect();
                return;
            }
            catch (Exception)
            {
                BTNHabilitar.Enabled = true;
                RBAtivarAno.Enabled = false;
                RBDesativarAno.Enabled = false;
            }
        }

        /*
        private void RBDesativarAno_CheckedChanged(object sender, EventArgs e)
        {

            if (!ignoreEvent)
            {
                if (RBDesativarAno.Checked)
                {
                    AtualizaRadioButton("I", true);
                }
            }
        }

        private void RBAtivarAno_CheckedChanged(object sender, EventArgs e)
        {
            if (!ignoreEvent)
            {

            }
        }
                */

        private void AtualizaRadioButton(string cmd, bool clk)
        {
            string nudAno = this.NUDAnoAtivo.Value.ToString();
            string sql;

            if (clk)
            {
                try
                {
                    con.connect();
                    sql = "UPDATE ano_tb SET situacao = '" + cmd + "' WHERE ano =" + nudAno;

                    con.insertOrUpdate(sql);

                    AtualizaAtivarAnos();
                    AtualizaAnosAtivos();
                    AtualizaMesesAtivos();
                    con.disconnect();
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Está chegando aqui!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (cmd == "Active")
                {
                    RBAtivarAno.Checked = true;
                }
                else
                {
                    RBDesativarAno.Checked = true;
                }
            }
        }

        private void RBAtivarAno_Click(object sender, EventArgs e)
        {
            if (RBAtivarAno.Checked)
            {
                AtualizaRadioButton("A", true);
            }
        }

        private void RBDesativarAno_Click(object sender, EventArgs e)
        {
            if (RBDesativarAno.Checked)
            {
                AtualizaRadioButton("I", true);
            }
        }

        private void AtualizaMesesAtivos()
        {
            string nudAno = this.NUDAnoAtivo.Value.ToString();
            
            try
            {
                con.connect();
                string sql = "SELECT ano, situacao FROM ano_tb WHERE ano =" + nudAno;

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);

                string sit = ds.Tables[0].Rows[0].ItemArray[1].ToString();

                foreach (CheckBox cont in GBMesesAtivos.Controls)
                {
                    if (sit == "A")
                    {
                        cont.Enabled = true;
                        cont.Checked = false;
                    }
                    else
                    {
                        cont.Enabled = false;
                        cont.Checked = false;
                    }                  
                }
                sql = "SELECT mes FROM meses_tb WHERE ano = " + nudAno + " AND situacao = 'A'";

                SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
                DataSet ds2 = new DataSet();

                da2.Fill(ds2);

                //MessageBox.Show(ds2.Tables[0].Rows[1].ItemArray[0].ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                for (int i = 0; i < ds2.Tables[0].Rows.Count;i++)
                {
                    switch (ds2.Tables[0].Rows[i].ItemArray[0].ToString())
                    {
                        case "Janeiro":
                            CBJaneiro.Checked = true;
                            break;
                        case "Fevereiro":
                            CBFevereiro.Checked = true;
                            break;
                        case "Março":
                            CBMarço.Checked = true;
                            break;
                        case "Abril":
                            CBAbril.Checked = true;
                            break;
                        case "Maio":
                            CBMaio.Checked = true;
                            break;
                        case "Junho":
                            CBJunho.Checked = true;
                            break;
                        case "Julho":
                            CBJulho.Checked = true;
                            break;
                        case "Agosto":
                            CBAgosto.Checked = true;
                            break;
                        case "Setembro":
                            CBSetembro.Checked = true;
                            break;
                        case "Outubro":
                            CBOutubro.Checked = true;
                            break;
                        case "Novembro":
                            CBNovembro.Checked = true;
                            break;
                        case "Dezembro":
                            CBDezembro.Checked = true;
                            break;
                        default:
                            MessageBox.Show(ds2.Tables[0].Rows[i].ItemArray[0].ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                con.disconnect();
            }
            catch
            {
                return;
            }
        }

        private void CBMesClicked(object sender, EventArgs e)
        {
            con.connect();
            Functions fn = new Functions();

            string nudAno = this.NUDAnoAtivo.Value.ToString();
            string ChBox = ((((CheckBox)sender).Name).ToString()).Substring(2);
            string sql = "SELECT ano_mes, mes, situacao FROM meses_tb WHERE ano =" + nudAno + " ORDER BY ano_mes ASC";

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.conn); //Executando a consulta no banco de dados
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            string[] mesesAtivos = new string[ds.Tables[0].Rows.Count];
            int i = 0;

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    mesesAtivos[i] = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    i++;
                }
            }
            switch (ChBox)
            {
                case "Janeiro":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos,nudAno,"01");
                    break;
                case "Fevereiro":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "02");
                    break;
                case "Março":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "03");
                    break;
                case "Abril":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "04");
                    break;
                case "Maio":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "05");
                    break;
                case "Junho":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "06");
                    break;
                case "Julho":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "07");
                    break;
                case "Agosto":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "08");
                    break;
                case "Setembro":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "09");
                    break;
                case "Outubro":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "10");
                    break;
                case "Novembro":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "11");
                    break;
                case "Dezembro":
                    fn.checkBoxActive((CheckBox)sender, mesesAtivos, nudAno, "12");
                    break;
                default:
                    MessageBox.Show(ChBox, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            con.disconnect();
        }

        private void BTNConfirmarAnoMes_Click(object sender, EventArgs e)
        {
            //con.connect();
            //con.commitTran(transaction);
            //con.disconnect();
            this.DialogResult = DialogResult.OK;
        }

        private void BTNCancelarAnoMes_Click(object sender, EventArgs e)
        {
           // con.connect();
           // con.rollbackTran(transaction);
           // con.disconnect();
            this.DialogResult = DialogResult.OK;
        }
    }
}

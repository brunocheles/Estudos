using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContab
{
    internal class Functions
    {
        public void checkBoxActive(CheckBox CB, string[] mesesAtivos,string ano, string anoNum)
        {
            DataBase con = new DataBase();
            string sql;
            string ChBox = CB.Name.Substring(2);

            con.connect();
            if (CB.Checked)
            {
                sql = "INSERT INTO meses_tb(ano_mes, mes, ano, situacao) VALUES ('" + ano + anoNum + "', '" + ChBox + "', " + ano + ", 'A')";

                foreach (string str in mesesAtivos)
                {
                    if (str == ChBox)
                    {
                        sql = "UPDATE meses_tb SET situacao = 'A' WHERE ano = " + ano + " AND mes = '" + ChBox + "' AND situacao = 'I'";
                    }
                }
                con.insertOrUpdate(sql);
                con.disconnect();
            }
            else
            {
                sql = "UPDATE meses_tb SET situacao = 'I' WHERE ano = " + ano + " AND mes = '" + ChBox + "' AND situacao = 'A'";
                con.insertOrUpdate(sql);
                con.disconnect();
            }
        }
    }
}

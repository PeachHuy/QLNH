using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNH2
{

    public partial class THỰC_ĐƠN : Form
    {
        string ConnStr = "Data Source=LAPTOP-8KH6RH5M;Initial Catalog=QUANLYNHAHANG;Integrated Security=True;";
        SqlConnection Conn;
        public THỰC_ĐƠN()
        {
            InitializeComponent();
            
        }



        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void THỰC_ĐƠN_Load(object sender, EventArgs e)
        {
            HienThiNhommon();
        }

        private void comboNhMon_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void HienThiNhommon()
        {
            
               Conn = new SqlConnection(ConnStr);
           string t = "select * from NHOMMON";
            SqlCommand sqlcmd = new SqlCommand(t, Conn);
            sqlcmd.CommandType = CommandType.Text;
           

            sqlcmd.Connection = Conn;
            comboNhMon.Items.Clear();
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                string mamon = reader.GetString(0);
                string ten = reader.GetString(1);

                string line = mamon + "/" + ten;

                comboNhMon.Items.Add(line);
            }
            reader.Close();
        }
        private void THU_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
using WebMotors;

namespace projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            LtvStudent.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Student";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["Id"];
                    string name = (string)dr["Name"];
                    string job = (string)dr["Enrollment"];
                    string tel = (string)dr["Telephone"];
                    string cpf = (string)dr["Cpf"];
                    string pass = (string)dr["Password"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(job);
                    lv.SubItems.Add(tel);
                    lv.SubItems.Add(cpf);
                    lv.SubItems.Add(pass);
                    LtvStudent.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }







        private void btnlogin_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO banco_milckshacksper VALUES
            (@email, @senha)";



            sqlCommand.Parameters.AddWithValue("@email", txbemail.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbsenha.Text);






            sqlCommand.ExecuteNonQuery();
            //campo depois de logar
            MessageBox.Show("cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //para limpar
            txbemail.Clear();
            txbsenha.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
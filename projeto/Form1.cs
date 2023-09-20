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
        private int Id;
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM login";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                   
                    string email = (string)dr["email"];
                    string senha= (string)dr["senha"];


                    ListViewItem lv = new ListViewItem(dr["id"].ToString());
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(senha);
                    listView1.Items.Add(lv);

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
            sqlCommand.CommandText = @"INSERT INTO login VALUES
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

            UpdateListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editar_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE  login SET
            email=@email,
            senha=@senha
            WHERE id= @id";
            



            sqlCommand.Parameters.AddWithValue("@email", txbemail.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbsenha.Text);
            sqlCommand.Parameters.AddWithValue("@id", Id);






            sqlCommand.ExecuteNonQuery();
            //campo depois de logar
            MessageBox.Show("cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //para limpar
            txbemail.Clear();
            txbsenha.Clear();

            UpdateListView();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txbemail.Text = listView1.Items[index].SubItems[1].Text;
            txbsenha.Text = listView1.Items[index].SubItems[2].Text;
           
        }
    }
    }


using projeto.Properties;
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
            LoginusuarioDAO loginusuarioDAO = new LoginusuarioDAO();
            List<LoginUsuario> users = loginusuarioDAO.SelectUser();


            try
            {
                foreach (LoginUsuario login in users)

                {


                    ListViewItem lv = new ListViewItem(login.Id.ToString()) ;
                    lv.SubItems.Add(login.Email);
                    lv.SubItems.Add(login.Senha);
                    listView1.Items.Add(lv);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                Connection.CloseConnection();
            }
        }







        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            { 
            //criar obj da classe usuario
            LoginUsuario loginUsuario = new LoginUsuario(
                txbemail.Text,
                txbsenha.Text

                );
                //chamando o metodo de exclusao
                LoginusuarioDAO nomeDoObj = new LoginusuarioDAO();
                nomeDoObj.InterUser(loginUsuario);

                //campo depois de logar
                MessageBox.Show("cadastrado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            
            //para limpar depois de execultar
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
            //EDITAR AS INFORMAÇOES
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE  login SET
                
            email=@email,
            senha=@senha       
            WHERE id= @id";
            


            //os @ recebem as informaçoes dos campos de texto que estao na tela
            sqlCommand.Parameters.AddWithValue("@email", txbemail.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbsenha.Text);
            sqlCommand.Parameters.AddWithValue("@id", Id);






            sqlCommand.ExecuteNonQuery();
            //campo depois de editar
            MessageBox.Show("Editado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //para limpar depois de executado
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


        // excluir
        private void excluir_Click(object sender, EventArgs e)
        {
            //Chamando o metodo de exclusao
            LoginusuarioDAO dadosdouser = new LoginusuarioDAO();
            dadosdouser.Deleteuser(Id);
            //limpando campos
            txbemail.Clear();
            txbsenha.Clear();
            //atualizada a listView
            UpdateListView();
        }
    }
    }


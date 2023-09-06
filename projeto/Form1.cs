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
    }

}
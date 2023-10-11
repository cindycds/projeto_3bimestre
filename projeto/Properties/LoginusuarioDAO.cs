using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebMotors;

namespace projeto.Properties
{
    internal class LoginusuarioDAO
    {
        public List<LoginUsuario> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM login";
            List<LoginUsuario > users= new List<LoginUsuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    LoginUsuario objeto = new LoginUsuario(
                        (int)dr["id"],
                     (string)dr["email"],
                     (string)dr["senha"] 
                    );


                   users.Add(objeto);


                }
                dr.Close();
                return users; //retornar a lista
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }





        public void InterUser(LoginUsuario loginUsuario)
        {
            //ADICIONAR AS INFORMAÇOES para logar
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO login VALUES
            (@email, @senha)";



            sqlCommand.Parameters.AddWithValue("@email", loginUsuario.Email);
            sqlCommand.Parameters.AddWithValue("@senha", loginUsuario.Senha);






            sqlCommand.ExecuteNonQuery();
        }


        // void nao me retorna nada, apenas executa
        public void Deleteuser(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM login WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}

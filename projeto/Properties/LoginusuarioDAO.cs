using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors;

namespace projeto.Properties
{
    internal class LoginusuarioDAO
    {
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

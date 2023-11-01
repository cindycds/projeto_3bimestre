using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    internal class Connection
    {
        //Propriedades ou atributos
        private readonly SqlConnection con;
        private readonly string DataBase = "sorveteria_milkshackper";

        //Construtor
        public Connection() //LAB01-PC17\SQLEXPRESS
        {
            //Data Source=LAB01-PC17\SQLEXPRESS;Initial Catalog=RevendaDeCarros_Will;Integrated Security=True
            string stringConnection = "Data Source=LAB01-PC25\\SQLEXPRESS;Initial Catalog=sorveteria_milkshackper;Integrated Security=True";
            // @"Data Source="
            // + Environment.MachineName +
            // @"\SQLEXPRESS;Initial Catalog=" +
            // DataBase + ";Integrated Security=true";

            con = new SqlConnection(stringConnection);
            {
                con.Open();
            }
           
        }
        //Tenta fechar a conexão com o banco
        public void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}

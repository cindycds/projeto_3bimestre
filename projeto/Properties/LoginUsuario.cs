using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.Properties
{
    public class LoginUsuario
    {
        private int  _id;    
        private string _email;
        private string _senha;

        public LoginUsuario(string email,
                     string senha)
        {//validaçao dos campos
            Email = email;
            Senha = senha;
        }
        public string Email
        {
            //para atualizar(inserir) valor
            set {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("campo e-mail está vazio");
                _email = value; 
            }
            //para retornar valor
            get {return  _email; }
        } public string Senha
        {
            //para atualizar(inserir) valor
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("campo senha está vazio");   //para ver se o campo esta vazio
                _senha = value;
            
            }
            //para retornar valor
            get {return  _senha; }
        }
       
       
    }

}

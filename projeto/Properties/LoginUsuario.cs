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
        {
            _email = email;
            _senha = senha;
        }
        public string email;
        {
            //para atualizar valor
            set { _email = value; }
            //para retornar valor
            get {return = _email }
        }
       
       
    }

}

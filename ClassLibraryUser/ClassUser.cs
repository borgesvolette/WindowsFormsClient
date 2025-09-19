using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClassLibraryUser
{
    public class ClassUser
    {
        //Propriedades
        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }




        //Construtor
        public ClassUser(int _id, string _name, string _email, string _password) 
        {
            this.Id = _id;
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;

        }


        //Metodos

        public string Entrar (string email,string password)

        { 
            return ""; 
        
        }
        public string Registrar( string name, string email, string password) 
        {

            return "";

        }
    }
}

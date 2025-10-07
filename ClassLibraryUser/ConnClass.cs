using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibraryUser
{
    public class ConnClass
    {
        //dados constantes (const)//não mudam

        //Propriedades
        private const string Server = "TAU0712128W11-1"; //propriedades do SQL SERVER// nome do servidor
        private const string DataBase = "DB_Recycle"; // nome do Banco de Dados
        private const string User = "senac"; // nome do usuario do BD
        private const string Password = "senac"; //senha do BD

        //String ( CADEIA) de Conexão // todos os dados em um só lugar
        public string strConn = $"Server= {Server}; DataBase = {DataBase}; User Id= {User}; Password = {Password}";


        //Método para Conectar com o banco de dados, com a string de conexão 
        public SqlConnection GetConnection()
        {
            SqlConnection _conn = new SqlConnection (strConn);
            return _conn;
        }




    }
}

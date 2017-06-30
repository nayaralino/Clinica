using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

// data revisão 21/10

namespace DAL
{
    public class ConexaoDAL
    {
        private String stringConexao;
        private SqlConnection conexao;

        public ConexaoDAL (String dadosConexao) //Construtor
        {
            this.Conexao = new SqlConnection();
            this.stringConexao = dadosConexao;
            this.Conexao.ConnectionString = dadosConexao;
        }
              
        public string StringConexao
        {
            get
            {
                return stringConexao;
            }

            set
            {
                stringConexao = value;
            }
        }

        public SqlConnection Conexao 
        {
            get
            {
                return conexao;
            }

            set
            {
                conexao = value;
            }
        }

         public void Conectar() // Metodo p/ Conectar
        {
            this.conexao.Open();
        }

        public void Desconectar() // Metodo p/ DESConectar
        {
            this.conexao.Close();
        }

     }//class
    
}//namespace

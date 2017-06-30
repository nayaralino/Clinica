using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Data de criação 09/02
// Data de modificação 09/02

namespace DAL
{
    public class SexoDAL
    {
   
    private ConexaoDAL conexao;

    public SexoDAL(ConexaoDAL sexoDalCon) // Construtor que recebe como parametro uma conexão 
    {
        this.conexao = sexoDalCon;
    }

    public void Incluir(SexoDTO sexoDalCrud)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conexao.Conexao;
        cmd.CommandText = "insert into tbSexo(sex_descriçao) values (@sex_descriçao);select @@identity;";
        cmd.Parameters.AddWithValue("@sex_descriçao", sexoDalCrud.Sexo_nome);
        conexao.Conectar();
        sexoDalCrud.Sexo_id = Convert.ToInt32(cmd.ExecuteScalar());
        conexao.Desconectar();
    }//incluir

    public void Alterar(SexoDTO sexoDalCrud)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conexao.Conexao;
        cmd.CommandText = "update tbSexo set sex_descriçao = @sex_descriçao where sex_id = @sex_id;";

        cmd.Parameters.AddWithValue("@sex_id", sexoDalCrud.Sexo_id);
        cmd.Parameters.AddWithValue("@sex_descriçao", sexoDalCrud.Sexo_nome);
        conexao.Conectar();
        cmd.ExecuteNonQuery(); //não retorna parametro algum
        conexao.Desconectar();
    }//alterar

    public void Excluir(int sex_id) //tipo + o campo do banco
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conexao.Conexao;
        cmd.CommandText = "delete from tbSexo where sex_id = @sex_id;";
        cmd.Parameters.AddWithValue("@sex_id", sex_id);
        conexao.Conectar();
        cmd.ExecuteNonQuery(); //não retorna parametro algum
        conexao.Desconectar();
    }//excluir

    public DataTable Pesquisar(String sex_descriçao) //tipo + o campo do banco
    {
        DataTable tabela = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("Select * from tbSexo where sex_descriçao like '%' + sex_descriçao + '%'", conexao.StringConexao);
        da.Fill(tabela);
        return tabela;
    }//pesquisar

    public SexoDTO CarregaSexoDTO(int sex_id) //tipo + o campo do banco
    {
        SexoDTO sexo = new SexoDTO();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conexao.Conexao;
        cmd.CommandText = "select * from tbSexo where sex_id = @sex_id;";
        cmd.Parameters.AddWithValue("@sex_id", sex_id);
        conexao.Conectar();
        SqlDataReader registro = cmd.ExecuteReader();
        if (registro.HasRows)
        {
            registro.Read();
                sexo.Sexo_id = Convert.ToInt32(registro["sex_id"]);
                sexo.Sexo_nome = Convert.ToString(registro["sex_descriçao"]);
        }
        conexao.Desconectar();
        return sexo;
    }//carrega

    




}//class

}//namespace

using DAL;
using System;
using System.Data;
using DTO;

// Data de criação 13-02
// Data de modificação 13/02
    
namespace BLL
{
    public class MedicoBLL
    {
        private ConexaoDAL conexao;

        public MedicoBLL(ConexaoDAL medBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = medBllCon;
        }

        public void Incluir(MedicoDTO medBllCrud)
        {
            if (medBllCrud.Med_nome.Trim().Length == 0) //verifica se foi informado o nome 
            {
                throw new Exception("O nome do médico é obrigatório");
            }

            medBllCrud.Med_nome = medBllCrud.Med_nome.ToUpper(); //coloca em maiusculo

            MedicoDAL dalObj = new MedicoDAL(conexao);
            dalObj.Incluir(medBllCrud);

        }

        public void Alterar(MedicoDTO medBllCrud)
        {
            if (medBllCrud.Med_nome.Trim().Length == 0) //verifica se foi informado o nome animal e ou se esta vazio
            {
                throw new Exception("O nome do médico é obrigatório");
            }

            medBllCrud.Med_nome = medBllCrud.Med_nome.ToUpper(); //coloca em maiusculo

            MedicoDAL dalObj = new MedicoDAL(conexao);
            dalObj.Alterar(medBllCrud);
        }

        public void Excluir(int med_id)
        {
            MedicoDAL dalObj = new MedicoDAL(conexao);
            dalObj.Excluir(med_id);
        }

        public DataTable Pesquisar(String med_nome)
        {
            MedicoDAL dalObj = new MedicoDAL(conexao);
            dalObj.Pesquisar(med_nome);

            return dalObj.Pesquisar(med_nome);
        }

        public MedicoDTO CarregaMedicoDTO(int med_id)
        {
            MedicoDAL dalObj = new MedicoDAL(conexao);
            dalObj.CarregaMedicoDTO(med_id);

            return dalObj.CarregaMedicoDTO(med_id);
        }

    }//class 

}//namespace


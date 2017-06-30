using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class CidadeBLL
    {
            private ConexaoDAL conexao;

            public CidadeBLL(ConexaoDAL cidBllCon) // Construtor que recebe como parametro uma conexão
            {
                this.conexao = cidBllCon;
            }

            public void Incluir(CidadeDTO cidBllCrud)
            {
                if (cidBllCrud.Cid_cidade.Trim().Length == 0) //verifica se foi informado 
                {
                    throw new Exception("O nome da cidade é obrigatório");
                }


                CidadeDAL dalObj = new CidadeDAL(conexao);
                dalObj.Incluir(cidBllCrud);

            }

            public void Alterar(CidadeDTO cidBllCrud)
            {
                if (cidBllCrud.Cid_cidade.Trim().Length == 0) //verifica se foi informado 
                {
                    throw new Exception("O nome da cidade é obrigatório");
                }

            CidadeDAL dalObj = new CidadeDAL(conexao);
                dalObj.Alterar(cidBllCrud);
            }

            public void Excluir(int cid_id)
            {
                CidadeDAL dalObj = new CidadeDAL(conexao);
                dalObj.Excluir(cid_id);
            }

            public DataTable Pesquisar(String cid_cidade)
            {
                CidadeDAL dalObj = new CidadeDAL(conexao);
                dalObj.Pesquisar(cid_cidade);

                return dalObj.Pesquisar(cid_cidade);
            }

            public CidadeDTO CarregaCidadeDTO(int cid_id)
            {
                CidadeDAL dalObj = new CidadeDAL(conexao);
                dalObj.CarregaCidadeDTO(cid_id);

                return dalObj.CarregaCidadeDTO(cid_id);
            }

        }//class 

    }//namespace


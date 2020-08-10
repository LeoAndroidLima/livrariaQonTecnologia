﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Uteis;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class ClienteModal
    {
        public string Id { get; set; }

        [Required (ErrorMessage ="Informe o Nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF do cliente")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Informe o E-mail do cliente")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O e-mail informado é inválido!")]
        public string Email { get; set; }

        public string Senha { get; set; }

        public List<ClienteModal> ListarTodosClientes()
        {
            List<ClienteModal> lista = new List<ClienteModal>();
            ClienteModal item;
            DAL objDAL = new DAL();
            string sql = "SELECT id, nome, cpf_cnpj, email, senha FROM Cliente order by nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ClienteModal
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    CPF = dt.Rows[i]["cpf_cnpj"].ToString(),
                    Email = dt.Rows[i]["Email"].ToString(),
                    Senha = dt.Rows[i]["Senha"].ToString()
                };
                lista.Add(item);
            }

            return lista;
        }

        public ClienteModal RetornarCliente(int? id)
        {
            ClienteModal item;
            DAL objDAL = new DAL();
            string sql = $"SELECT id, nome, cpf_cnpj, email, senha FROM Cliente where id ='{id}' order by nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            item = new ClienteModal
            {
                Id = dt.Rows[0]["Id"].ToString(),
                Nome = dt.Rows[0]["Nome"].ToString(),
                CPF = dt.Rows[0]["cpf_cnpj"].ToString(),
                Email = dt.Rows[0]["Email"].ToString(),
                Senha = dt.Rows[0]["Senha"].ToString()
            };

            return item;
        }

        //Inserir ou atualizar
        public void Gravar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

            if (Id != null)
            {
                sql = $"UPDATE CLIENTE SET NOME='{Nome}', CPF_CNPJ='{CPF}', EMAIL='{Email}' where id = '{Id}' ";
            }
            else
            {
                sql = $"INSERT INTO CLIENTE(NOME, CPF_CNPJ, EMAIL, SENHA) VALUES('{Nome}', '{CPF}', '{Email}', '123456')";
            }

            objDAL.ExecutarComandoSQL(sql);
        }

        //Metodo de exclusão
        public void Excluir(int id)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM CLIENTE WHERE ID='{id}'";
            objDAL.ExecutarComandoSQL(sql);
        }
    }
}

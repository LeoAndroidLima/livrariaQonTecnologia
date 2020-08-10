using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Uteis;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class ProdutoModel
    {
        public string Id { get; set; }

        [Required (ErrorMessage ="Informe o Nome do produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a Descrição do produto")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o Preço Unitário do produto")]
        public decimal? Preco_Unitario { get; set; }

        [Required(ErrorMessage = "Informe a Quantidade em Estoque do produto")]
        public decimal? Quantidade_Estoque { get; set; }

        [Required(ErrorMessage = "Informe a Unidade de Medida do produto")]
        public string Unidade_Medida { get; set; }

        [Required(ErrorMessage = "Informe o Link da Imagem do produto")]
        public string Link_Foto { get; set; }


        public List<ProdutoModel> ListarTodosProdutos()
        {
            List<ProdutoModel> lista = new List<ProdutoModel>();
            ProdutoModel item;
            DAL objDAL = new DAL();
            string sql = 
                "SELECT id, nome, descricao, preco_unitario, quantidade_estoque, unidade_medida, link_foto FROM Produto order by nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ProdutoModel
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    Descricao = dt.Rows[i]["Descricao"].ToString(),
                    Preco_Unitario = decimal.Parse(dt.Rows[i]["Preco_unitario"].ToString()),
                    Quantidade_Estoque = decimal.Parse(dt.Rows[i]["Quantidade_estoque"].ToString()),
                    Unidade_Medida = dt.Rows[i]["Unidade_medida"].ToString(),
                    Link_Foto = dt.Rows[i]["Link_foto"].ToString()
                };
                lista.Add(item);
            }

            return lista;
        }

        public ProdutoModel RetornarProduto(int? id)
        {
            ProdutoModel item;
            DAL objDAL = new DAL();
            string sql = 
                $"SELECT id, nome, descricao, preco_unitario, quantidade_estoque, unidade_medida, link_foto FROM Produto where id ='{id}' order by nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            item = new ProdutoModel
            {
                Id = dt.Rows[0]["Id"].ToString(),
                Nome = dt.Rows[0]["Nome"].ToString(),
                Descricao = dt.Rows[0]["Descricao"].ToString(),
                Preco_Unitario = decimal.Parse(dt.Rows[0]["Preco_unitario"].ToString()),
                Quantidade_Estoque = decimal.Parse(dt.Rows[0]["Quantidade_estoque"].ToString()),
                Unidade_Medida = dt.Rows[0]["Unidade_medida"].ToString(),
                Link_Foto = dt.Rows[0]["Link_foto"].ToString()

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
                sql = $"UPDATE PRODUTO SET " +
                    $"NOME='{Nome}', " +
                    $"DESCRICAO='{Descricao}', " +
                    $"PRECO_UNITARIO={Preco_Unitario.ToString().Replace(",",".")}, " +
                    $"QUANTIDADE_ESTOQUE='{Quantidade_Estoque}', " +
                    $"UNIDADE_MEDIDA='{Unidade_Medida}', " +
                    $"LINK_FOTO='{Link_Foto}' " +
                    $"where id = '{Id}' ";
            }
            else
            {
                sql = 
                    $"INSERT INTO PRODUTO(NOME, DESCRICAO, PRECO_UNITARIO, QUANTIDADE_ESTOQUE, UNIDADE_MEDIDA, LINK_FOTO) " +
                    $"VALUES('{Nome}'," +
                    $"'{Descricao}'," +
                    $"'{Preco_Unitario}'," +
                    $"'{Quantidade_Estoque}'," +
                    $"'{Unidade_Medida}'," +
                    $"'{Link_Foto}')";
            }

            objDAL.ExecutarComandoSQL(sql);
        }

        //Metodo de exclusão
        public void Excluir(int id)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM PRODUTO WHERE ID='{id}'";
            objDAL.ExecutarComandoSQL(sql);
        }
    }
}

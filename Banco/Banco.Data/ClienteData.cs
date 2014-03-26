using Banco.Data.Interfaces;
using Banco.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Data
{
    public class ClienteData : IData<Cliente>
    {
        public void Inserir(Cliente obj)
        {
            Database db = new DatabaseProviderFactory().Create("Database");
            String sql = "INSERT INTO CLIENTE (NOME,SOBRENOME,IDADE,CPF,RG,IDCARTAO, IDCONTA) VALUES(@NOME,@SOBRENOME,@IDADE,@CPF,@RG,@IDCARTAO,@IDCONTA) set @ID = (select @@identity)";

            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "NOME", System.Data.DbType.String, obj.Nome);
                db.AddInParameter(cmd, "SOBRENOME", System.Data.DbType.String, obj.Sobrenome);
                db.AddInParameter(cmd, "IDADE", System.Data.DbType.String, obj.Idade);
                db.AddInParameter(cmd, "CPF", System.Data.DbType.String, obj.Cpf);
                db.AddInParameter(cmd, "RG", System.Data.DbType.String, obj.RG);
                db.AddInParameter(cmd, "IDCARTAO", System.Data.DbType.Int32, obj.IdCartao);
                db.AddInParameter(cmd, "IDCONTA", System.Data.DbType.Int32, obj.IdConta);
                db.AddOutParameter(cmd, "ID", System.Data.DbType.Int32, 4);

                db.ExecuteNonQuery(cmd);

                obj.Id = Convert.ToInt32(cmd.Parameters["@ID"].Value);
            }
        }

        public void Atualizar(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public Cliente Buscar(Cliente obj)
        {
            Cliente cliente = null;

            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");

                string sql = @"SELECT ID,NOME,SOBRENOME,IDADE,RG,CPF,IDCARTAO,IDCONTA FROM CLIENTE WHERE ID = @ID";

                using (DbCommand cmd = db.GetSqlStringCommand(sql))
                {
                    db.AddInParameter(cmd, "ID", DbType.Int32, obj.Id);
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        if (dr.Read())
                        {
                            cliente = new Cliente();
                            cliente.Id = Convert.ToInt32(dr["ID"]);
                            cliente.Nome = Convert.ToString(dr["NOME"]);
                            cliente.Sobrenome = Convert.ToString(dr["SOBRENOME"]);
                            cliente.Idade = Convert.ToString(dr["IDADE"]);
                            cliente.Cpf = Convert.ToString(dr["CPF"]);
                            cliente.RG = Convert.ToString(dr["RG"]);
                            cliente.IdCartao = Convert.ToInt32(dr["IDCARTAO"]);
                            cliente.IdConta = Convert.ToInt32(dr["IDCONTA"]);
                        }
                    }
                }

                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClienteDataHolder> BuscarTodos()
        {
            List<ClienteDataHolder> clienteDataHolder = new List<ClienteDataHolder>();
            try
            {
                Database db = new DatabaseProviderFactory().Create("Database");
                string sql = @"SELECT CLI.ID, CLI.NOME, CLI.SOBRENOME, CLI.IDADE, CLI.CPF, CLI.RG, CLI.IDCARTAO, CLI.IDCONTA, 
                            CAR.VALIDADE, CON.SALDO
                            FROM CLIENTE CLI
                            INNER JOIN CARTAO CAR ON CAR.ID = CLI.IDCARTAO
                            INNER JOIN CONTA CON ON CON.ID = CLI.IDCONTA";

                using (DbCommand cmd = db.GetSqlStringCommand(sql))
                {
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        while (dr.Read())
                        {
                            ClienteDataHolder cliente = new ClienteDataHolder();
                            cliente.Id = Convert.ToInt32(dr["ID"]);
                            cliente.Nome = Convert.ToString(dr["NOME"]);
                            cliente.Sobrenome = Convert.ToString(dr["SOBRENOME"]);
                            cliente.Idade = Convert.ToString(dr["IDADE"]);
                            cliente.Cpf = Convert.ToString(dr["CPF"]);
                            cliente.RG = Convert.ToString(dr["RG"]);
                            cliente.ValidadeCartao = Convert.ToDateTime(dr["VALIDADE"]);
                            cliente.SaldoConta = Convert.ToDecimal(dr["SALDO"]);
                            cliente.IdCartao = Convert.ToInt32(dr["IDCARTAO"]);
                            cliente.IdConta = Convert.ToInt32(dr["IDCONTA"]);

                            clienteDataHolder.Add(cliente);
                        }
                    }
                }
                return clienteDataHolder;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
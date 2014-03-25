using Banco.Data.Interfaces;
using Banco.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
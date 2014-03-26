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
    public class CartaoData : IData<Cartao>
    {
        public void Inserir(Cartao obj)
        {
            Database db = new DatabaseProviderFactory().Create("Database");
            String sql = "INSERT INTO CARTAO(VALIDADE) VALUES (@VALIDADE) SET @ID=(SELECT @@IDENTITY)";

            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "VALIDADE", System.Data.DbType.DateTime, obj.Validade);
                db.AddOutParameter(cmd, "ID", System.Data.DbType.Int32, 4);
                db.ExecuteNonQuery(cmd);

                obj.Id = Convert.ToInt32(cmd.Parameters["@ID"].Value);
            }
        }

        public void Atualizar(Cartao obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(Cartao obj)
        {
            throw new NotImplementedException();
        }

        public Cartao Buscar(Cartao obj)
        {
            Cartao cartao = null;
            Database db = new DatabaseProviderFactory().Create("Database");

            string sql = @"SELECT ID, VALIDADE FROM CARTAO WHERE ID = @ID";

            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "ID", DbType.Int32, obj.Id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        cartao = new Cartao();
                        cartao.Id = Convert.ToInt32(dr["ID"]);
                        cartao.Validade = Convert.ToDateTime(dr["VALIDADE"]);
                    }
                }
            }

            return cartao;
        }
    }
}

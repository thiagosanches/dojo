﻿using Banco.Data.Interfaces;
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
    public class ContaData : IData<Conta>
    {
        public void Inserir(Conta obj)
        {
            Database db = new DatabaseProviderFactory().Create("Database");
            String sql = "INSERT INTO CONTA (SALDO) VALUES (@SALDO) SET @ID=(SELECT @@IDENTITY)";

            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "SALDO", System.Data.DbType.Int32, obj.Saldo);
                db.AddOutParameter(cmd, "ID", System.Data.DbType.Int32, 4);
                db.ExecuteNonQuery(cmd);
                obj.Id = Convert.ToInt32(cmd.Parameters["@ID"].Value);
            }
        }

        public void Atualizar(Conta obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(Conta obj)
        {
            throw new NotImplementedException();
        }

        public Conta Buscar(Conta obj)
        {
            Conta conta = null;

            Database db = new DatabaseProviderFactory().Create("Database");

            string sql = "SELECT ID, SALDO FROM CONTA WHERE ID = @ID";

            using (DbCommand cmd = db.GetSqlStringCommand(sql))
            {
                db.AddInParameter(cmd, "ID", System.Data.DbType.Int32, obj.Id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        conta = new Conta();
                        conta.Id = Convert.ToInt32(dr["ID"]);
                        conta.Saldo = Convert.ToDecimal(dr["SALDO"]);
                    }
                }
            }

            return conta;
        }
    }
}

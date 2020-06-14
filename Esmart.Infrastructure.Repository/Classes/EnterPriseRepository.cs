using Esmart.Application.Models.Models;
using Esmart.Infrastructure.Data;
using Esmart.Infrastructure.Models.Models;
using Esmart.Infrastructure.RepositoryContract.Interfaces;
using NevaCloud.FalconConverters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.Repository.Classes
{
    public class EnterPriseRepository : Repository<tbl_Assets>, IEnterPriseRepository
    {
        public EnterPriseRepository(EsmartEntitiess context) : base(context)
        {

        }
        public dynamic GetEnterPriseListForAll(long ep_id)
        {
            List<EnterpriseList> lstEnterPrise = new List<EnterpriseList>();
            using (var context = new EsmartEntitiess())
            {
                var dt = new DataTable();
                var conn = context.Database.Connection;
                var connectionState = conn.State;
                try
                {
                    if (connectionState != ConnectionState.Open) conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "Usp_GetAdressDetails";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Action", "GetEnterPriseList"));
                        cmd.Parameters.Add(new SqlParameter("@ep_id", ep_id));
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                            foreach (DataRow row in dt.Rows)
                            {
                                lstEnterPrise.Add(new EnterpriseList
                                {
                                    ep_id = DataBase.Turn<Int64>(row["ep_id"]),
                                    EnterpriseID = DataBase.Turn<string>(row["EnterpriseID"]),
                                    EnterpriseName = DataBase.Turn<string>(row["EnterpriseName"]),
                                    ParentEnterprise = DataBase.Turn<string>(row["ParentEnterprise"]),
                                    PermanentRegistration = DataBase.Turn<string>(row["PermanentRegistration"]),
                                    DateOfExpiry = DataBase.Turn<DateTime>(row["DateOfExpiry"]),
                                    DateOfInception = DataBase.Turn<DateTime>(row["DateOfInception"]),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // error handling
                    throw;
                }
                finally
                {
                    if (connectionState != ConnectionState.Closed) conn.Close();
                }
                return lstEnterPrise;
            }

               // var result = EsmartContext.ExecuteStoreQuery<DataTable>("Usp_GetAdressDetails @Ep_id,@Action", xparams);

            return null;
        }

        public EsmartEntitiess EsmartContext
        {
            get { return Context as EsmartEntitiess; }
        }
    }
}

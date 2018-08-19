using DIVAAPI.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalaliShopDataAccessLayer
{
    public class OwnersRepository : IOwnersRepository
    {

        private string appCN;

        public OwnersRepository()
        {
            appCN = ConfigurationManager.ConnectionStrings["DalaliShop"].ConnectionString;
            if (String.IsNullOrEmpty(appCN))
                throw (new ApplicationException(
                   "ConnectionString for the application configuration is missing from you web.config. "));
        }
        public DataSet GetAllOwners()
        {
            DataSet ds = new DataSet();
            //ds.Tables[0].Columns.Add("FirstName");
            //ds.Tables[0].Columns.Add("FirstName").DefaultValue = "Kiran"; 
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[1];
                paramsToStore[0] = new SqlParameter("@TypeOfUsers", SqlDbType.VarChar);
                paramsToStore[0].Direction = ParameterDirection.Input;
                paramsToStore[0].Value = "Owners";



                ds = SqlService.ExecuteDataset(appCN, CommandType.StoredProcedure, "GetAll", paramsToStore);
                return ds;

            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
    }


}

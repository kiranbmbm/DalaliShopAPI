using DalaliShopCommon;
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
            List<OwnerModel> ownerList = new List<OwnerModel>();
            //ds.Tables[0].Columns.Add("FirstName");
            //ds.Tables[0].Columns.Add("FirstName").DefaultValue = "Kiran"; 
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[1];
                paramsToStore[0] = new SqlParameter("@TypeOfUsers", SqlDbType.VarChar);
                paramsToStore[0].Direction = ParameterDirection.Input;
                paramsToStore[0].Value = "Owners";


                ds = SqlService.ExecuteDataset(appCN, CommandType.StoredProcedure, "GetAll", paramsToStore);

                //converting the dataset  into the datatable 
                //foreach (DataRow dr in ds.Tables["Table"].Rows)
                //{
                //    OwnerModel ownerModel = new OwnerModel();
                //    ownerModel.UsedId = int.Parse(ds.Tables[0].Columns["UsedId"].ToString());
                //    ownerModel.FirstName = ds.Tables[0].Columns["FirstName"].ToString();
                //    ownerModel.MiddleName = ds.Tables[0].Columns["MiddleName"].ToString();
                //    ownerModel.LastName = ds.Tables[0].Columns["LastName"].ToString();
                //    ownerModel.FullName = ds.Tables[0].Columns["FullName"].ToString();
                //    ownerModel.CreatedBy = ds.Tables[0].Columns["CreatedBy"].ToString();
                //    ownerModel.UpdatedBy = ds.Tables[0].Columns["UpdatedBy"].ToString();
                //    ownerModel.FirstName = ds.Tables[0].Columns["FirstName"].ToString();
                //    ownerModel.FirstName = ds.Tables[0].Columns["FirstName"].ToString();
                //    ownerModel.FirstName = ds.Tables[0].Columns["FirstName"].ToString();
                //    ownerModel.FirstName = ds.Tables[0].Columns["FirstName"].ToString();
                //    ownerModel.FirstName = ds.Tables[0].Columns["FirstName"].ToString();
                //    ownerModel.FirstName = ds.Tables[0].Columns["FirstName"].ToString();
                //}
                //converting the dataset  into the datatable 

                return ds;

            }
            catch (Exception ee)
            {
                throw ee;
            }
        }

        public string PostOwner(OwnerModel ownerModel)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[14];
                paramsToStore[0] = new SqlParameter("@TypeOfUsers", SqlDbType.VarChar);
                paramsToStore[0].Direction = ParameterDirection.Input;
                paramsToStore[0].Value = "Owners";
                paramsToStore[1] = new SqlParameter("@FirstName", SqlDbType.VarChar);
                paramsToStore[1].Direction = ParameterDirection.Input;
                paramsToStore[1].Value = ownerModel.FirstName;
                paramsToStore[2] = new SqlParameter("@MiddleName", SqlDbType.VarChar);
                paramsToStore[2].Direction = ParameterDirection.Input;
                paramsToStore[2].Value = ownerModel.MiddleName;
                paramsToStore[3] = new SqlParameter("@LastName", SqlDbType.VarChar);
                paramsToStore[3].Direction = ParameterDirection.Input;
                paramsToStore[3].Value = ownerModel.LastName;
                paramsToStore[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar);
                paramsToStore[4].Direction = ParameterDirection.Input;
                paramsToStore[4].Value = ownerModel.CreatedBy;
                paramsToStore[5] = new SqlParameter("@UpdatedBy", SqlDbType.VarChar);
                paramsToStore[5].Direction = ParameterDirection.Input;
                paramsToStore[5].Value = ownerModel.UpdatedBy;
                paramsToStore[6] = new SqlParameter("@EmailAdress", SqlDbType.VarChar);
                paramsToStore[6].Direction = ParameterDirection.Input;
                paramsToStore[6].Value = ownerModel.EmailAdress;
                paramsToStore[7] = new SqlParameter("@MobileNumber", SqlDbType.BigInt);
                paramsToStore[7].Direction = ParameterDirection.Input;
                paramsToStore[7].Value = ownerModel.MobileNumber;
                paramsToStore[8] = new SqlParameter("@PermanantAdress", SqlDbType.VarChar);
                paramsToStore[8].Direction = ParameterDirection.Input;
                paramsToStore[8].Value = ownerModel.PermanantAdress;
                paramsToStore[9] = new SqlParameter("@Place", SqlDbType.VarChar);
                paramsToStore[9].Direction = ParameterDirection.Input;
                paramsToStore[9].Value = ownerModel.Place;
                paramsToStore[10] = new SqlParameter("@Taluq", SqlDbType.VarChar);
                paramsToStore[10].Direction = ParameterDirection.Input;
                paramsToStore[10].Value = ownerModel.Taluq;
                paramsToStore[11] = new SqlParameter("@District", SqlDbType.VarChar);
                paramsToStore[11].Direction = ParameterDirection.Input;
                paramsToStore[11].Value = ownerModel.District;
                paramsToStore[12] = new SqlParameter("@Pincode", SqlDbType.Int);
                paramsToStore[12].Direction = ParameterDirection.Input;
                paramsToStore[12].Value = ownerModel.Pincode;
                byte[] byteArrayUTF = System.Text.Encoding.UTF8.GetBytes("Byte");
                paramsToStore[13] = new SqlParameter("@FingerPrint", SqlDbType.Binary);
                paramsToStore[13].Direction = ParameterDirection.Input;
                paramsToStore[13].Value = byteArrayUTF;

                string json = String.Empty;
                json = Convert.ToString(SqlService.ExecuteScalar(appCN, CommandType.StoredProcedure, "InsertAll", paramsToStore));

                //converting the dataset  into the datatable 

                return json;

            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
        public string DeleteOwner(int id)
        {
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[2];
                paramsToStore[0] = new SqlParameter("@TypeOfUsers", SqlDbType.VarChar);
                paramsToStore[0].Direction = ParameterDirection.Input;
                paramsToStore[0].Value = "Owners";
                paramsToStore[1] = new SqlParameter("@Id", SqlDbType.Int);
                paramsToStore[1].Direction = ParameterDirection.Input;
                paramsToStore[1].Value = id;

                string json = string.Empty;

                json = Convert.ToString(SqlService.ExecuteScalar(appCN, CommandType.StoredProcedure, "DeleteAll", paramsToStore));

                return json;

            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
    }


}

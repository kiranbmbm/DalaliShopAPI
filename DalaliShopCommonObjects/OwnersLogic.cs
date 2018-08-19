using DalaliShopDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalaliShopBusLogic
{
    public class OwnersLogic
    {
        static readonly IOwnersRepository InterfaceAdvancedML = new OwnersRepository();
        public DataSet GetAllOwners()
        {
            try
            {
                return InterfaceAdvancedML.GetAllOwners();
            }
            catch (Exception ee)
            {
                throw ee;

            }

        }
    }
}

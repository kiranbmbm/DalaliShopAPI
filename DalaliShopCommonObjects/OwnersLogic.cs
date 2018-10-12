using DalaliShopCommon;
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
        //static readonly IOwnersRepository InterfaceAdvancedML = new OwnersRepository();
        private IOwnersRepository _repository;

        public OwnersLogic()
        {
        }

        public OwnersLogic(IOwnersRepository _repository)
        {
            this._repository = _repository;
        }

        public DataSet GetAllOwners()
        {
            try
            {
                return _repository.GetAllOwners();
            }
            catch (Exception ee)
            {
                throw ee;

            }

        }
        public string PostOwner(OwnerModel ownerModel)
        {
            try
            {
                return _repository.PostOwner(ownerModel);
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
                return _repository.DeleteOwner(id);
            }
            catch (Exception ee)
            {
                throw ee;

            }

        }
        
    }
}

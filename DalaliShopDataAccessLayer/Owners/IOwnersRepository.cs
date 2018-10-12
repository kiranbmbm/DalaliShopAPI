using DalaliShopCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalaliShopDataAccessLayer
{

    public interface IOwnersRepository
    {
        DataSet GetAllOwners();
        string PostOwner(OwnerModel ownerModel);

        string DeleteOwner(int id);




    }
}

using DALLayer.DataAccess;
using MVCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IServices
{
    public interface IDataAccessServices
    {
        List<employee> getData(string searchKey);
        void deleteEmployee(int id);
    }
}

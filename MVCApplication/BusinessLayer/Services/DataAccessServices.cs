using BusinessLayer.IServices;
using DALLayer;
using DALLayer.DataAccess;
using MVCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class DataAccessServices: IDataAccessServices
    {
        private DataAccessRepository _dataAccessRepository;
        public DataAccessServices()
        {
            this._dataAccessRepository = new DataAccessRepository();
        }

        List<employee> IDataAccessServices.getData(string searchKey)
        {
            return _dataAccessRepository.getData(searchKey);
        }

        void IDataAccessServices.deleteEmployee(int id)
        {
            _dataAccessRepository.deleteEmployee(id);
        }

    }
}

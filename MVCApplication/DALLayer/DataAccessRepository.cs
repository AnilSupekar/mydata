using DALLayer.DataAccess;
using MVCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer
{
    public class DataAccessRepository
    {
        private EmployeeDBEntities _employeeDBEntities;
        public DataAccessRepository()
        {
            this._employeeDBEntities = new EmployeeDBEntities();
        }
        public List<employee> getData(string searchKey)
        {
            var result = _employeeDBEntities.STP_GetAllEmployeesSearch(searchKey).ToList();
            List<employee> employeelist = new List<employee>();
            foreach (var item in result)
            {
                employee empObj = new employee();
                empObj.EmpId = item.EmpId;
                empObj.EmpName = item.EmpName;
                empObj.Age = item.Age;
                empObj.Salary = item.Salary;
                empObj.EmpLocation = item.EmpLocation;
                employeelist.Add(empObj);
            }
            return employeelist; 
        }

        public void deleteEmployee(int id)
        {
            _employeeDBEntities.STP_DeleteEmployeeById(id);
        }

    }
}

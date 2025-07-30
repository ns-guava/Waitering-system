using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WaiteringSystem.Data;

namespace WaiteringSystem.Business
{
    
    public class EmployeeController
    {
        #region Data Members
        EmployeeDB employeeDB;
        Collection<Employee> employees;
        #endregion

        #region Properties
        public Collection<Employee> AllEmployees
        {
            get
            {
                return employees;
            }
        }
        #endregion

        #region Constructor
        public EmployeeController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            employeeDB = new EmployeeDB();
            employees = employeeDB.AllEmployees;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Employee anEmp,DB.DBOperation operation)
        {
            int index = 0;

            //perform a given database operation to the dataset in meory; 
            employeeDB.DataSetChange(anEmp,operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    employees.Add(anEmp); //*** Add the employee to the Collection
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(anEmp);
                    employees[index] = anEmp;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(anEmp);
                    employees.RemoveAt(index);
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Employee employee)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return employeeDB.UpdateDataSource(employee);
        }
        #endregion



        public Collection<Employee> FindByRole(Collection<Employee> emps, Role.RoleType roleVal)
        {
            Collection<Employee> matches = new Collection<Employee>();
            foreach (Employee emp in emps)
            {
                if(emp.role.getRoleValue == roleVal)
                {
                    matches.Add(emp); 
                }
            }
            return matches;
        }

        public Employee Find(string ID)
        {
            int index = 0;
            bool found = (employees[index].ID == ID);
            int count = employees.Count;

            while (!(found) && (index < employees.Count - 1))
            {
                index++;
                found = (employees[index].ID == ID);

            }

            return employees[index];
        }

        private int FindIndex(Employee anEmp)
        {
            int counter = 0;
            bool found = false;
            found = (anEmp.ID == employees[counter].ID);

            while (!found && counter < employees.Count) 
            {
                counter++;
                found = (anEmp.ID == employees[counter].ID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }


        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModel;

namespace MyApp.DBoperation
{
  public  class EmployeeRepository
    {
        public int AddEmployee(EmployeeModel model)
        {
            using (var context = new EmployeeDBEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                     Email= model.Email,
                      Code= model.Code
                };
               if (model.Address != null)
                {
                    emp.Address = new Address()
                    {
                        Details = model.Address.Details,
                        State = model.Address.State,
                        Country = model.Address.Country
                    };
                }
                context.Employee.Add(emp);
                context.SaveChanges();
                return emp.Id;
            }

            

        }
         
        public List<EmployeeModel> GetAllEmployees()
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = context.Employee.Select(x => new EmployeeModel()
                { 
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Code = x.Code,
                    AddressId= x.AddressId,
                    Address = new AddressModel()
                    { 
                        Id= x.Address.Id,
                        Details = x.Address.Details,
                        State = x.Address.State,
                        Country = x.Address.Country
                    }
                }).ToList();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Hello");
                }
            }
        }

        public EmployeeModel GetEmployee(int id)
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = context.Employee.Where(x=> x.Id == id).
                    Select(x => new EmployeeModel()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Code = x.Code,
                    AddressId = x.AddressId,
                    Address = new AddressModel()
                    {
                        Id = x.Address.Id,
                        Details = x.Address.Details,
                        State = x.Address.State,
                        Country = x.Address.Country
                    }
                }).FirstOrDefault();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Hello");
                }
            }
        }

        public bool UpdateEmployee(int id,EmployeeModel model)
        {
            using (var context = new EmployeeDBEntities())
            {
                var res = context.Employee.FirstOrDefault(x => x.Id == id);
                if(res != null)
                {
                    res.FirstName = model.FirstName;
                    res.LastName = model.LastName;
                    res.Email = model.Email;
                    res.AddressId = model.AddressId;
                    res.Code = model.Code;

                };
                context.SaveChanges();
                return true;
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = new Employee()
                {
                    Id = id
                };
                context.Entry(result).State = System.Data.Entity.EntityState.Deleted;
                //var result = context.Employee.FirstOrDefault(x => x.Id == id);
                //{
                //    if(result != null)
                //    {
                //        context.Employee.Remove(result);
                      context.SaveChanges();
                      return true;
                //    }
                //    return false;
                //}
            }
        }

    }
}

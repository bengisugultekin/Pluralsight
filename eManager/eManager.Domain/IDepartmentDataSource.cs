using System.Linq;

namespace eManager.Domain
{
    public interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees { get; set; }
        IQueryable<Department> Departments { get; set; }
    }
}

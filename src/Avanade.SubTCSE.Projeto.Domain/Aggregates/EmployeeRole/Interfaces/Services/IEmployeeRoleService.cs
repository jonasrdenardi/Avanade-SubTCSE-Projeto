using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Services
{
    public interface IEmployeeRoleService
    {
        public Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
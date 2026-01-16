using Project.Model.Common;
using Project.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Model.DTO;

namespace Project.Services.Interfaces
{
    public interface IPersonInformationService
    {
        Task<ServiceResponse<IEnumerable<Person_Information_DTO>>> GetAllPersonInfoAsync();
        Task<ServiceResponse<Person_Information_DTO>> GetPersonInfoByIdAsync(int id);
        Task<ServiceResponse<Person_Information_DTO>> CreatePersonInfoAsync(Person_Information_DTO person);
        Task<ServiceResponse<Person_Information_DTO>> UpdatePersonInfoAsync(Person_Information_DTO person);
        Task<ServiceResponse<object>> TogglePersonInfoStatus(int id);
    }
}
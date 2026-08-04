using Application.DTOs;

namespace Application.Interfaces
{
    public interface IRegistrationService
    {
        Task<List<GetRegistrationDTO>> GetAllRegistrationsAsync();
        Task<GetRegistrationDTO?> GetRegistrationByIdAsync(int id);
        Task AddRegistrationAsync(AddRegistrationDTO registration);
    }
}
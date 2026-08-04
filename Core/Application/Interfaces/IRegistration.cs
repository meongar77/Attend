using Application.DTOs;
namespace Application.Interfaces
{
    public interface IRegistration
    {
        Task<List<GetRegistrationDTO>> GetAllRegistrationsAsync();
        Task<GetRegistrationDTO?> GetRegistrationByIdAsync(int id);
        Task AddRegistrationAsync(AddRegistrationDTO registration);
        // Task<UpdateRegistrationDTO> UpdateRegistrationDTO(UpdateRegistrationDTO registration);
    }
    
}
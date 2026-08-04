using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.RegistrationServices
{
    public class RegistrationService:IRegistrationService
    {
        private readonly IRegistration _registration;
        public RegistrationService(IRegistration registration)
        {
            _registration=registration;
        }
        public async Task<List<GetRegistrationDTO>> GetAllRegistrationsAsync()
        {
           return await _registration.GetAllRegistrationsAsync();
        }
        public async Task AddRegistrationAsync(AddRegistrationDTO registration)
        {
            await _registration.AddRegistrationAsync(registration);
        }
        public async Task<GetRegistrationDTO?> GetRegistrationByIdAsync(int id)
        {
           return await _registration.GetRegistrationByIdAsync(id);
        }
        
    }
    
}
            
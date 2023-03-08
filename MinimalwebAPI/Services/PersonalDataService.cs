using MinimalwebAPI.Models;
using MinimalwebAPI.Repositories;

namespace MinimalwebAPI.Services
{
    public class PersonalDataService : IPersonalDataService
    {
        private readonly IPersonalDataRepository _personalDataRepository;
        public PersonalDataService(IPersonalDataRepository repo) => _personalDataRepository = repo; // class instead of IPersonalDataRepository

        public Task<(bool Result, PersonalData PersonalData)> CreateAsync(PersonalData personalData)
            => _personalDataRepository.CreateAsync(personalData);

        public Task<(bool Result, PersonalData PersonalData)> UpdateAsync(PersonalData personalData)
            => _personalDataRepository.UpdateAsync(personalData);

        public Task<bool> DeleteAsync(int id)
            => _personalDataRepository.DeleteAsync(id);

        public Task<(bool Result, PersonalData PersonalData)> GetAsync(int id)
            => _personalDataRepository.GetAsync(id);
    }
}

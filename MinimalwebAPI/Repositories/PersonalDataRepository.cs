using MinimalwebAPI.Models;

namespace MinimalwebAPI.Repositories
{
    public class PersonalDataRepository : IPersonalDataRepository
    {
        public PersonalDataRepository() { } // do I need the default constructor here?


        public Task<(bool Result, PersonalData PersonalData)> CreateAsync(PersonalData personalData)
            => Task.FromResult((true, personalData));

        public Task<(bool Result, PersonalData PersonalData)> UpdateAsync(PersonalData personalData)
            => Task.FromResult((true, personalData));

        public Task<bool> DeleteAsync(int id)
            => Task.FromResult(true);

        public Task<(bool Result, PersonalData PersonalData)> GetAsync(int id)
            => Task.FromResult((true, new PersonalData()
            {
                Id = 1,
                CountryOfBirth = "Poland",
                BirthDate = new DateTime(2000, 07, 09),
                FirstName = "Joe",
                LastName = "Doe"
            }
            ));
    }
}

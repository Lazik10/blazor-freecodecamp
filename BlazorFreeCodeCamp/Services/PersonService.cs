using BlazorFreeCodeCamp.ViewModels;

namespace BlazorFreeCodeCamp.Services
{
    // 2) We Implement the interface
    public class PersonService : IPersonService
    {
        private List<PersonViewModel> People { get; set; }

        public PersonService()
        {
            People = new List<PersonViewModel>
            {
                new() { Id = 1, FirstName = "Patrik", LastName = "Laska", IsActive = true, Salary = 10000 },
                new() { Id = 2, FirstName = "Tadeas", LastName = "Laska", IsActive = false, Salary = 20000 },
                new() { Id = 3, FirstName = "Michaela", LastName = "Laskova", IsActive = true, Salary = 15000 }
            };
        }

        public PersonViewModel? GetPersonById(int id)
        {
            return People.FirstOrDefault(x => x.Id == id);
        }

        public List<PersonViewModel> GetAllPeople()
        {
            return People;
        }
    }
}

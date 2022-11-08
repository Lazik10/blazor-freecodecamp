using BlazorFreeCodeCamp.ViewModels;

namespace BlazorFreeCodeCamp.Services
{
    // Dependency Injection
    // 1) First we create interface
    public interface IPersonService
    {
        PersonViewModel? GetPersonById(int id);

        List<PersonViewModel> GetAllPeople();
    }
}
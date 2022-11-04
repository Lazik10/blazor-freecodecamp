namespace BlazorFreeCodeCamp.ViewModels
{
    public class TeamViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;

        public List<PersonViewModel> TeamMembers = new List<PersonViewModel>();
    }
}

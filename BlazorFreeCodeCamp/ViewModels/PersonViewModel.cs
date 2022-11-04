namespace BlazorFreeCodeCamp.ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public decimal Salary { get; set; }

        public List<Address> Addresses = new();
    }
}

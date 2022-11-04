using Microsoft.AspNetCore.Components;

namespace BlazorFreeCodeCamp.Components.BaseComponents
{
    // We need to derive from ComponentBase
    public class DateTimeBaseComponent : ComponentBase
    {
        public DateTime dateTime { get; set; }
    }
}

using Microsoft.AspNetCore.Components;

namespace Blazor.Server
{
    public class RedirectToLogin : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            NavigationManager.NavigateTo("Identity/Account/Login", true);
            int x = 1;
            int y = 1;
            int a = x+y;
        }
    }
}
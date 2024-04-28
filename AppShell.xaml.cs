using VIEW.ViewModels;
using VIEW.Views;

namespace VIEW
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
           
        }
    }
}

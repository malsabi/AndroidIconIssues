using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AndroidIconIssues
{
    public partial class StudentsViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task NavigateHome()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
    }
}
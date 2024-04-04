using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AndroidIconIssues
{
    public partial class HomeViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task NavigateStudents()
        {
            await Task.Delay(3000);
            await Shell.Current.GoToAsync("//StudentsPage");
        }
    }
}
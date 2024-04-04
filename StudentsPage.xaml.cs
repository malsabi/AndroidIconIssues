namespace AndroidIconIssues;

public partial class StudentsPage : ContentPage
{
	public StudentsPage(StudentsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
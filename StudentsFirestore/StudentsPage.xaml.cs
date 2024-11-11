using StudentsFirestore.Services;
using StudentsFirestore.ViewModels;
namespace StudentsFirestore;

public partial class StudentsPage : ContentPage
{
	public StudentsPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentsViewModel(firestoreService);
	}
}
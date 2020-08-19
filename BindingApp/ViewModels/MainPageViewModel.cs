using BindingApp.Model;
using Prism.Navigation;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace BindingApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        private List<Student> _students;
        public List<Student> Students
        {
            get => _students;
            set => SetProperty(ref _students, value);
        }

        private bool _isLightText;
        public bool IsLightText
        {
            get => _isLightText;
            set => SetProperty(ref _isLightText, value);
        }

        private string _text = "Student name";
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        private ICommand _studentChosenCommand;
        public ICommand StudentChosenCommand => _studentChosenCommand ?? (_studentChosenCommand =
            new Command<Student>(OnStudentChosen));

        private ICommand _changeColorCommand;
        public ICommand ChangeColorCommand => _changeColorCommand ?? (_changeColorCommand =
            new Command(OnColorChangeRequested));

        private void OnColorChangeRequested()
        {
            IsLightText = !IsLightText;
        }

        private void OnStudentChosen(Student student)
        {
            Text = student.Name + student.Email;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Students = new List<Student>
            {
                new Student("Alexander", "sasha@mail.is", "78873577325"),
                new Student("Vasya", "sasha@mail.is", "78873577325"),
                new Student("Kolya", "sasha@mail.is", "78873577325"),
                new Student("Svyat", "sasha@mail.is", "78873577325")
            };
        }
    }
}

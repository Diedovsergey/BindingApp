using Prism.Mvvm;

namespace BindingApp.Model
{
    public class Student : BindableBase
    {
        public Student(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

    }
}

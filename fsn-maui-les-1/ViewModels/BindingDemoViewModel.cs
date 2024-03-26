using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace fsn_maui_les_1.ViewModels
{
    public class BindingDemoViewModel : INotifyPropertyChanged
    {
        // Example of a ViewModel without using the MVVM Community toolkit: can be simplified
        // DatePicker binding to C#11 DateOnly still open issue: https://github.com/dotnet/maui/issues/1100
        private DateOnly dayOfBirth;

        public DateOnly DayOfBirth
        {
            get { return dayOfBirth; }
            set
            {
                dayOfBirth = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayName));
            }
        }


        private string surName;

        public string SurName
        {
            get => surName;
            set
            {
                if (surName == value)
                    return;

                surName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        private string lastName;

        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName == value)
                    return;

                lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        public string DisplayName => $"{surName} {lastName} born on {dayOfBirth}";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

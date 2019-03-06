using Prism.Mvvm;
using System.ComponentModel;

namespace WPFValidationIDataErrorInfo
{
    public class MainViewModel : BindableBase, IDataErrorInfo
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged(); }
        }              

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged(); }
        }
        
        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;

                switch (columnName)
                {
                    case nameof(FirstName):
                        if (string.IsNullOrWhiteSpace(FirstName))
                            error = "First name cannot be empty.";
                        if (FirstName?.Length > 50)
                            error = "The name must be less than 50 characters.";
                        break;

                    case nameof(LastName):
                        if (string.IsNullOrWhiteSpace(LastName))
                            error = "Last name cannot be empty.";
                        break;
                }

                return error;
            }
        }

        public string Error => string.Empty;
    }
}

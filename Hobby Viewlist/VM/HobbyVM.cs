using Hobby_Viewlist.Command;
using Hobby_Viewlist.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hobby_Viewlist.VM
{
    public class HobbyVM : INotifyPropertyChanged
    {
		private ObservableCollection<Hobby> hobbies = new();

		public ObservableCollection<Hobby> Hobbies
        {
			get { return hobbies; }
			set { hobbies = value;
                OnPropertyChanged();
            }
		}
        private Hobby selectedHobby;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Hobby SelectedHobby
        {
            get { return selectedHobby; }
            set { selectedHobby = value;
                OnPropertyChanged();
            }
        }

        public DelegateCommand AddCommand { get; }

        public HobbyVM()
        {
            hobbies.Add(new Hobby() { Name = "Fotboll" });
            hobbies.Add(new Hobby() { Name = "Badminton" });
            hobbies.Add(new Hobby() { Name = "Golf" });

            AddCommand = new DelegateCommand(AddHobby);
        }


        private void OnPropertyChanged([CallerMemberName]string? propertyName = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddHobby(object? parameter)
        {
            Hobby hobby = new Hobby() { Name = "Ny" };
            Hobbies.Add(hobby);
            SelectedHobby = hobby;
        }
    }
}

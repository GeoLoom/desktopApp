using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GeoLoom.Data;
using GeoLoom.Model;

namespace GeoLoom.Views
{
    /*public class ArticleViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Article> Articles { get; set; }
        public Article EditingArticle { get; set; } = new Article();
        private Article _selectedArticle;
        public Article SelectedArticle
        {
            get => _selectedArticle;
            set
            {
                _selectedArticle = value;
                OnPropertyChanged();
                if (value != null)
                {
                    EditingArticle.ArticleId = value.ArticleId;
                    EditingArticle.Name = value.Name;
                    EditingArticle.Code = value.Code;
                    EditingArticle.FamilyId = value.FamilyId;
                }
            }
        }

        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }

        public ArticleViewModel()
        {
            Articles = new ObservableCollection<Article>(DBConnect.GetAllArticles());
            AddCommand = new RelayCommand(AddArticle);
            UpdateCommand = new RelayCommand(UpdateArticle, () => SelectedArticle != null);
            DeleteCommand = new RelayCommand(DeleteArticle, () => SelectedArticle != null);
        }

        private void AddArticle()
        {
            var newArticle = new Article
            {
                Name = EditingArticle.Name,
                Code = EditingArticle.Code,
                FamilyId = EditingArticle.FamilyId,
            };
            DBConnect.AddArticle(newArticle);
            Articles.Add(newArticle);
            ClearEditing();
        }

        private void UpdateArticle()
        {
            if (SelectedArticle == null) return;
            SelectedArticle.Name = EditingArticle.Name;
            SelectedArticle.Code = EditingArticle.Code;
            SelectedArticle.FamilyId = EditingArticle.FamilyId;
            DBConnect.UpdateArticle(SelectedArticle);
            var idx = Articles.IndexOf(SelectedArticle);
            if (idx >= 0)
            {
                Articles[idx] = SelectedArticle;
                OnPropertyChanged(nameof(Articles));
            }
            ClearEditing();
        }

        private void DeleteArticle()
        {
            if (SelectedArticle == null) return;
            DBConnect.DeleteArticle(SelectedArticle.ArticleId);
            Articles.Remove(SelectedArticle);
            ClearEditing();
        }

        private void ClearEditing()
        {
            EditingArticle = new Article();
            OnPropertyChanged(nameof(EditingArticle));
            SelectedArticle = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute; _canExecute = canExecute;
        }
        public bool CanExecute(object parameter) => _canExecute == null || _canExecute();
        public void Execute(object parameter) => _execute();
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    } */
}

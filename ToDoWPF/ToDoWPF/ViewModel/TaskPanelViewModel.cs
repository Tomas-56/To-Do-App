
using System.Collections.ObjectModel;
using ToDoWPF.Commands;
using ToDoWPF.Model;

namespace ToDoWPF.ViewModel
{
    internal class TaskPanelViewModel : BaseViewModel
    {
        TaskViewModel newTaskViewModel;
        public RelayCommand AddCommand { get; }
        public RelayCommand RemoveCommand { get; }

        private string _newTask;
        public string NewTask
        {
            get { return _newTask; }
            set { _newTask = value; }
        }


        private TaskViewModel selected;
		public TaskViewModel Selected
		{
			get { return selected; }
			set { selected = value; }
		}


        private ObservableCollection<TaskViewModel> _tasks;
        public ObservableCollection<TaskViewModel> Tasks
        {
            get { return _tasks; }
            set
            {
                _tasks = value;
            }
        }

        public TaskPanelViewModel()
        {
            _tasks = new ObservableCollection<TaskViewModel>();
            AddCommand = new RelayCommand(Add);
            RemoveCommand = new RelayCommand(Remove);
        }

        private void Add(object parameter) 
		{
            newTaskViewModel = new TaskViewModel(new TaskModel(NewTask, false));
			Tasks.Add(newTaskViewModel);
		}

        public void Remove(object parameter) 
        {
           Tasks.Remove(Selected);
        }
        


    }
}

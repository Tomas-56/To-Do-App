 
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using ToDoWPF.Commands;
using ToDoWPF.Model;

namespace ToDoWPF.ViewModel
{
    internal class TaskPanelViewModel : BaseViewModel
    {
        public static string taskNamePath = @"..\..\TasksData.txt";
        List<string> tasksStrings;
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
            tasksStrings = new List<string>();

            tasksStrings = File.ReadAllLines(taskNamePath).ToList();

            for (int i = 0; i < tasksStrings.Count; i++) 
            {
                Tasks.Add(new TaskViewModel(new TaskModel(tasksStrings.ElementAt(i),false)));
            }
        }

        private void Add(object parameter) 
		{
            newTaskViewModel = new TaskViewModel(new TaskModel(NewTask, false));
			Tasks.Add(newTaskViewModel);
            tasksStrings.Add(NewTask);
            File.WriteAllLines(taskNamePath, tasksStrings);
		}

        public void Remove(object parameter) 
        {
            if (Selected != null) { 

            List<string> temp = new List<string>();
            foreach (var taskString in tasksStrings) 
            {
                if (!taskString.Equals(Selected.Description)) 
                {
                    temp.Add(taskString);
                }
            }

            File.WriteAllLines(taskNamePath, temp);
            tasksStrings = temp;
            Tasks.Remove(Selected);

            }
        }
    }
}


using System.Windows;
using ToDoWPF.Commands;
using ToDoWPF.Model;

namespace ToDoWPF.ViewModel
{
    internal class TaskViewModel : BaseViewModel
    {
        public string isDoneData = @"..\..\IsDoneData.txt";
        private TaskModel _taskModel;
        public RelayCommand SetDoneCommand { get; }

        private TextDecorationCollection _strikeDecoration;
        public TextDecorationCollection StrikeDecoration
        {
            get { return _strikeDecoration; }
            set { _strikeDecoration = value; OnPropertyChanged("StrikeDecoration"); }
        }

        public string Description { get { return _taskModel.Description; } set { _taskModel.Description = value; OnPropertyChanged("Description"); } }
        public bool IsDone { get { return _taskModel.IsDone; } set { _taskModel.IsDone = value; } }


        public TaskViewModel(TaskModel taskModel)
        {
            _taskModel = taskModel;
            SetDoneCommand = new RelayCommand(SetDone);
        }

        public void SetDone(object parameter) 
        {
            if (IsDone == true)
            {
                StrikeDecoration = new TextDecorationCollection(TextDecorations.Strikethrough);
            }
            else 
            {
                StrikeDecoration = new TextDecorationCollection();
            }

            IsDone = !IsDone;
        }
    }
}



namespace ToDoWPF.Model
{
    internal class TaskModel
    {
		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private bool _isDone;

		public bool IsDone
		{
			get { return _isDone; }
			set { _isDone = value; }
		}

        public TaskModel(string description, bool isDone)
        {
			this.Description = description;
			this.IsDone = isDone;
        }
    }
}

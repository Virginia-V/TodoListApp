namespace TodoListApp
{
    public class TodoItem
    {
        public string TodoText { get; set; }
        public bool Complete { get; set; }
        public TodoItem(string todoText, bool complete)
        {
            TodoText = todoText;
            Complete = complete;
        }
    }
}

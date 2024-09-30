namespace KTodo.Types;

public class TodoItem
{
    public TodoItem(string header)
    {
        Header  = header;
        Caption = string.Empty;
        Done    = false;
    }

    public string Header { get; set; }
    public string Caption { get; set; }
    public bool? Done { get; set; }
}
using Fluxor;

namespace TodoList.State.Todos{
[FeatureState]
  public class TodosState
  {
    public IList<TodoItem> Todos { get; }
    private TodosState() {
      Todos = new List<TodoItem>();
    }
    public TodosState(IList<TodoItem> todos)
    {
      Todos = todos;
    }
  }
}

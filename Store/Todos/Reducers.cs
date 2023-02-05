using Fluxor;

namespace TodoList.State.Todos
{
  public static class Reducers
  {
    [ReducerMethod]
    public static TodosState ReduceAddTodoItemAction(TodosState state, AddTodoItemAction action){
      state.Todos.Add(new TodoItem{ Title= action.Title});
      return state;
    }
  };
};
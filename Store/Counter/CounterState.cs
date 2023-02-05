using Fluxor;

namespace TodoList.State.Counter;

[FeatureState]
public class CounterState
{
  public int ClickCount {get;}
  private CounterState() {}
  public CounterState(int clickCount)
  {
    ClickCount = clickCount;
  }
}
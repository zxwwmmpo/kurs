namespace InsertionSearchArray;

/// <summary>
/// класс-хранилище
/// </summary>
public class Storage
{
    public List<Condition> _conditions;

    public Storage()
    {
        _conditions = new List<Condition>();
    }

    public void AddStorage(Condition condition)
    {
        _conditions.Add(condition);
    }

    public IEnumerable<object> IterateStates()
    {
        for (int i = 0; i < _conditions.Count; i++)
        {
            yield return _conditions[i];
        }
    }
}


namespace InsertionSearch_2;
/// <summary>
/// класс - состояние 
/// </summary>
[Serializable]
public class Status
{
    public int[] dataArray { get; }
    public int Index { get; } //надо ли?

    public Status(int[] _dataArray, int index)
    {
        dataArray = new int[_dataArray.Length];
        for (int i = 0; i < _dataArray.Length; i++)
        {
            this.dataArray[i] = _dataArray[i];
        }
        Index = index;
    }
}

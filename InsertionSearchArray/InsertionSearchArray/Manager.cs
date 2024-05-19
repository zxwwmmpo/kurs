using System.Data.SqlTypes;

namespace InsertionSearchArray;

/// <summary>
/// класс-управленец
/// </summary>
public class Manager
{
    public Realizer? _realizer;
    public Parametrs? _parametrs;
    public Condition? _condition;
    public Storage? _storage;

    public void realizer()
    {
        _realizer = new Realizer(_parametrs._dataArray, _parametrs._index, _parametrs._value);
    }

    public Manager(Parametrs param)
    {
        _parametrs = param;
        _storage = new Storage();
    }

    public void PerformOperation()
    {

        realizer();

        int[] dataArray = _realizer!.dataArray;

        _realizer.ReSize(ref dataArray);
        //for (int i = dataArray.Length-1; i > _parametrs._index; i--)



        for (int j = dataArray.Length - 1; j > _parametrs._index; j--)
        {
            int c = dataArray[j - 1];
            dataArray[j] = c;
            _storage!.AddStorage(_realizer.SaveCondition((int[])dataArray.Clone(), j));
        }



        //_storage!.AddStorage(_realizer.SaveCondition((int[])dataArray.Clone(), i));



        _realizer.AddElementByIndex(ref dataArray, _parametrs._index, _parametrs._value);
        _storage!.AddStorage(_realizer.SaveCondition((int[])dataArray.Clone(), 0));


        //запись в хранилище
    }
}

namespace InsertionSearch_2;

public class Manager
{
    public Storage storage { get; }    
    public Realizer realizer { get; }

    public Manager(Parametrs parametrs)
    {
        realizer = new Realizer(parametrs);
        storage = new Storage();
    }

    //public Manager(Parametrs parametrs)
    //{
    //    this.realizer = new Realizer(parametrs);
    //    this.storage = new Storage();
    //    //this.parametrs = parametrs;
    //}

    //public Storage PerfomOperation()
    //{
    //    realizer = new Realizer(parametrs);
    //    Status obj1 = realizer.GetStatus();
    //    storage.Add(obj1);

    //    while (realizer.AbleToStep())
    //    {
    //        realizer.MakeStep();
    //        Status obj2 = realizer.GetStatus();
    //        storage.Add(obj2);
    //    }

    //    return storage;
    //}

}

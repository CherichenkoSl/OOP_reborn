//Build x = new Build();
//x.Floor = 10;
//x.Height = 45;
Build b = Creator.CreateBuild();
Console.WriteLine(b.Height);
public class Build
{
    private static int _id = 1;
    private int _id2;
    private int _height;
    private int _floor;
    private int _numberOfFloats;
    private int _entrance;
    public int Id { get { return _id2; } }
    public int Height { get { return _height; } set { _height = value; } }
    public int Floor { get { return _floor; } set { _floor = value; } }
    public int NumberOfFloats { get { return _numberOfFloats; } set { _numberOfFloats = value; } }
    public int Entrance { get { return _entrance; } set { _entrance = value; } }
    internal Build():this(40,9,108,3)
    {
    }
    internal Build(int height,int floor, int numberOfFloats, int entrance)
    {
        _height = height;
        _floor = floor;
        _numberOfFloats = numberOfFloats;
        _entrance = entrance;
        UniqueID();
    }
    private void UniqueID()
    {
        _id2 = _id;
        _id++;
    }
    public static int GetHeightFloor(Build build)
    {
        int result;
        result= build._height/build._floor;
        return result;
    }
    public int GetNumberOfFLoatsInEntrance()
    {
         int result = _numberOfFloats / _entrance;
        return result;
    }
    public int GetNumverOfFloatsInFloor()
    {
        int result =GetNumberOfFLoatsInEntrance()/_floor;
        return result;
    }
}
public class Creator
{
    private Creator()
    {

    }
    public static Build CreateBuild()
    {
        Build fac = new Build();
        return fac;
    }
}


namespace LinesCounter
{
    public interface IFileNameFilter
    {
        bool DoFilter(string name);
    }
}
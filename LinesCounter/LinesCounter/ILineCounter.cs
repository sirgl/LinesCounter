using System.Collections.Generic;

namespace LinesCounter
{
    public interface ILineCounter
    {
        Dictionary<LineType, int> countLines();
    }
}
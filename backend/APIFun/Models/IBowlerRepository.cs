using APIFun.Models;

namespace APIFun.Models
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
    }
}

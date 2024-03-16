namespace APIFun.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueThisOneContext _BowlingLeagueThisOneContext;
        public EFBowlerRepository(BowlingLeagueThisOneContext temp) { 
        _BowlingLeagueThisOneContext = temp;
        }

        IEnumerable<Bowler> IBowlerRepository.Bowlers => _BowlingLeagueThisOneContext.Bowlers;
    }
}

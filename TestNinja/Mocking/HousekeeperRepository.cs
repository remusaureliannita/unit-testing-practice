using System.Linq;

namespace TestNinja.Mocking
{
    public interface IHousekeeperRepository
    {
        IQueryable<Housekeeper> GetHousekeepers();
    }

    public class HousekeeperRepository : IHousekeeperRepository
    {
        private readonly UnitOfWork _unitOfWork;

        public HousekeeperRepository()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IQueryable<Housekeeper> GetHousekeepers()
        {
            var housekeepers = _unitOfWork.Query<Housekeeper>();

            return housekeepers;
        }
    }
}

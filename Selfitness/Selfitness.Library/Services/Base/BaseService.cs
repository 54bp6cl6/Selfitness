using Selfitness.Library.DbModels;

namespace Selfitness.Library.Services
{
    public class BaseService
    {
        protected readonly SelfitnessDbContext _db;
        public BaseService(BaseServiceArgument argument)
        {
            _db = argument.Db;
        }
    }

    public class BaseServiceArgument
    {
        public SelfitnessDbContext Db { get; set; }

        public BaseServiceArgument(SelfitnessDbContext db)
        {
            Db = db;
        }
    }
}

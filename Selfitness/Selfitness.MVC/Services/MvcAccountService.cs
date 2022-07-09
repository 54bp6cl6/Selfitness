using Selfitness.Library.Services;

namespace Selfitness.MVC.Services
{
    public class MvcAccountService : AccountService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MvcAccountService(BaseServiceArgument baseArgument, 
            IHttpContextAccessor httpContextAccessor) : base(baseArgument)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void Login(string account)
        {
            if (_httpContextAccessor.HttpContext != null)
                _httpContextAccessor.HttpContext.Session.SetString("Account", account);
        }

        public bool IsLogedIn()
        {
            if (_httpContextAccessor.HttpContext != null)
                return _httpContextAccessor.HttpContext.Session.GetString("Account") != null;
            return false;
        }
    }
}

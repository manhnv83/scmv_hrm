using Mvc5Application1.Business.Contracts;
using Mvc5Application1.Business.Contracts.Security;
using Mvc5Application1.Data.Model;
using Mvc5Application1.Framework.Caching;
using System.Linq;
using System.Threading;

namespace Mvc5Application1.Business.Security
{
    /// <summary>
    /// Class AuthorizationBusiness
    /// </summary>
    public class AuthorizationBusiness : IAuthorizationBusiness
    {
        private readonly IRepository<UserProfile> _userProfileRepository;
        private readonly ISecurityMatrixRepository _securityMatrixRepository;
        private readonly ICacheManager _cacheManager;

        public AuthorizationBusiness(ISecurityMatrixRepository securityMatrixRepository, ICacheManager cacheManager, IRepository<UserProfile> userProfileRepository)
        {
            _securityMatrixRepository = securityMatrixRepository;
            _cacheManager = cacheManager;
            _userProfileRepository = userProfileRepository;
        }

        public bool CheckPermission(string function)
        {
            var user = _userProfileRepository.GetAll().FirstOrDefault(x => x.UserName == Thread.CurrentPrincipal.Identity.Name);

            if (user != null && (user.IsGroupAdmin == true && function == "Add User roles"))
                return true;

            var securityMappingList = _securityMatrixRepository.GetSecurityMatrix();

            var securityMatrixDict = new SecurityMatrixDict(securityMappingList);

            _cacheManager.Clear();

            _cacheManager.Set("SecurityMatrixDict", securityMatrixDict, 120);

            return securityMatrixDict.GetValue(function) && user != null && user.IsGroupAdmin == true;
        }
    }
}
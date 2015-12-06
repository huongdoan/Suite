using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

using AngularJSSuite.Models;
using Microsoft.AspNet.Http.Authentication;
using System.Security.Claims;

namespace AngularJSSuite
{
    [Route("api/[controller]")]
    public class MainController : Controller
    {

        private AuthenticationManager AuthenticationManager
        {
            get
            {
                return Context.Authentication;
            }
        }


        /// <summary>
        /// Initialize Application
        /// </summary>
        /// <returns></returns>
        [Route("AuthenicateUser")]
        [HttpGet]
        public TransactionalInformation AuthenicateUser(string route)
        {
            TransactionalInformation transaction = new TransactionalInformation();
            transaction.IsAuthenicated = User.Identity.IsAuthenticated;
            return transaction;

        }

        [Route("Logout")]
        [HttpGet]
        public TransactionalInformation Logout()
        {
            TransactionalInformation transaction = new TransactionalInformation();
            transaction.IsAuthenicated = false;
            AuthenticationManager.SignOut();
            return transaction;

        }

        // POST api/values
        /// <summary>
        /// Initialize Application
        /// </summary>
        /// <returns></returns>
        [Route("InitializeApplication")]
        [HttpGet]
        public ApplicationApiModel InitializeApplication()
        {


            return null;

        }

        [Route("Login")]
        [HttpPost]
        public ActionResult Login()
        {
            AuthenticationManager.SignOut("Cookies");

            // var identity = await CustomUserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            var claims = new List<Claim>
            {
                new Claim("sub", "username"),
                new Claim("name", "bob"),
                new Claim("email", "bob@smith.com")
            };
            var id = new ClaimsIdentity(claims, "local", "name", "role");

            AuthenticationManager.SignIn("Cookies", new ClaimsPrincipal(id));//http://leastprivilege.com/2015/07/21/the-state-of-security-in-asp-net-5-and-mvc-6-claims-authentication/
            return null;
        }


    }
}

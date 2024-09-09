using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace api.Extensions
{
    public static class ClaimsExtension
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            var claim = user?.Claims.SingleOrDefault(x => x.Type == "https://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname");
            return claim?.Value; // Return null if claim is not found
        }

    }

}
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
            return user.Claims.SingleOrDefault(x => x.Type.Equals("https://www.youtube.com/redirect?event=video_description&redir_token=QUFFLUhqbTRic3g0VUhSVGFoMERVSVhlZ1gzNHBwNlNhd3xBQ3Jtc0trdnBqLUl5bVpLc01FX1RBcjBBNUhWSjBqOG52MWNUZlktbUNxcncwX211MVdrUExDQVFZd3BOWFdPZEZ1dVpiNmo4ckVPN1R3eGZpc2RGSE1uMWx0SkxMS25tQk1PU1dmcjF3d05Vbk1ndE5XWDdTRQ&q=http%3A%2F%2Fschemas.xmlsoap.org%2Fws%2F2005%2F05%2Fidentity%2Fclaims%2Fgivenname&v=wbD-XUmoeqw")).Value;

        }
    }
}
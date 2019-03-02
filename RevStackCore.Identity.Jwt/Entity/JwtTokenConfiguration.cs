using System;

namespace RevStackCore.Identity.Jwt
{
    public class JwtTokenConfiguration
    {
        public string Secret { get; set; }
        public JwtPayload Payload { get; set; }
    }
}

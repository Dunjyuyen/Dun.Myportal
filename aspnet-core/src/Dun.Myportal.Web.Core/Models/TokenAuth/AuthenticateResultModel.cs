using System;

namespace Dun.Myportal.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public Exception exception { get; set; }
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public long UserId { get; set; }
    }
}

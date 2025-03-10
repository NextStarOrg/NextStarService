﻿namespace NextStar.Library.Core.Consts;

public class NextStarApplicationName
{
    public const string CookieExpiredSeconds = "CookieExpiredSeconds";

    public const string IsAllowPasswordLogin = "IsAllowPasswordLogin";
    public static class GoogleLoginProvider
    {
        public const string GoogleLoginClientId = "GoogleLoginClientId";
        public const string GoogleLoginClientSecret = "GoogleLoginClientSecret";
        public const string GoogleLoginRedirectUri = "GoogleLoginRedirectUri";
        public const string GoogleLoginScope = "GoogleLoginScope";
        // https://accounts.google.com/.well-known/openid-configuration
        public const string GoogleLoginOpenIdUri = "GoogleLoginOpenIdUri";
    }
        
    public static class MicrosoftLoginProvider
    {
        public const string MicrosoftLoginClientId = "MicrosoftLoginClientId";
        public const string MicrosoftLoginClientSecret = "MicrosoftLoginClientSecret";
        public const string MicrosoftLoginRedirectUri = "MicrosoftLoginRedirectUri";
        public const string MicrosoftLoginScope = "MicrosoftLoginScope";
        // https://login.microsoftonline.com/common/v2.0/.well-known/openid-configuration
        public const string MicrosoftLoginOpenIdUri = "MicrosoftLoginOpenIdUri";
    }
}
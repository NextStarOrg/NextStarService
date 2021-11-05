﻿using Newtonsoft.Json;

namespace NextStar.Framework.Abstractions.OAuth2
{
    public class OAuth2Configuration
    {
        [JsonProperty("code")] public string ResponseType { get; set; }
        [JsonProperty("client_id")] public string ClientId { get; set; }
        [JsonProperty("client_secret")] public string ClientSecret { get; set; }
        [JsonProperty("redirect_uri")] public string RedirectUri { get; set; }
        [JsonProperty("grant_type")] public string GrantType { get; set; }
    }
}
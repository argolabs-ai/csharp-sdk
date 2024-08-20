using System.Net.Http;

namespace ArgoLabs.net.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}

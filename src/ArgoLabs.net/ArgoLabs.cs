using ArgoLabs.net.Core;

#nullable enable

namespace ArgoLabs.net;

public partial class ArgoLabs
{
    private RawClient _client;

    public ArgoLabs(string? apiKeyAuthScheme = null, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "x-api-key", apiKeyAuthScheme },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "ArgoLabs.net" },
                { "X-Fern-SDK-Version", Version.Current },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
    }
}

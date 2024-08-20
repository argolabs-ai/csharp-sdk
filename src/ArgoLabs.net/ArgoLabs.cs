using System;
using ArgoLabs.net.Core;

#nullable enable

namespace ArgoLabs.net;

public partial class ArgoLabs
{
    private RawClient _client;

    public ArgoLabs(ClientOptions? clientOptions = null)
    {
        _client = new RawClient(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "ArgoLabs.net" },
                { "X-Fern-SDK-Version", "0.0.1" },
            },
            new Dictionary<string, Func<string>>() { },
            clientOptions ?? new ClientOptions()
        );
    }
}

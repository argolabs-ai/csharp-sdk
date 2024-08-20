using System;

#nullable enable

namespace ArgoLabs.net;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class ArgoLabsException(string message, Exception? innerException = null)
    : Exception(message, innerException) { }

using NightTasker.Common.Messaging.Events.Contracts;

namespace NightTasker.Common.Messaging.Events.Implementations;

/// <inheritdoc />
public class UserRegistered(Guid id, string userName, string email) : IUserRegistered
{
    /// <inheritdoc />
    public Guid Id { get; } = id;

    /// <inheritdoc />
    public string UserName { get; } = userName;
    
    /// <inheritdoc />
    public string Email { get; } = email;
}
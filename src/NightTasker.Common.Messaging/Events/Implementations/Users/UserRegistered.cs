using NightTasker.Common.Messaging.Events.Contracts.Users;

namespace NightTasker.Common.Messaging.Events.Implementations.Users;

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
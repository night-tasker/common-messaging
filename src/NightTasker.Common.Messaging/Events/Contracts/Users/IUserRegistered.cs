namespace NightTasker.Common.Messaging.Events.Contracts.Users;

/// <summary>
/// Событие регистрации пользователя.
/// </summary>
public interface IUserRegistered
{
    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string UserName { get; }

    /// <summary>
    /// Электронная почта.
    /// </summary>
    public string Email { get; }
}
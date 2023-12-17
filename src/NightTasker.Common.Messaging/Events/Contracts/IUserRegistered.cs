namespace NightTasker.Common.Messaging.Events.Contracts;

/// <summary>
/// Событие регистрации пользователя.
/// </summary>
public interface IUserRegistered
{
    public Guid Id { get; }

    public string UserName { get; }
}
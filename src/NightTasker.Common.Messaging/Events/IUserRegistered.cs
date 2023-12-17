namespace NightTasker.Common.Messaging.Events;

/// <summary>
/// Событие регистрации пользователя.
/// </summary>
public interface IUserRegistered
{
    public Guid Id { get; }

    public string UserName { get; set; }
}
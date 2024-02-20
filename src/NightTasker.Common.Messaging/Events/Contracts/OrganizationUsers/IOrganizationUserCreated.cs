using NightTasker.Common.Messaging.Enums;

namespace NightTasker.Common.Messaging.Events.Contracts.OrganizationUsers;

public interface IOrganizationUserCreated
{
    Guid Id { get; }
    
    Guid UserId { get; }
    
    Guid OrganizationId { get; }
    
    OrganizationUserRole Role { get; }
}
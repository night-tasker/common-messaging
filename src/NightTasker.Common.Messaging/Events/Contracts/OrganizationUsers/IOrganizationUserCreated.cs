using NightTasker.Common.Messaging.Enums;

namespace NightTasker.Common.Messaging.Events.Contracts.OrganizationUsers;

public interface IOrganizationUserCreated
{
    Guid UserId { get; }
    
    Guid OrganizationId { get; }
    
    OrganizationUserRole Role { get; }
}
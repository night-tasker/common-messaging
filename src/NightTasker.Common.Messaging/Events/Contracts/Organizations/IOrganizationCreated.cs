using NightTasker.Common.Messaging.DataTransferObjects.Organizations;

namespace NightTasker.Common.Messaging.Events.Contracts.Organizations;

public interface IOrganizationCreated
{
    Guid Id { get; }
    
    IReadOnlyCollection<OrganizationUserDto> Users { get; }
}
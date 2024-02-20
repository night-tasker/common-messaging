using NightTasker.Common.Messaging.DataTransferObjects.Organizations;
using NightTasker.Common.Messaging.Events.Contracts.Organizations;

namespace NightTasker.Common.Messaging.Events.Implementations.Organizations;

public sealed record OrganizationCreated(
    Guid Id, IReadOnlyCollection<OrganizationUserDto> Users) : IOrganizationCreated;
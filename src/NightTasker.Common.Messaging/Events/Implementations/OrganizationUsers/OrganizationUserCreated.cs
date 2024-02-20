using NightTasker.Common.Messaging.Enums;
using NightTasker.Common.Messaging.Events.Contracts.OrganizationUsers;

namespace NightTasker.Common.Messaging.Events.Implementations.OrganizationUsers;

public sealed record OrganizationUserCreated(
    Guid Id, Guid UserId, Guid OrganizationId, OrganizationUserRole Role) : IOrganizationUserCreated;
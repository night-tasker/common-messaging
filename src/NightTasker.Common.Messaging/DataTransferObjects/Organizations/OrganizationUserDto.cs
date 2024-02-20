using NightTasker.Common.Messaging.Enums;

namespace NightTasker.Common.Messaging.DataTransferObjects.Organizations;

public record OrganizationUserDto(Guid UserId, Guid OrganizationId, OrganizationUserRole Role);
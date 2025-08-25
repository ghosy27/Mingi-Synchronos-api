using MingiSynchronos.API.Data;
using MingiSynchronos.API.Data.Enum;
using MessagePack;

namespace MingiSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);
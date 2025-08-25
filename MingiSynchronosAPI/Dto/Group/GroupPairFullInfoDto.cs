using MingiSynchronos.API.Data;
using MingiSynchronos.API.Data.Enum;
using MessagePack;

namespace MingiSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairFullInfoDto(GroupData Group, UserData User, UserPermissions SelfToOtherPermissions, UserPermissions OtherToSelfPermissions) : GroupPairDto(Group, User);
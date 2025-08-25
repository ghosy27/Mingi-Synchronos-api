using MingiSynchronos.API.Data;
using MingiSynchronos.API.Data.Enum;
using MessagePack;

namespace MingiSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserInfoDto(GroupData Group, UserData User, GroupPairUserInfo GroupUserInfo) : GroupPairDto(Group, User);
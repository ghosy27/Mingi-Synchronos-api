using MingiSynchronos.API.Data;
using MingiSynchronos.API.Data.Enum;
using MessagePack;

namespace MingiSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserIndividualPairStatusDto(UserData User, IndividualPairStatus IndividualPairStatus) : UserDto(User);
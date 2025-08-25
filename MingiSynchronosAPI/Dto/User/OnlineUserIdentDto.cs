using MingiSynchronos.API.Data;
using MessagePack;

namespace MingiSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserIdentDto(UserData User, string Ident) : UserDto(User);
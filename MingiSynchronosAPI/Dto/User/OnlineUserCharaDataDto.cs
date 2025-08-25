using MingiSynchronos.API.Data;
using MessagePack;

namespace MingiSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserCharaDataDto(UserData User, CharacterData CharaData) : UserDto(User);
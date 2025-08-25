using MingiSynchronos.API.Data;
using MessagePack;

namespace MingiSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserCharaDataMessageDto(List<UserData> Recipients, CharacterData CharaData, CensusDataDto? CensusDataDto);

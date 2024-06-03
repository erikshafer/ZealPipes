namespace ZealPipes.Esdb.Events.ChatLogs;

public record NonPlayableCharacterSaid : ChatLineRecorded
{
    public string NpcName { get; init; } = string.Empty;
}
namespace ZealPipes.Esdb.Events.ChatLogs;

public record ChatChannelRecorded : ChatLineRecorded
{
    public string ChannelName { get; set; } = string.Empty;
}
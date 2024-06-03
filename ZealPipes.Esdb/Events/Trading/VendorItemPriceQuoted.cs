namespace ZealPipes.Esdb.Events.Trading;

public record VendorItemPriceQuoted : ChatLineRecorded
{
    public string ItemName { get; set; } = string.Empty;
    public ushort Platinum { get; set; } = 0;
    public ushort Gold { get; set; } = 0;
    public ushort Silver { get; set; } = 0;
    public ushort Copper { get; set; } = 0;
    public ushort PlayerCharacterCharismaWhenQuoted { get; set; }
}
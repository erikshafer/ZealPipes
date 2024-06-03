namespace ZealPipes.Esdb.Events;

// ZealService(Log)> proc:9132  char:Xarkoris  type:LogText  text:You say, 'test test, mic 1 2 3!'
// ZealService(Log)> proc:9132  char:Xarkoris  type:LogText  text:Joranak auctions, 'WTS 0004274Curscale Shawl, 0004280Curscale Leggings ..2gp each'
// ZealService(Log)> proc:9132  char:Xarkoris  type:LogText  text:Vessel Kabda tells you, 'That'll be 5 gold for the Spell: Gate.'
// ZealService(Log)> proc:9132  char:Xarkoris  type:LogText  text:Vessel Kabda tells you, 'That'll be 1 gold 2 silver 5 copper for the Spell: Strengthen.'
// ZealService(Log)> proc:9132  char:Xarkoris  type:LogText  text:Fuunk says out of character, 'have this for trade any other piece 0004274Curscale Shawl'
public record ChatLineRecorded
{
    public int Proc { get; init; } = -1;
    public string CharacterRecorded { get; init; } = string.Empty;
    public string CharacterObserved { get; set; } = string.Empty;
    public string Type { get; init; } = "LogText";
    public string Text { get; init; } = string.Empty;
    public string Channel { get; set; } = "Unknown"; // default to 'Say'?
}
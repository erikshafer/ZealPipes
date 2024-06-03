namespace ZealPipes.Esdb.Events.CombatLogs;

public record SpellCastRecorded : ChatLineRecorded
{
    public string SpellName { get; set; } = string.Empty;
}
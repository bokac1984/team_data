using Newtonsoft.Json;
using System;

public partial class PlayerStats
{
    public ChessDaily Chess_Daily { get; set; }
    public ChessDaily Chess960_Daily { get; set; }
    public Chess Chess_Rapid { get; set; }
    public Chess Chess_Bullet { get; set; }
    public Chess Chess_Blitz { get; set; }
    public long Fide { get; set; }
    public Lessons Tactics { get; set; }
    public Lessons Lessons { get; set; }
    public PuzzleRush Puzzle_Rush { get; set; }
}

public partial class ChessDaily
{
    public Last Last { get; set; }
    public Best Best { get; set; }
    public DailyRecord Record { get; set; }
    public Tournament Tournament { get; set; }
}

public partial class Best
{
    public long Rating { get; set; }
    public long Date { get; set; }
    public Uri Game { get; set; }
}

public partial class Last
{
    public long Rating { get; set; }
    public long Date { get; set; }
    public long Rd { get; set; }
}

public partial class DailyRecord
{
    public long Win { get; set; }
    public long Loss { get; set; }
    public long Draw { get; set; }
    [JsonProperty("time_per_move")]
    public long TimePerMove { get; set; }
    [JsonProperty("timeout_percent")]
    public long TimeoutPercent { get; set; }
}

public partial class Tournament
{
    public long Points { get; set; }
    public long Withdraw { get; set; }
    public long Count { get; set; }
    public long HighestFinish { get; set; }
}

public partial class Chess
{
    public Last Last { get; set; }
    public Best Best { get; set; }
    public ChessBlitzRecord Record { get; set; }
}

public partial class ChessBlitzRecord
{
    public long Win { get; set; }
    public long Loss { get; set; }
    public long Draw { get; set; }
}

public partial class Lessons
{
    public Est Highest { get; set; }
    public Est Lowest { get; set; }
}

public partial class Est
{
    public long Rating { get; set; }
    public long Date { get; set; }
}

public partial class PuzzleRush
{
    public PuzzleRushBest Best { get; set; }
}

public partial class PuzzleRushBest
{
    public long TotalAttempts { get; set; }
    public long Score { get; set; }
}

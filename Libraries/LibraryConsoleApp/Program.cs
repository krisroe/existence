
using NationalFootballLeagueLibrary;

foreach (GameScoreInfo gsi in NationalFootballLeagueLibrary.Library.ProcessAllGameScores())
{
    Console.WriteLine(gsi.ToString());
}

Console.ReadLine();
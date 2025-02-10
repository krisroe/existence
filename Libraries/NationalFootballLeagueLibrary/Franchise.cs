
namespace NationalFootballLeagueLibrary
{
    public class FranchiseInfo
    {
        /// <summary>
        /// list of franchises
        /// </summary>
        public List<Franchise> Franchises { get; set; }

        /// <summary>
        /// base franchise names
        /// </summary>
        public List<string> BaseFranchiseNames { get; set; }

        /// <summary>
        /// franchise mapping
        /// </summary>
        public Dictionary<string, Franchise> FranchiseMapping { get; set; }
        
        /// <summary>
        /// constructor
        /// </summary>
        public FranchiseInfo()
        {
            Franchises = new List<Franchise>()
            {
                new Franchise("Arizona Cardinals", "Chicago Cardinals", "St. Louis Cardinals"),
                new Franchise("Atlanta Falcons"),
                new Franchise("Baltimore Ravens"),
                new Franchise("Buffalo Bills")
                {
                    StartingYear = 1960 //ignore AAFC version of Buffalo Bills
                },
                new Franchise("Carolina Panthers"),
                new Franchise("Chicago Bears", "Chicago Staleys", "Decatur Staleys"),
                new Franchise("Cincinnati Bengals"),
                new Franchise("Cleveland Browns"),
                new Franchise("Dallas Cowboys"),
                new Franchise("Denver Broncos"),
                new Franchise("Detroit Lions", "Portsmouth Spartans"),
                new Franchise("Green Bay Packers"),
                new Franchise("Houston Texans"),
                new Franchise("Indianapolis Colts", "Baltimore Colts")
                {
                    StartingYear = 1953 //ignore Miami Seahawks version that is not part of franchise history
                },
                new Franchise("Jacksonville Jaguars"),
                new Franchise("Kansas City Chiefs", "Dallas Texans"),
                new Franchise("Las Vegas Raiders", "Los Angeles Raiders", "Oakland Raiders"),
                new Franchise("Los Angeles Chargers", "San Diego Chargers"),
                new Franchise("Los Angeles Rams", "Cleveland Rams", "St. Louis Rams"),
                new Franchise("Miami Dolphins"),
                new Franchise("Minnesota Vikings"),
                new Franchise("New England Patriots", "Boston Patriots"),
                new Franchise("New Orleans Saints"),
                new Franchise("New York Giants"),
                new Franchise("New York Jets", "New York Titans"),
                new Franchise("Philadelphia Eagles"),
                new Franchise("Pittsburgh Steelers", "Pittsburgh Pirates"),
                new Franchise("San Francisco 49ers"),
                new Franchise("Seattle Seahawks"),
                new Franchise("Tampa Bay Buccaneers"),
                new Franchise("Tennessee Titans", "Tennessee Oilers", "Houston Oilers"),
                new Franchise("Washington Commanders", "Boston Braves", "Boston Redskins", "Washington Football Team", "Washington Redskins")
            };
            BaseFranchiseNames = new List<string>();
            FranchiseMapping = new Dictionary<string, Franchise>();
            foreach (Franchise f in Franchises)
            {
                BaseFranchiseNames.Add(f.FranchiseName);
                FranchiseMapping[f.FranchiseName] = f;
                foreach (string nextName in f.OtherNames)
                {
                    FranchiseMapping[nextName] = f;
                }
            }
        }

        public Franchise? GetFranchiseByName(string Name, DateTime Date)
        {
            if (FranchiseMapping.TryGetValue(Name, out Franchise? found))
            {
                int? startingYear = found!.StartingYear;
                if (startingYear.HasValue && Date.Year < startingYear.Value)
                {
                    found = null;
                }
            }
            return found;
        }
    }


    public class Franchise
    {
        /// <summary>
        /// constructor where the current name matches the historical franchise name
        /// </summary>
        /// <param name="FranchiseName">input name</param>
        public Franchise(string FranchiseName, params string[] othernames)
        {
            this.FranchiseName = FranchiseName;
            this.OtherNames = new List<string>();
            if (othernames != null) this.OtherNames.AddRange(othernames);
        }

        /// <summary>
        /// other names
        /// </summary>
        public List<string> OtherNames { get; set; }

        /// <summary>
        /// historical franchise name
        /// </summary>
        public string FranchiseName { get; set; }

        /// <summary>
        /// starting year of the franchise, allows for skipping incarnations of the franchise before the current version
        /// </summary>
        public int? StartingYear { get; set; }
    }
}

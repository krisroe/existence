using System.Text;
using CsvHelper.Configuration;
using LibraryShared;
namespace WorldConflict
{
    public class WorldConflict
    {
        public static int RunMain(string[] args)
        {
            string filePath = args[0];
            Dictionary<string, List<UcdpPrioConflict>> conflictsByYear = new Dictionary<string, List<UcdpPrioConflict>>();

            List<string> years = new List<string>();
            foreach (UcdpPrioConflict c in Common.ProcessCSV<UcdpPrioConflict, UcdpPrioConflictMap>(filePath))
            {
                List<UcdpPrioConflict>? conflicts;
                if (!conflictsByYear.TryGetValue(c.year, out conflicts))
                {
                    conflicts = new List<UcdpPrioConflict>();
                    conflictsByYear[c.year] = conflicts;
                    years.Add(c.year);
                }
                conflicts!.Add(c);                
            }
            years.Sort();
            foreach (string nextYear in years)
            {
                foreach (UcdpPrioConflict c in conflictsByYear[nextYear])
                {
                    Console.Out.WriteLine(c.ToString());
                }
                break;
            }
            Console.Out.WriteLine("Finished! Press Enter to Continue.");
            return Common.READ_NEWLINE;
        }
    }

    public class UcdpPrioConflictMap : ClassMap<UcdpPrioConflict>
    {
        public UcdpPrioConflictMap()
        {
            Map(m => m.conflict_id);
            Map(m => m.location);
            Map(m => m.side_a);
            Map(m => m.side_a_id);
            Map(m => m.side_a_2nd);
            Map(m => m.side_b);
            Map(m => m.side_b_id);
            Map(m => m.side_b_2nd);
            Map(m => m.incompatibility);
            Map(m => m.territory_name);
            Map(m => m.year);
            Map(m => m.intensity_level);
            Map(m => m.cumulative_intensity);
            Map(m => m.type_of_conflict);
            Map(m => m.start_date);
            Map(m => m.start_prec);
            Map(m => m.start_date2);
            Map(m => m.start_prec2);
            Map(m => m.ep_end);
            Map(m => m.ep_end_date);
            Map(m => m.ep_end_prec);
            Map(m => m.gwno_a);
            Map(m => m.gwno_a_2nd);
            Map(m => m.gwno_b);
            Map(m => m.gwno_b_2nd);
            Map(m => m.gwno_loc);
            Map(m => m.region);
            Map(m => m.version);
        }
    }

    public class UcdpPrioConflict
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(conflict_id);
            sb.Append(",");
            sb.Append(location);
            sb.Append(",");
            sb.Append(side_a);
            sb.Append(",");
            sb.Append(side_a_id);
            sb.Append(",");
            sb.Append(side_a_2nd);
            sb.Append(",");
            sb.Append(side_b);
            sb.Append(",");
            sb.Append(side_b_id);
            sb.Append(",");
            sb.Append(side_b_2nd);
            sb.Append(",");
            sb.Append(incompatibility);
            sb.Append(",");
            sb.Append(territory_name);
            sb.Append(",");
            sb.Append(year);
            sb.Append(",");
            sb.Append(intensity_level);
            sb.Append(",");
            sb.Append(cumulative_intensity);
            sb.Append(",");
            sb.Append(type_of_conflict);
            sb.Append(",");
            sb.Append(start_date);
            sb.Append(",");
            sb.Append(start_prec);
            sb.Append(",");
            sb.Append(start_date2);
            sb.Append(",");
            sb.Append(start_prec2);
            sb.Append(",");
            sb.Append(ep_end);
            sb.Append(",");
            sb.Append(ep_end_date);
            sb.Append(",");
            sb.Append(ep_end_prec);
            sb.Append(",");
            sb.Append(gwno_a);
            sb.Append(",");
            sb.Append(gwno_a_2nd);
            sb.Append(",");
            sb.Append(gwno_b);
            sb.Append(",");
            sb.Append(gwno_b_2nd);
            sb.Append(",");
            sb.Append(gwno_loc);
            sb.Append(",");
            sb.Append(region);
            sb.Append(",");
            sb.Append(version);
            return sb.ToString();
        }
        public required string conflict_id { get; set; }
        public required string location { get; set; }
        public required string side_a { get; set; }
        public required string side_a_id { get; set; }
        public required string side_a_2nd { get; set; }
        public required string side_b { get; set; }
        public required string side_b_id { get; set; }
        public required string side_b_2nd { get; set; }
        public required string incompatibility { get; set; }
        public required string territory_name { get; set; }
        public required string year { get; set; }
        public required string intensity_level { get; set; }
        public required string cumulative_intensity { get; set; }
        public required string type_of_conflict { get; set; }
        public required string start_date { get; set; }
        public required string start_prec { get; set; }
        public required string start_date2 { get; set; }
        public required string start_prec2 { get; set; }
        public required string ep_end { get; set; }
        public required string ep_end_date { get; set; }
        public required string ep_end_prec { get; set; }
        public required string gwno_a { get; set; }
        public required string gwno_a_2nd { get; set; }
        public required string gwno_b { get; set; }
        public required string gwno_b_2nd { get; set; }
        public required string gwno_loc { get; set; }
        public required string region { get; set; }
        public required string version { get; set; }
    }
}

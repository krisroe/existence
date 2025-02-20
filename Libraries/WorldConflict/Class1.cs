using System.ComponentModel;
using System.Data;
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

            List<KeyValuePair<int, string>> knownSideIDs = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(204, "PLO"),
                new KeyValuePair<int, string>(297, "Ittihad-i Islami Bara-yi Azadi-yi Afghanistan"),
                new KeyValuePair<int, string>(298, "Harakat-i Islami-yi Afghanistan"),
                new KeyValuePair<int, string>(315, "UNLF"),
                new KeyValuePair<int, string>(442, "Islamic Legion"),
                new KeyValuePair<int, string>(481, "NRA"),
                new KeyValuePair<int, string>(486, "UPA"),
                new KeyValuePair<int, string>(557, "MPIGO")
            };
            List<KeyValuePair<int, string>> unknownSideIDs = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(172, "LNPA"),
                new KeyValuePair<int, string>(173, "LTS(p)A"),

                new KeyValuePair<int, string>(218, "Permesta Movement"),
                new KeyValuePair<int, string>(219, "PRRI"),

                new KeyValuePair<int, string>(229, "Military faction (forces of Abd as-Salam Arif)"),
                new KeyValuePair<int, string>(230, "NCRC"),

                new KeyValuePair<int, string>(293, "Harakat-i Inqilab-i Islami-yi Afghanistan"),
                new KeyValuePair<int, string>(295, "Jabha-yi Nijat-i Milli-yi Afghanistan"),

                new KeyValuePair<int, string>(317, "KCP"),
                new KeyValuePair<int, string>(318, "PREPAK"),

                new KeyValuePair<int, string>(443, "MOSANAT"),
                new KeyValuePair<int, string>(444, "Revolutionary Forces of 1 April"),

                new KeyValuePair<int, string>(447, "CNR"),
                new KeyValuePair<int, string>(448, "CSNPD"),
                new KeyValuePair<int, string>(450, "FNT"),

                new KeyValuePair<int, string>(470, "NRF"),
                new KeyValuePair<int, string>(471, "SLM/A - MM"),

                new KeyValuePair<int, string>(478, "Fronasa"),
                new KeyValuePair<int, string>(479, "UNLF"),

                new KeyValuePair<int, string>(483, "HSM"),
                new KeyValuePair<int, string>(484, "UPDA"),

                new KeyValuePair<int, string>(748, "ELN"),
                new KeyValuePair<int, string>(749, "MIR"),

                new KeyValuePair<int, string>(753, "ERP"),
                new KeyValuePair<int, string>(754, "FPL"),

                new KeyValuePair<int, string>(765, "FLRN"),
                new KeyValuePair<int, string>(766, "OP Lavalas"),

                new KeyValuePair<int, string>(1126, "Forces of Muammar Gaddafi"),
                new KeyValuePair<int, string>(1127, "NTC"),

                new KeyValuePair<int, string>(329, "Military faction (forces of Nicolae Ceausescu)"),
                new KeyValuePair<int, string>(6137, "NSF"),

                new KeyValuePair<int, string>(736, "Military faction (forces of Eduardo A. Lonardi Doucet)"),
                new KeyValuePair<int, string>(1113, "Military faction (forces of Samuel Toranzo Calderón)"),

                new KeyValuePair<int, string>(2034, "TAK"),
                new KeyValuePair<int, string>(6689, "Yurtta Sulh Konseyi"),

                new KeyValuePair<int, string>(6814, "Forces of Khalifa al-Ghawil"),
                new KeyValuePair<int, string>(6893, "PFLL"),

                new KeyValuePair<int, string>(6896, "Mayi Mayi Biloze Bishambuke"),
                new KeyValuePair<int, string>(7107, "Mayi Mayi Kyandenga"),

                new KeyValuePair<int, string>(6187, "FPB"),
                new KeyValuePair<int, string>(6297, "Military faction (forces of Godefroid Niyombare)"),

                new KeyValuePair<int, string>(6578, "al-Harakat al-Islamiyah"),
                new KeyValuePair<int, string>(6998, "Maute group"),

                new KeyValuePair<int, string>(5801, "FDLR-RUD"),
                new KeyValuePair<int, string>(6684, "RMDC"),

                new KeyValuePair<int, string>(8639, "LSR"),
                new KeyValuePair<int, string>(8640, "RDK"),
                new KeyValuePair<int, string>(8650, "Wagner"),
            };
            Dictionary<int, string> sides = new Dictionary<int, string>();
            foreach (var nextSide in knownSideIDs)
            {
                sides[nextSide.Key] = nextSide.Value;
            }
            foreach (var nextSide in unknownSideIDs)
            {
                sides[nextSide.Key] = nextSide.Value;
            }


            List<string> years = new List<string>();
            List<UcdpPrioConflict> needToProcess = new List<UcdpPrioConflict>();

            foreach (UcdpPrioConflict c in Common.ProcessCSV<UcdpPrioConflict, UcdpPrioConflictMap>(filePath))
            {
                List<UcdpPrioConflict>? conflicts;
                if (!conflictsByYear.TryGetValue(c.year, out conflicts))
                {
                    conflicts = new List<UcdpPrioConflict>();
                    conflictsByYear[c.year] = conflicts;
                    years.Add(c.year);
                }
                conflicts.Add(c);

                bool sideAParsed = int.TryParse(c.side_a_id, out int iSideA);
                bool sideBParsed = int.TryParse(c.side_b_id, out int iSideB);
                string? sSide;
                if (sideAParsed)
                {
                    if (sides.TryGetValue(iSideA, out sSide))
                    {
                        if (c.side_a != sSide!)
                        {
                            throw new InvalidOperationException();
                        }
                    }
                    else
                    {
                        sides[iSideA] = c.side_a;
                    }
                }
                if (sideBParsed)
                {
                    if (sides.TryGetValue(iSideB, out sSide))
                    {
                        if (c.side_b != sSide!)
                        {
                            Console.Out.WriteLine(c.ToString());
                            throw new InvalidOperationException();
                        }
                    }
                    else
                    {
                        sides[iSideB] = c.side_b;
                    }
                }
                if (!sideAParsed || !sideBParsed)
                {
                    needToProcess.Add(c);
                }
            }

            List<UcdpPrioConflict> next = ProcessMultiples(needToProcess, sides, null);
            while (next.Count != needToProcess.Count && next.Count > 0)
            {
                needToProcess = next;
                next = ProcessMultiples(needToProcess, sides, null);
            }

            if (next.Count > 0)
            {
                ProcessMultiples(next, sides, new HashSet<string>());
            }

            foreach (UcdpPrioConflict c in next)
            {
                Console.Out.WriteLine(c.ToString());
            }

            years.Sort();
            foreach (string nextYear in years)
            {
            }
            Console.Out.WriteLine("Finished! Press Enter to Continue.");
            return Common.READ_NEWLINE;
        }

        public static List<UcdpPrioConflict> ProcessMultiples(List<UcdpPrioConflict> input, Dictionary<int, string> sides, HashSet<string>? displayInfo)
        {
            List<UcdpPrioConflict> needProcessing = new List<UcdpPrioConflict>();
            foreach (UcdpPrioConflict c in input)
            {
                bool sideAParsed = int.TryParse(c.side_a_id, out int iSideA);
                bool sideBParsed = int.TryParse(c.side_b_id, out int iSideB);
                bool sideADone;
                if (sideAParsed)
                {
                    sideADone = true;
                }
                else
                {
                    sideADone = ProcessSides(c, c.side_b, c.side_b_id, sides, displayInfo);
                }
                bool sideBDone;
                if (sideBParsed)
                {
                    sideBDone = true;
                }
                else
                {
                    sideBDone = ProcessSides(c, c.side_b, c.side_b_id, sides, displayInfo);
                }
                if (!sideADone || !sideBDone)
                {
                    needProcessing.Add(c);
                }
            }
            return needProcessing;
        }

        public static bool ProcessSides(UcdpPrioConflict c, string sides, string ids, Dictionary<int, string> sidemap, HashSet<string>? displayInfo)
        {
            bool ret;
            List<string> oParties = new List<string>();
            List<int> oIDs = new List<int>();
            string[] sParties = GetParties(sides);
            string[] sIds = ids.Split(',', StringSplitOptions.RemoveEmptyEntries);
            if (sParties.Length != sIds.Length)
                throw new InvalidOperationException();
            for (int i = 0; i < sParties.Length; i++)
            {
                oParties.Add(sParties[i].Trim());
                oIDs.Add(int.Parse(sIds[i].Trim()));
            }
            for (int i = oIDs.Count - 1; i >= 0; i--)
            {
                int iNext = oIDs[i];
                string? sFoundSide;
                if (sidemap.TryGetValue(iNext, out sFoundSide))
                {
                    if (oParties.Contains(sFoundSide))
                    {
                        oParties.Remove(sFoundSide);
                        oIDs.RemoveAt(i);
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
            if (oIDs.Count == 0)
            {
                ret = true;
            }
            else if (oIDs.Count == 1)
            {
                int iSide = oIDs[0];
                string? sSide;
                if (sidemap.TryGetValue(iSide, out sSide))
                {
                    if (oParties[0] != sSide!)
                    {
                        throw new InvalidOperationException();
                    }
                }
                else
                {
                    sidemap[iSide] = oParties[0];
                }
                ret = true;
            }
            else
            {
                if (displayInfo != null)
                {
                    oParties.Sort();
                    oIDs.Sort();
                    string fullInfo = string.Join(',', oIDs.ToArray()) + " " + string.Join(",", oParties.ToArray());
                    if (!displayInfo.Contains(fullInfo))
                    {
                        displayInfo.Add(fullInfo);
                        Console.Out.WriteLine(fullInfo);
                    }
                }
                ret = false;
            }
            return ret;
        }

        public static string[] GetParties(string text)
        {
            string[] ret;
            if (text == "CPP, Military faction (forces of Honasan, Abenina & Zumel)")
            {
                return new string[] { "CPP", "Military faction (forces of Honasan, Abenina & Zumel)" }; 
            }
            else
            {
                ret = text.Split(',', StringSplitOptions.RemoveEmptyEntries);
            }
            return ret;
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

    public class Conflict
    {
        public Conflict(int id, string location)
        {
            this.id = id;
            this.location = location;
            this.detail = new List<UcdpPrioConflict>();
        }

        public int id { get; set; }
        public string location { get; set; }
        public List<UcdpPrioConflict> detail { get; set; }
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

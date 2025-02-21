using System.Collections.Generic;
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
            List<KeyValuePair<int, string>> knownSideIDs = new List<KeyValuePair<int, string>>();
            /*
            knownSideIDs.Add(new KeyValuePair<int, string>(204, "PLO"));
            knownSideIDs.Add(new KeyValuePair<int, string>(297, "Ittihad-i Islami Bara-yi Azadi-yi Afghanistan"));                ,
            knownSideIDs.Add(new KeyValuePair<int, string>(298, "Harakat-i Islami-yi Afghanistan"));
            knownSideIDs.Add(new KeyValuePair<int, string>(315, "UNLF"));
            knownSideIDs.Add(new KeyValuePair<int, string>(442, "Islamic Legion"));
            knownSideIDs.Add(new KeyValuePair<int, string>(481, "NRA"));
            knownSideIDs.Add(new KeyValuePair<int, string>(486, "UPA"));
            knownSideIDs.Add(new KeyValuePair<int, string>(557, "MPIGO"));
            */
            List<KeyValuePair<int, string>> unknownSideIDs = new List<KeyValuePair<int, string>>();
            /*
            unknownSideIDs.Add(new KeyValuePair<int, string>(172, "LNPA"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(173, "LTS(p)A"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(218, "Permesta Movement"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(219, "PRRI"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(229, "Military faction (forces of Abd as-Salam Arif)"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(230, "NCRC"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(293, "Harakat-i Inqilab-i Islami-yi Afghanistan"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(295, "Jabha-yi Nijat-i Milli-yi Afghanistan"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(317, "KCP"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(318, "PREPAK"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(443, "MOSANAT"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(444, "Revolutionary Forces of 1 April"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(447, "CNR"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(448, "CSNPD"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(450, "FNT"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(470, "NRF"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(471, "SLM/A - MM"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(478, "Fronasa"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(479, "UNLF"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(483, "HSM"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(484, "UPDA"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(748, "ELN"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(749, "MIR"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(753, "ERP"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(754, "FPL"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(765, "FLRN"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(766, "OP Lavalas"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(1126, "Forces of Muammar Gaddafi"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(1127, "NTC"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(329, "Military faction (forces of Nicolae Ceausescu)"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(6137, "NSF"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(736, "Military faction (forces of Eduardo A. Lonardi Doucet)"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(1113, "Military faction (forces of Samuel Toranzo Calderón)"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(2034, "TAK"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(6689, "Yurtta Sulh Konseyi"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(6814, "Forces of Khalifa al-Ghawil"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(6893, "PFLL"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(6896, "Mayi Mayi Biloze Bishambuke"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(7107, "Mayi Mayi Kyandenga"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(6187, "FPB"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(6297, "Military faction (forces of Godefroid Niyombare)"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(6578, "al-Harakat al-Islamiyah"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(6998, "Maute group"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(5801, "FDLR-RUD"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(6684, "RMDC"));

            unknownSideIDs.Add(new KeyValuePair<int, string>(8639, "LSR"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(8640, "RDK"));
            unknownSideIDs.Add(new KeyValuePair<int, string>(8650, "Wagner"));
            */

            Dictionary<int, string> sides = new Dictionary<int, string>();
            foreach (var nextSide in knownSideIDs)
            {
                sides[nextSide.Key] = nextSide.Value;
            }
            foreach (var nextSide in unknownSideIDs)
            {
                sides[nextSide.Key] = nextSide.Value;
            }

            bool isdyadic = filePath.ToLower().Contains("dyadic");
            int ret;
            if (isdyadic)
            {
                ret = ParseDataSet<Dyadic, DyadicMap>(isdyadic, filePath, sides);
            }
            else
            {
                ret = ParseDataSet<UcdpPrioConflict, UcdpPrioConflictMap>(isdyadic, filePath, sides);
            }
            return ret;
        }

        public static int ParseDataSet<T, U>(bool isdyadic, string filePath, Dictionary<int, string> sides)
            where T : UcdpPrioConflict
            where U : ClassMap<T>
        {
            
            Dictionary<string, List<T>> conflictsByYear = new Dictionary<string, List<T>>();
            List<string> years = new List<string>();
            List<T> needToProcess = new List<T>();
            List<T> allConflictRecords = new List<T>();

            foreach (T c in Common.ProcessCSV<T, U>(filePath))
            {
                allConflictRecords.Add(c);
                List<T>? conflicts;
                if (!conflictsByYear.TryGetValue(c.year, out conflicts))
                {
                    conflicts = new List<T>();
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

            List<T> next = ProcessMultiples(needToProcess, sides, null);
            while (next.Count != needToProcess.Count && next.Count > 0)
            {
                needToProcess = next;
                next = ProcessMultiples(needToProcess, sides, null);
            }

            if (next.Count > 0)
            {
                ProcessMultiples(next, sides, new HashSet<string>());
            }
            List<Conflict> allConflictsAsList = new List<Conflict>();
            Dictionary<int, Conflict> allConflicts = new Dictionary<int, Conflict>();
            foreach (UcdpPrioConflict c in allConflictRecords)
            {
                int iConflictID = int.Parse(c.conflict_id);
                int iYear = int.Parse(c.year);
                int iIntensity = int.Parse(c.intensity_level);
                if (iIntensity != 1 && iIntensity != 2)
                {
                    throw new InvalidOperationException();
                }
                int iCumulativeIntensity;
                if (isdyadic)
                {
                    iCumulativeIntensity = 0;
                }
                else
                {
                    iCumulativeIntensity = int.Parse(c.cumulative_intensity);
                    if (iCumulativeIntensity != 0 && iCumulativeIntensity != 1)
                    {
                        throw new InvalidOperationException();
                    }
                    if (iIntensity == 2 && iCumulativeIntensity != 1)
                    {
                        throw new InvalidOperationException();
                    }
                }
                if (allConflicts.TryGetValue(iConflictID, out Conflict? conflict))
                {
                    if (!string.Equals(conflict.location, c.location))
                    {
                        throw new InvalidOperationException();
                    }
                    if (conflict.first_year > iYear)
                    {
                        conflict.first_year = iYear;
                    }
                    if (conflict.last_year < iYear)
                    {
                        conflict.last_year = iYear;
                    }
                    if (iCumulativeIntensity < (int)conflict.cumulative_intensity)
                    {
                        throw new InvalidOperationException();
                    }
                    if (iCumulativeIntensity > (int)conflict.cumulative_intensity)
                    {
                        conflict.cumulative_intensity = (ConflictCumulativeIntensity)iCumulativeIntensity;
                    }
                }
                else
                {
                    conflict = new Conflict(iConflictID, c.location, iYear, iCumulativeIntensity);
                    allConflicts[iConflictID] = conflict;
                    allConflictsAsList.Add(conflict);
                }
                conflict!.detail.Add(c);
            }

            allConflictsAsList.Sort((a, b) =>
            {
                int ret = a.first_year.CompareTo(b.first_year);
                if (ret == 0) ret = a.last_year.CompareTo(b.last_year);
                return ret;
            });
            Dictionary<int, int> totalWarsByYear = new Dictionary<int, int>();
            foreach (Conflict c in allConflictsAsList)
            {
                foreach (UcdpPrioConflict upc in c.detail)
                {
                    int iYear = int.Parse(upc.year);
                    if (upc.intensity_level == "2")
                    {
                        if (!totalWarsByYear.TryGetValue(iYear, out int count))
                        {
                            totalWarsByYear[iYear] = 0;
                        }
                        totalWarsByYear[iYear]++;
                    }
                }
            }
            List<YearWars> yw = new List<YearWars>();
            foreach (var nextYear in totalWarsByYear)
            {
                yw.Add(new YearWars(nextYear.Key, nextYear.Value));
            }
            yw.Sort((a, b) =>
            {
                return a.Year.CompareTo(b.Year);
            });
            foreach (var nextYear in yw)
            {
                Console.Out.WriteLine(nextYear.Year + " " + nextYear.NumberOfWars);
            }

            Console.Out.WriteLine("Finished! Press Enter to Continue.");
            return Common.READ_NEWLINE;
        }

        private class YearWars
        {
            public YearWars(int Year, int NumberOfWars)
            {
                this.Year = Year;
                this.NumberOfWars = NumberOfWars;
            }
            public int Year { get; set; }
            public int NumberOfWars { get; set; }
        }

        public static List<T> ProcessMultiples<T>(List<T> input, Dictionary<int, string> sides, HashSet<string>? displayInfo)
            where T : UcdpPrioConflict
        {
            List<T> needProcessing = new List<T>();
            foreach (T c in input)
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

        public static bool ProcessSides<T>(T c, string sides, string ids, Dictionary<int, string> sidemap, HashSet<string>? displayInfo)
            where T : UcdpPrioConflict
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

    /// <summary>
    /// dyadic CSV map: from UcdpConflict add dyad_id and 
    /// remove cumulative intensity, ep_end, ep_end_date, ep_end_prec
    /// </summary>
    public class DyadicMap : ClassMap<Dyadic>
    {
        public DyadicMap()
        {
            Map(m => m.dyad_id);
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
            Map(m => m.type_of_conflict);
            Map(m => m.start_date);
            Map(m => m.start_prec);
            Map(m => m.start_date2);
            Map(m => m.start_prec2);
            Map(m => m.gwno_a);
            Map(m => m.gwno_a_2nd);
            Map(m => m.gwno_b);
            Map(m => m.gwno_b_2nd);
            Map(m => m.gwno_loc);
            Map(m => m.region);
            Map(m => m.version);
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
        public Conflict(int id, string location, int year, int intensity)
        {
            this.id = id;
            this.location = location;
            this.first_year = this.last_year = year;
            this.cumulative_intensity = (ConflictCumulativeIntensity)intensity;
            this.detail = new List<UcdpPrioConflict>();
        }

        public int id { get; set; }
        public string location { get; set; }
        public int first_year { get; set; }
        public int last_year { get; set; }
        public ConflictCumulativeIntensity cumulative_intensity { get; set; }
        public List<UcdpPrioConflict> detail { get; set; }
    }

    public enum ConflictCumulativeIntensity
    {
        LessSerious = 0,
        MoreSerious = 1
    }

    public class Dyadic : UcdpPrioConflict
    {
        public override string ToString()
        {
            return dyad_id + "," + base.ToString();
        }

        public required string dyad_id { get; set; }
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

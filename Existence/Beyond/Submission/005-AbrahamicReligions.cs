using Existence.Beyond.Infrastructure;
using Existence.Earth.Human.People;
using Existence.Earth.Religions;
using Existence.Personal;
using Existence.Time;
using System;
using System.Collections.Generic;

namespace Existence.Beyond.Submission
{
    [MusicNotesRepositoryOtherFiles(PeopleEnumerated.RoweChris, "Abrahamic Religions",
                                @"Released\Other\003-AbrahamicReligions.txt")]
    class AbrahamicRelgions : SubmissionBase
    {
        public enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 4, 17)]
            Created,
        }

        public string[] EarlyAbrahamicFigures = ["Adam/Eve", "Enoch", "Noah", "Abraham", "Lot", "Jacob", "Joseph", "Moses"];
        public PreTimeCataclysms[] Cataclysms = [PreTimeCataclysms.Flood, PreTimeCataclysms.GodDestroysWickedCities];

        internal override List<LevelJustification> GetLevelJustifications()
        {
            return new List<LevelJustification>()
            {
                new DocumentationJustification("Abrahamic Figures (8)")
            };
        }

        internal override List<TimelessChange>? GetTimelessChanges()
        {
            return new List<TimelessChange>()
            {
                new TimelessChange("World Level 1 Religion is Abrahamic")
            };
        }
    }

    public class WorldReligiousJudgment
    {
        /// <summary>
        /// level 5 pyramid of judgment
        /// Biggest potential problems: Jainism, Yazidism, Zoroastrianism, Mandaeism 
        /// (although it's possible the pan-creed nature of Baháʼí renders any issues moot)
        /// </summary>
        public static WorldReligions[][] ReligiousJudgmentPyramidLevel5;

        static WorldReligiousJudgment()
        {
            ReligiousJudgmentPyramidLevel5 = new WorldReligions[][]
            {
                [WorldReligions.Abrahamic],
                [WorldReligions.Buddhism,WorldReligions.Hinduism],
                [WorldReligions.FolkAndTraditionalReligions, WorldReligions.Noneism, WorldReligions.Atheism],
                [WorldReligions.Christianity,WorldReligions.Islam,WorldReligions.Judaism,WorldReligions.Samaritanism],
                [WorldReligions.Sikhism,WorldReligions.Spiritism,WorldReligions.Taoism,WorldReligions.Confucianism,WorldReligions.Baháʼí]
            };
        }
    }

    public enum PreTimeCataclysms
    {
        [CataclysmScope(CataclysmScope.World)]
        Flood,

        [CataclysmScope(CataclysmScope.Civilization)]
        GodDestroysWickedCities,
    }

    public class CataclysmScopeAttribute : Attribute
    {
        public CataclysmScope CataclysmScope { get; set; }
        public CataclysmScopeAttribute(CataclysmScope CataclysmScope)
        {
            this.CataclysmScope = CataclysmScope;
        }
    }

    public enum CataclysmScope
    {
        Civilization,
        World,
    }
}

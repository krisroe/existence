using System;

namespace Existence.Earth.Countries.UnitedStates
{
    public enum ChristianDenominations
    {
        Catholic,
        Evangelical,
        Baptist,
        Methodist,
        Mormon,
        Lutheran,
        LutheranELCA,
        LutheranMissouriSynod,
        LutheranWisconsinSynod,
        Pentecostal,
        Presbyterian,
        Episcopal,
        JehovahsWitnesses,
        EasternOrthodox,
        SeventhDayAdventist,
    }

    public class UnitedStatesChristianDenominationAttribute : Attribute
    {
        public ChristianDenominations Denomination { get; set; }
        public UnitedStatesChristianDenominationAttribute(ChristianDenominations Denomination)
        {
            this.Denomination = Denomination;

        }
    }
}

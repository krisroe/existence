
using Existence.Earth.Alphabet;
using Existence.Earth.Human.Personal;

namespace Existence.Earth.Human.Entertainment
{

    public static class Television
    {
        public static class CopShows
        {
            public static class XFiles
            {
                [Text("Spooky")]
                public static class FoxMulder { }

                /// <summary>
                /// she got a tattoo in season 4, episode 13, "Never Again"
                /// </summary>
                [HasTattoo(true)]
                public static class DanaScully { }
            }
            public static class LawAndOrder { }
        }
    }
}

using System;
using System.Collections.Generic;
using Existence.Beyond.Infrastructure;

namespace Existence.Beyond.Z
{
    [IsReleased(false)]
    public class MyPersonalReligion : PersonalReligionRules
    {
        public MyPersonalReligion()
        {
            //childish religious disrespect atoned for when older
            ReligiousDisrespect d1 = AddPresentDisrespect("Childish Nativity Play");
            ReligiousDisrespect d2 = AddPresentDisrespect("Childish Nativity Scenes");
            AddActOfAtonement("Played Lead in Silent Night Christmas Pageant", new List<ReligiousDisrespect>() { d1, d2 });

            //This could be interpreted respectfully as becoming non-practicing of a religion,
            //but the better reading is as a parody Lenten discipline.
            //This isn't too public, as I will mention it to the family from time to time.
            ReligiousDisrespect d3 = AddPresentDisrespect("Giving up \"giving up things for Lent\" for Lent");
        }
    }

    public class PersonalReligionRules
    {
        public PersonalReligionRules()
        {
        }

        public List<ReligiousDisrespect> PastDisrespect = new List<ReligiousDisrespect>();
        public List<ReligiousDisrespect> PresentDisrespect = new List<ReligiousDisrespect>();
        public List<ActOfAtonement> ActsOfAtonement = new List<ActOfAtonement>();

        public ReligiousDisrespect AddPresentDisrespect(string Text)
        {
            ReligiousDisrespect rd = new ReligiousDisrespect(Text);
            this.PresentDisrespect.Add(rd);
            return rd;
        }

        public ActOfAtonement AddActOfAtonement(string Text, List<ReligiousDisrespect> AtonedFor)
        {
            ActOfAtonement act = new ActOfAtonement(Text);
            foreach (ReligiousDisrespect rd in AtonedFor)
            {
                if (!PresentDisrespect.Contains(rd))
                {
                    throw new InvalidOperationException();
                }
            }
            foreach (ReligiousDisrespect rd in AtonedFor)
            {
                PresentDisrespect.Remove(rd);
                PastDisrespect.Add(rd);
            }
            ActsOfAtonement.Add(act);
            return act;
        }

        public class ReligiousDisrespect
        {
            public string Act { get; set; }
            public ReligiousDisrespect(string Act)
            {
                this.Act = Act;
            }
        }

        public class ActOfAtonement
        {
            public string Act { get; set; }
            public ActOfAtonement(string Act)
            {
                this.Act = Act;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Existence.Beyond.Z
{
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
            Rule r = new Rule("Maintain a healthy disrespect for religion.");
            r.AddDetail("Maintain a list of present and past disrespect you have for religion, as well as a list of atonements.");
            r.AddDetail("You may change an entry from present to past by an act of atonement.");
            r.AddDetail("Acts of atonement should be thematically related to the past disrespect.");
            r.AddDetail("Atoning is a good opportunity to add another entry to the list that is less problematic to you.");
            r.AddDetail("Private disrespect is generally less problematic than public disrespect, but makes it look like you have something to hide.");
            r.AddDetail("Ambiguous disrespect is a good way to make disrespect less problematic.");
        }

        public class Rule
        {
            public string Text { get; set; }
            public List<string> Details { get; set; }

            public Rule(string Text)
            {
                this.Text = Text;
                this.Details = new List<string>();
            }
            public void AddDetail(string Line)
            {
                this.Details.Add(Line);
            }
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

using System;
using Existence.Earth.Human.People;

namespace Existence.Personal
{
    public class MusicNotesRepositoryAudioFile : Attribute
    {
        public string RelativePath { get; set; }
        public PeopleEnumerated Singer { get; set; }
        public MusicNotesRepositoryAudioFile(string RelativePath, PeopleEnumerated Singer)
        {
            this.RelativePath = RelativePath;
            this.Singer = Singer;
        }
    }
}

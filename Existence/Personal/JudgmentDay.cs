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
    public class MusicNotesRepositoryMeaningFile : Attribute
    {
        public string RelativePath { get; set; }
        public PeopleEnumerated Interpreter { get; set; }
        public MusicNotesRepositoryMeaningFile(string RelativePath, PeopleEnumerated Interpreter)
        {
            this.RelativePath = RelativePath;
            this.Interpreter = Interpreter;
        }

    }
}

using System;
using Existence.Earth.Human.People;

namespace Existence.Personal
{
    public class MusicNotesRepositoryAttachment : Attribute
    {
        public string Creator { get; set; }
        public string RelativeFilePath { get; set; }
        public int? StartNumber { get; set; }
        public int? EndNumber { get; set; }
        public MusicNotesRepositoryAttachment(string Creator, string RelativeFilePath)
        {
            this.Creator = Creator;
            this.RelativeFilePath = RelativeFilePath;
            this.StartNumber = null;
            this.EndNumber = null;
        }
        public MusicNotesRepositoryAttachment(string Creator, string RelativeFilePath, int StartNumber, int EndNumber)
        {
            this.Creator = Creator;
            this.RelativeFilePath = RelativeFilePath;
            this.StartNumber = StartNumber;
            this.EndNumber = EndNumber;
        }
    }

    public class MusicNotesRepositoryOtherFiles : Attribute
    {
        public PeopleEnumerated Creator { get; set; }
        public string Description { get; set; }
        public string[] RelativePaths { get; set; }
        public MusicNotesRepositoryOtherFiles(PeopleEnumerated Creator, string Description, params string[] RelativePaths)
        {
            this.Creator = Creator;
            this.Description = Description;
            this.RelativePaths = RelativePaths;
        }
    }
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

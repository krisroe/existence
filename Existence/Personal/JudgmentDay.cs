using System;
using Existence.Earth.Human.People;

namespace Existence.Personal
{
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
    
    public class MusicNotesRepositoryImageFile : Attribute
    {
        public string Source { get; set;  }
        public string Description { get; set; }
        public string RelativeFilePath { get; set; }
        public int? StartNumber { get; set; }
        public int? EndNumber { get; set; }

        public MusicNotesRepositoryImageFile(int Source, string Description, string RelativeFilePath)
            : this(Source.ToString(), Description, RelativeFilePath)
        {
        }
        public MusicNotesRepositoryImageFile(string Source, string Description, string RelativeFilePath)
        {
            this.Source = Source;
            this.Description = Description;
            this.RelativeFilePath = RelativeFilePath;
            this.StartNumber = null;
            this.EndNumber = null;
        }
        public MusicNotesRepositoryImageFile(string Source, string Description, string RelativeFilePath, int StartNumber, int EndNumber)
            : this(Source, Description, RelativeFilePath)
        {
            this.StartNumber = StartNumber;
            this.StartNumber = EndNumber;
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

    public class MusicNotesRepositoryScriptFile : Attribute
    {
        public string RelativePath { get; set; }
        public PeopleEnumerated Writer { get; set; }
        public MusicNotesRepositoryScriptFile(string RelativePath, PeopleEnumerated Interpreter)
        {
            this.RelativePath = RelativePath;
            this.Writer = Interpreter;
        }
    }
}

namespace Common
{
    public record WordInformation
    {
        public string Word { get; }
        public string[] PartsOfSpeech { get; }
        public string Level { get; }

        public WordInformation(string word, string[] partsOfSpeech, string level)
        {
            Word = word;
            PartsOfSpeech = partsOfSpeech;
            Level = level;
        }
    }
}

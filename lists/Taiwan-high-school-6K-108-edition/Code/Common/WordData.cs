namespace Common
{
    public record WordData
    {
        public string Word { get; }
        public string PartOfSpeech { get; }
        public string Level { get; }

        public WordData(string word, string partOfSpeech, string level)
        {
            Word = word;
            PartOfSpeech = partOfSpeech;
            Level = level;
        }
    }
}

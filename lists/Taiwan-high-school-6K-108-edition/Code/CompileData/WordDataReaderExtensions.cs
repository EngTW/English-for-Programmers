using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace CompileData
{
    static class WordDataReaderExtensions
    {
        public static IEnumerable<WordInformation> ReadWordInformation_SingleWord_MultiPartsOfSpeech(this WordDataReader reader, int count)
        {
            // WordData \{ Word = \w+, PartOfSpeech = \w+\.(/\w+\.)*, Level = \d \}

            while (count > 0)
            {
                var wordData = reader.ReadWordData();
                var partOfSpeechTokens = wordData.PartOfSpeech.Split(Program.Delimiters);
                yield return new(wordData.Word, partOfSpeechTokens, wordData.Level);

                --count;
            }
        }

        public static IEnumerable<WordInformation> ReadWordInformation_MultiWords_SinglePartOfSpeech(this WordDataReader reader)
        {
            // WordData \{ Word = [^/]+(/[^/]+)+, PartOfSpeech = \w+\., Level = \d \}

            var wordData = reader.ReadWordData();
            var wordTokens = wordData.Word.Split(Program.Delimiters);
            return wordTokens.Select(
                wordToken =>
                new WordInformation(wordToken, new[] { wordData.PartOfSpeech }, wordData.Level));
        }

        public static WordInformation ReadWordInformation_PluralNoun(this WordDataReader reader)
        {
            // WordData \{ Word = \w+\(s\), PartOfSpeech = \w+\.(/\w+\.)*, Level = \d \}

            var wordData = reader.ReadWordData();
            var wordTokens = wordData.Word.Split(Program.Delimiters, StringSplitOptions.RemoveEmptyEntries);
            var partOfSpeechTokens = wordData.PartOfSpeech.Split(Program.Delimiters, StringSplitOptions.RemoveEmptyEntries);
            return new(wordTokens[0], partOfSpeechTokens, wordData.Level);
        }

        public static IEnumerable<WordInformation> ReadWordInformation_Verb_Noun(this WordDataReader reader)
        {
            // WordData \{ Word = \w+\(ment\), PartOfSpeech = v\./\(n\.\), Level = \d \}

            var wordData = reader.ReadWordData();
            var wordTokens = wordData.Word.Split(Program.Delimiters, StringSplitOptions.RemoveEmptyEntries);
            var partOfSpeechTokens = wordData.PartOfSpeech.Split(Program.Delimiters, StringSplitOptions.RemoveEmptyEntries);
            return new WordInformation[] {
                new(wordTokens[0], new[] { partOfSpeechTokens[0] }, wordData.Level),
                new(wordTokens[0] + wordTokens[1], new[] { partOfSpeechTokens[1] }, wordData.Level) };
        }

        public static IEnumerable<WordInformation> ReadWordInformation_Pronoun(this WordDataReader reader)
        {
            // WordData \{ Word = \w+ \(\w+(, \w+)*\), PartOfSpeech = pron\., Level = \d \}

            var wordData = reader.ReadWordData();
            var wordTokens = wordData.Word.Split(Program.Delimiters, StringSplitOptions.RemoveEmptyEntries);
            return wordTokens.Select(
                wordToken =>
                new WordInformation(wordToken, new[] { wordData.PartOfSpeech }, wordData.Level));
        }

        public static IEnumerable<WordInformation> ReadWordInformation_MultiWords_MultiPartsOfSpeech(this WordDataReader reader)
        {
            // WordData \{ Word = [^/]+(/[^/]+)+, PartOfSpeech = \w+\.(/\w+\.)+, Level = \d \}

            var wordData = reader.ReadWordData();
            var wordTokens = wordData.Word.Split(Program.Delimiters, StringSplitOptions.RemoveEmptyEntries);
            var partOfSpeechTokens = wordData.PartOfSpeech.Split(Program.Delimiters, StringSplitOptions.RemoveEmptyEntries);
            return wordTokens.Select(
                wordToken =>
                new WordInformation(wordToken, partOfSpeechTokens, wordData.Level));
        }
    }
}

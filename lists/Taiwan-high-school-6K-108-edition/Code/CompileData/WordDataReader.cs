using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Common;

namespace CompileData
{
    class WordDataReader
    {
        IEnumerator<WordData> wordDataEnumerator;

        public WordDataReader(string inputFilePath)
        {
            var json = File.ReadAllText(inputFilePath);
            var wordDataCollection = JsonSerializer.Deserialize<WordData[]>(json)!;
            Array.Sort(
                wordDataCollection,
                (wordData1, wordData2) => wordData1.ToString().CompareTo(wordData2.ToString()));
            wordDataEnumerator = ((IEnumerable<WordData>)wordDataCollection).GetEnumerator();

            wordDataEnumerator.MoveNext();
        }

        public WordData ReadWordData()
        {
            var wordData = wordDataEnumerator.Current;
            wordDataEnumerator.MoveNext();
            return wordData;
        }
    }
}

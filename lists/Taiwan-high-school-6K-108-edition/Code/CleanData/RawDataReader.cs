using System;
using System.Collections.Generic;
using System.IO;

namespace CleanData
{
    class RawDataReader
    {
        IEnumerator<string> lineEnumerator;

        public RawDataReader(string filePath)
        {
            var lines = File.ReadLines(filePath);
            lineEnumerator = lines.GetEnumerator();

            lineEnumerator.MoveNext();
        }

        public void SkipLineWhile(Func<string, bool> predicate)
        {
            while (predicate(lineEnumerator.Current))
            {
                lineEnumerator.MoveNext();
            }
        }

        public void SkipLine() => lineEnumerator.MoveNext();

        public string ReadLine()
        {
            var line = lineEnumerator.Current;
            lineEnumerator.MoveNext();
            return line;
        }

        public IEnumerable<string> ReadLine(int count)
        {
            while (count > 0)
            {
                yield return ReadLine();

                --count;
            }
        }
    }
}

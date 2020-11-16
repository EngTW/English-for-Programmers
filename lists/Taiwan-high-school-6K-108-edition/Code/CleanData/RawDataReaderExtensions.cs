using System.Collections.Generic;
using System.Text;
using Common;

namespace CleanData
{
    static class RawDataReaderExtensions
    {
        public static IEnumerable<WordData> ReadWordData(this RawDataReader reader, int count)
        {
            while (count > 0)
            {
                // Given this particular set of input data, among
                // capacity values from 1 to 31, benchmarking found 21
                // optimal for computation time.
                //
                // In comparison, a default capacity of 21 is about 7%
                // and 13.5% more efficient than 16 (StringBuilder's
                // default capacity) and 31 (input data's max length),
                // respectively.
                //
                // However, the actual impact is a neglectable, 0.1
                // millisecond difference on Intel Core i7-6700.
                const int optimalCapacity = 21;

                var line = new StringBuilder(reader.ReadLine(), optimalCapacity);
                while (!char.IsDigit(line[line.Length - 1]))
                {
                    line.Append(Program.Delimiter);
                    line.Append(reader.ReadLine());
                }

                var tokens = line.ToString().Split(Program.Delimiter);
                yield return new(tokens[0], tokens[1], tokens[2]);

                --count;
            }
        }
    }
}

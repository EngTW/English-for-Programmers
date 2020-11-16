using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Common;

namespace CleanData
{
    class Program
    {
        public const char Delimiter = ' ';

        static void Main(string[] arguments)
        {
            switch (arguments.Length)
            {
                case 0: throw new ArgumentException($"Missing {nameof(arguments)}[0]: input-file-path.", nameof(arguments));
                case 1: throw new ArgumentException($"Missing {nameof(arguments)}[1]: output-file-path.", nameof(arguments));
            }

            var inputFilePath = arguments[0];
            var inputReader = new RawDataReader(inputFilePath);

            const int knownWordDataCount = 6012;
            var wordDataList = new List<WordData>(knownWordDataCount);

            {
                inputReader.SkipLineWhile(line => !line.StartsWith("依字母排序 A"));
                inputReader.SkipLine(); // Line 6409: 依字母排序 A
                wordDataList.AddRange(inputReader.ReadWordData(113));
                inputReader.SkipLine(); // Line 6638: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 6639: 54
                wordDataList.AddRange(inputReader.ReadWordData(119));
                inputReader.SkipLine(); // Line 6760: 依字母排序 A
                inputReader.SkipLine(); // Line 6761: 55
                wordDataList.AddRange(inputReader.ReadWordData(119));
                inputReader.SkipLine(); // Line 6882: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 6883: 56
                wordDataList.AddRange(inputReader.ReadWordData(40));
                inputReader.SkipLine(); // Line 6924: B
                wordDataList.AddRange(inputReader.ReadWordData(78));
                inputReader.SkipLine(); // Line 7004: 依字母排序 B
                inputReader.SkipLine(); // Line 7005: 57
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 7126: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 7127: 58
                wordDataList.AddRange(inputReader.ReadWordData(114));
                inputReader.SkipLine(); // Line 7242: C
                wordDataList.AddRange(inputReader.ReadWordData(5));
                inputReader.SkipLine(); // Line 7248: 依字母排序
                inputReader.SkipLine(); // Line 7249: C
                inputReader.SkipLine(); // Line 7250: 59
                wordDataList.AddRange(inputReader.ReadWordData(113));

                {
                    // Line 7477

                    // chairperson/chair/
                    // chairman/
                    // chairwoman n.
                    // 6

                    var line = string.Concat(inputReader.ReadLine(3));
                    var tokens = line.Split(Delimiter);
                    var level = inputReader.ReadLine();
                    wordDataList.Add(new(tokens[0], tokens[1], level));
                }

                wordDataList.AddRange(inputReader.ReadWordData(4));
                inputReader.SkipLine(); // Line 7489: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 7490: 60
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 7611: 依字母排序 C
                inputReader.SkipLine(); // Line 7612: 61
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 7733: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 7734: 62
                wordDataList.AddRange(inputReader.ReadWordData(55));

                {
                    // Line 7790

                    // congressman/
                    // congresswoman n. 6

                    var line = string.Concat(inputReader.ReadLine(2));
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(tokens[0], tokens[1], tokens[2]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(63));
                inputReader.SkipLine(); // Line 7855: 依字母排序 C
                inputReader.SkipLine(); // Line 7856: 63
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 7977: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 7978: 64
                wordDataList.AddRange(inputReader.ReadWordData(56));
                inputReader.SkipLine(); // Line 8091: D
                wordDataList.AddRange(inputReader.ReadWordData(63));
                inputReader.SkipLine(); // Line 8218: 依字母排序 D
                inputReader.SkipLine(); // Line 8219: 65
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 8340: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 8341: 66
                wordDataList.AddRange(inputReader.ReadWordData(119));
                inputReader.SkipLine(); // Line 8462: 依字母排序 E
                inputReader.SkipLine(); // Line 8463: 67
                wordDataList.AddRange(inputReader.ReadWordData(73));
                inputReader.SkipLine(); // Line 8538: E
                wordDataList.AddRange(inputReader.ReadWordData(45));
                inputReader.SkipLine(); // Line 8584: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 8585: 68
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 8706: 依字母排序 F
                inputReader.SkipLine(); // Line 8707: 69
                wordDataList.AddRange(inputReader.ReadWordData(111));
                inputReader.SkipLine(); // Line 8820: F
                wordDataList.AddRange(inputReader.ReadWordData(7));
                inputReader.SkipLine(); // Line 8828: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 8829: 70
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 8950: 依字母排序 F
                inputReader.SkipLine(); // Line 8951: 71
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 9072: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 9073: 72
                wordDataList.AddRange(inputReader.ReadWordData(22));
                inputReader.SkipLine(); // Line 9118: G
                wordDataList.AddRange(inputReader.ReadWordData(97));
                inputReader.SkipLine(); // Line 9313: 依字母排序 H
                inputReader.SkipLine(); // Line 9314: 73
                wordDataList.AddRange(inputReader.ReadWordData(74));
                inputReader.SkipLine(); // Line 9389: H
                wordDataList.AddRange(inputReader.ReadWordData(45));
                inputReader.SkipLine(); // Line 9435: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 9436: 74
                wordDataList.AddRange(inputReader.ReadWordData(12));

                {
                    // Line 9449

                    // he (him, his, himself)
                    // pron. 1

                    var word = inputReader.ReadLine();
                    var line = inputReader.ReadLine();
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(word, tokens[0], tokens[1]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(105));
                inputReader.SkipLine(); // Line 9557: 依字母排序 I
                inputReader.SkipLine(); // Line 9558: 75
                wordDataList.AddRange(inputReader.ReadWordData(42));
                inputReader.SkipLine(); // Line 9601: I

                {
                    // Line 9602

                    // I (me, my, mine, myself)
                    // pron. 1

                    var word = inputReader.ReadLine();
                    var line = inputReader.ReadLine();
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(word, tokens[0], tokens[1]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(75));
                inputReader.SkipLine(); // Line 9679: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 9680: 76
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 9801: 依字母排序
                inputReader.SkipLine(); // Line 9802: J
                inputReader.SkipLine(); // Line 9803: 77
                wordDataList.AddRange(inputReader.ReadWordData(36));

                {
                    // Line 9876

                    // it (its, itself) pron.
                    // 1

                    var line = inputReader.ReadLine();
                    var word = line.Substring(0, 16);
                    var partOfSpeech = line.Substring(17);
                    var level = inputReader.ReadLine();
                    wordDataList.Add(new(word, partOfSpeech, level));
                }

                wordDataList.AddRange(inputReader.ReadWordData(4));
                inputReader.SkipLine(); // Line 9886: J
                wordDataList.AddRange(inputReader.ReadWordData(48));
                inputReader.SkipLine(); // Line 9982: K
                wordDataList.AddRange(inputReader.ReadWordData(28));
                inputReader.SkipLine(); // Line 10039: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 10040: 78
                wordDataList.AddRange(inputReader.ReadWordData(9));
                inputReader.SkipLine(); // Line 10059: L
                wordDataList.AddRange(inputReader.ReadWordData(110));
                inputReader.SkipLine(); // Line 10280: 依字母排序
                inputReader.SkipLine(); // Line 10281: M
                inputReader.SkipLine(); // Line 10282: 79
                wordDataList.AddRange(inputReader.ReadWordData(104));
                inputReader.SkipLine(); // Line 10491: M
                wordDataList.AddRange(inputReader.ReadWordData(15));
                inputReader.SkipLine(); // Line 10522: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 10523: 80
                wordDataList.AddRange(inputReader.ReadWordData(119));
                inputReader.SkipLine(); // Line 10644: 依字母排序 M
                inputReader.SkipLine(); // Line 10645: 81
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 10766: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 10767: 82
                wordDataList.AddRange(inputReader.ReadWordData(47));
                inputReader.SkipLine(); // Line 10862: N
                wordDataList.AddRange(inputReader.ReadWordData(43));

                {
                    // Line 10949

                    // neither adj./adv./pron./
                    // conj.
                    // 2

                    var line = string.Concat(inputReader.ReadLine(2));
                    var tokens = line.Split(Delimiter);
                    var level = inputReader.ReadLine();
                    wordDataList.Add(new(tokens[0], tokens[1], level));
                }

                wordDataList.AddRange(inputReader.ReadWordData(27));
                inputReader.SkipLine(); // Line 11006: 依字母排序 O
                inputReader.SkipLine(); // Line 11007: 83
                wordDataList.AddRange(inputReader.ReadWordData(43));
                inputReader.SkipLine(); // Line 11051: O
                wordDataList.AddRange(inputReader.ReadWordData(74));
                inputReader.SkipLine(); // Line 11128: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 11129: 84
                wordDataList.AddRange(inputReader.ReadWordData(88));
                inputReader.SkipLine(); // Line 11306: P
                wordDataList.AddRange(inputReader.ReadWordData(31));
                inputReader.SkipLine(); // Line 11369: 依字母排序 P
                inputReader.SkipLine(); // Line 11370: 85
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 11491: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 11492: 86
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 11613: 依字母排序 P
                inputReader.SkipLine(); // Line 11614: 87
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 11735: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 11736: 88
                wordDataList.AddRange(inputReader.ReadWordData(98));
                inputReader.SkipLine(); // Line 11933: Q
                wordDataList.AddRange(inputReader.ReadWordData(21));
                inputReader.SkipLine(); // Line 11976: 依字母排序
                inputReader.SkipLine(); // Line 11977: R
                inputReader.SkipLine(); // Line 11978: 89
                wordDataList.AddRange(inputReader.ReadWordData(1));
                inputReader.SkipLine(); // Line 11981: R
                wordDataList.AddRange(inputReader.ReadWordData(118));
                inputReader.SkipLine(); // Line 12218: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 12219: 90
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 12340: 依字母排序 S
                inputReader.SkipLine(); // Line 12341: 91
                wordDataList.AddRange(inputReader.ReadWordData(100));
                inputReader.SkipLine(); // Line 12442: S
                wordDataList.AddRange(inputReader.ReadWordData(14));

                {
                    // Line 12457

                    // salesperson/salesman/
                    // saleswoman n. 2

                    var line = string.Concat(inputReader.ReadLine(2));
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(tokens[0], tokens[1], tokens[2]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(3));
                inputReader.SkipLine(); // Line 12462: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 12463: 92
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 12584: 依字母排序 S
                inputReader.SkipLine(); // Line 12585: 93
                wordDataList.AddRange(inputReader.ReadWordData(36));

                {
                    // Line 12622

                    // she (her, hers, herself)
                    // pron. 1

                    var word = inputReader.ReadLine();
                    var line = inputReader.ReadLine();
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(word, tokens[0], tokens[1]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(82));
                inputReader.SkipLine(); // Line 12706: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 12707: 94
                wordDataList.AddRange(inputReader.ReadWordData(119));
                inputReader.SkipLine(); // Line 12828: 依字母排序 S
                inputReader.SkipLine(); // Line 12829: 95
                wordDataList.AddRange(inputReader.ReadWordData(66));

                {
                    // Line 12897

                    // spokesperson/
                    // spokesman/
                    // spokeswoman n. 6

                    var line = string.Concat(inputReader.ReadLine(3));
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(tokens[0], tokens[1], tokens[2]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(6));

                {
                    // Line 12906

                    // sportsman/sportswoma
                    // n n. 6

                    var line = string.Concat(inputReader.ReadLine(2));
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(tokens[0], tokens[1], tokens[2]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(43));
                inputReader.SkipLine(); // Line 12951: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 12952: 96
                wordDataList.AddRange(inputReader.ReadWordData(114));

                {
                    // Line 13067

                    // subway/underground/
                    // metro n. 2

                    var line = string.Concat(inputReader.ReadLine(2));
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(tokens[0], tokens[1], tokens[2]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(4));
                inputReader.SkipLine(); // Line 13073: 依字母排序 T
                inputReader.SkipLine(); // Line 13074: 97
                wordDataList.AddRange(inputReader.ReadWordData(106));
                inputReader.SkipLine(); // Line 13181: T
                wordDataList.AddRange(inputReader.ReadWordData(13));
                inputReader.SkipLine(); // Line 13195: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 13196: 98
                wordDataList.AddRange(inputReader.ReadWordData(89));

                {
                    // Line 13286

                    // they (them, their,
                    // theirs, themselves)
                    // pron. 1

                    var word = string.Join(Delimiter, inputReader.ReadLine(2));
                    var line = inputReader.ReadLine();
                    var tokens = line.Split(Delimiter);
                    wordDataList.Add(new(word, tokens[0], tokens[1]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(28));
                inputReader.SkipLine(); // Line 13317: 依字母排序 T
                inputReader.SkipLine(); // Line 13318: 99
                wordDataList.AddRange(inputReader.ReadWordData(120));
                inputReader.SkipLine(); // Line 13439: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 13440: 100
                wordDataList.AddRange(inputReader.ReadWordData(58));
                inputReader.SkipLine(); // Line 13499: U
                wordDataList.AddRange(inputReader.ReadWordData(60));
                inputReader.SkipLine(); // Line 13561: 依字母排序
                inputReader.SkipLine(); // Line 13562: V
                inputReader.SkipLine(); // Line 13563: 101
                wordDataList.AddRange(inputReader.ReadWordData(8));
                inputReader.SkipLine(); // Line 13580: V
                wordDataList.AddRange(inputReader.ReadWordData(105));
                inputReader.SkipLine(); // Line 13791: W
                wordDataList.AddRange(inputReader.ReadWordData(5));
                inputReader.SkipLine(); // Line 13802: 高中英文參考詞彙表
                inputReader.SkipLine(); // Line 13803: 102
                wordDataList.AddRange(inputReader.ReadWordData(30));

                {
                    // Line 13834

                    // we (us, our, ours,
                    // ourselves) pron. 1

                    var line = string.Join(Delimiter, inputReader.ReadLine(2));
                    var word = line.Substring(0, 29);
                    var tokens = line.Substring(30).Split(Delimiter);
                    wordDataList.Add(new(word, tokens[0], tokens[1]));
                }

                wordDataList.AddRange(inputReader.ReadWordData(88));
                inputReader.SkipLine(); // Line 13924: 依字母排序
                inputReader.SkipLine(); // Line 13925: Y
                inputReader.SkipLine(); // Line 13926: 103
                wordDataList.AddRange(inputReader.ReadWordData(42));
                inputReader.SkipLine(); // Line 14011: Y
                wordDataList.AddRange(inputReader.ReadWordData(16));

                {
                    // Line 14044

                    // you (your, yours,
                    // yourself, yourselves)
                    // pron.
                    // 1

                    var word = string.Join(Delimiter, inputReader.ReadLine(2));
                    var partOfSpeech = inputReader.ReadLine();
                    var level = inputReader.ReadLine();
                    wordDataList.Add(new(word, partOfSpeech, level));
                }

                wordDataList.AddRange(inputReader.ReadWordData(4));
                inputReader.SkipLine(); // Line 14056: Z
                wordDataList.AddRange(inputReader.ReadWordData(6));
            }

            var outputFilePath = arguments[1];
            var wordDataJson = JsonSerializer.Serialize(wordDataList);
            File.WriteAllText(outputFilePath, wordDataJson);
        }
    }
}

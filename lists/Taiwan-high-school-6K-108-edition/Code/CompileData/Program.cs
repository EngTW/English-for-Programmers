using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Common;

namespace CompileData
{
    class Program
    {
        public static readonly char[] Delimiters = { ' ', ',', '(', ')', '/' };

        static void Main(string[] arguments)
        {
            switch (arguments.Length)
            {
                case 0: throw new ArgumentException($"Missing {nameof(arguments)}[0]: input-file-path.", nameof(arguments));
                case 1: throw new ArgumentException($"Missing {nameof(arguments)}[1]: output-file-path.", nameof(arguments));
            }

            var inputFilePath = arguments[0];
            var inputReader = new WordDataReader(inputFilePath);

            const int knownWordInfoCount = 6183;
            var wordInfoList = new List<WordInformation>(knownWordInfoCount);

            {
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = a/an, PartOfSpeech = art., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(41));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = accomplish(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(15));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = achieve(ment), PartOfSpeech = v./(n.), Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = acknowledge(ment), PartOfSpeech = v./(n.), Level = 5 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(12));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = actor/actress, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(11));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = adjust(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = administer/administrate, PartOfSpeech = v., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(19));

                {
                    // WordData { Word = advertise(ment)/ad, PartOfSpeech = v./(n.), Level = 3 }

                    var wordData = inputReader.ReadWordData();
                    var wordTokens = wordData.Word.Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);
                    var partOfSpeechTokens = wordData.PartOfSpeech.Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);
                    wordInfoList.Add(new(wordTokens[0], new[] { partOfSpeechTokens[0] }, wordData.Level));
                    wordInfoList.Add(new(wordTokens[0] + wordTokens[1], new[] { partOfSpeechTokens[1] }, wordData.Level));
                    wordInfoList.Add(new(wordTokens[2], new[] { partOfSpeechTokens[1] }, wordData.Level));
                }

                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(2));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = adviser/advisor, PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(13));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = afterward/afterwards, PartOfSpeech = adv., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(10));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = agree(ment), PartOfSpeech = v./(n.), Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(9));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = airplane/plane, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(43));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = am/a.m., PartOfSpeech = adv., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = amaze(ment), PartOfSpeech = v./(n.), Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(7));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = amid/amidst, PartOfSpeech = prep., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(4));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = amuse(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(17));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = announce(ment), PartOfSpeech = v./(n.), Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(16));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = anybody/anyone, PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(4));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = anywhere/anyplace, PartOfSpeech = adv., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(18));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = appoint(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(18));

                {
                    // WordData { Word = argue(argument), PartOfSpeech = v./(n.), Level = 2 }

                    var wordData = inputReader.ReadWordData();
                    var wordTokens = wordData.Word.Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);
                    var partOfSpeechTokens = wordData.PartOfSpeech.Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);
                    wordInfoList.Add(new(wordTokens[0], new[] { partOfSpeechTokens[0] }, wordData.Level));
                    wordInfoList.Add(new(wordTokens[1], new[] { partOfSpeechTokens[1] }, wordData.Level));
                }

                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(8));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = arrange(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(28));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = assess(ment), PartOfSpeech = v./(n.), Level = 5 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = assign(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(10));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = astonish(ment), PartOfSpeech = v./(n.), Level = 5 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(11));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = attach(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = attain(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(25));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = automobile/auto, PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(25));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = backward/backwards, PartOfSpeech = adv., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(118));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = bicycle/bike, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(33));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_MultiPartsOfSpeech()); // WordData { Word = blond/blonde, PartOfSpeech = n./adj., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(64));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = brassiere/bra, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(17));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = bridegroom/groom, PartOfSpeech = n., Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(72));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = café/cafe, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(11));

                {
                    // WordData { Word = calm, PartOfSpeech = v./adj./n, Level = 2 }

                    var wordData = inputReader.ReadWordData();
                    var partOfSpeechTokens = (wordData.PartOfSpeech + ".").Split(Delimiters);
                    wordInfoList.Add(new(wordData.Word, partOfSpeechTokens, wordData.Level));
                }

                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(22));

                {
                    // WordData { Word = capital(ism), PartOfSpeech = n., Level = 4 }

                    var wordData = inputReader.ReadWordData();
                    var wordTokens = wordData.Word.Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);
                    wordInfoList.Add(new(wordTokens[0], new[] { wordData.PartOfSpeech }, wordData.Level));
                    wordInfoList.Add(new(wordTokens[0] + wordTokens[1], new[] { wordData.PartOfSpeech }, wordData.Level));
                }

                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(78));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = chairperson/chair/chairman/chairwoman, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(62));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = chopstick(s), PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(84));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = cockroach/roach, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(10));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = cola/Coke, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(28));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = comic(s), PartOfSpeech = adj./n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(109));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = congratulation(s), PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = congressman/congresswoman, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(49));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = content(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(132));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = criterion/criteria, PartOfSpeech = n., Level = 5 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(197));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = develop(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(62));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = disagree(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = disappoint(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(14));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = discourage(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(14));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = disk/disc, PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(44));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = doctor/doc, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(20));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = dormitory/dorm, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(13));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = downward/downwards, PartOfSpeech = adv., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(66));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = earring(s), PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(60));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = embarrass(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(14));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = employ(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(6));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = encourage(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(5));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = endorse(ment), PartOfSpeech = v./(n.), Level = 5 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(6));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = enforce(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = engage(ment), PartOfSpeech = v./(n.), Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(3));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = enhance(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = enjoy(ment), PartOfSpeech = v./(n.), Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = enlarge(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = enlighten(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(2));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = enrich(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = enroll(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(3));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = entertain(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(21));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = equip(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(16));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = establish(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(5));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = ethic(s), PartOfSpeech = n., Level = 5 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(13));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = everyone/everybody, PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(10));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = examination/exam, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(15));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = excite(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(64));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = eyebrow/brow, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = eyelash/lash, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(85));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = fiancé/fiance, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(22));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = fireman/firewoman, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(91));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = forward/forwards, PartOfSpeech = adv., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(50));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = fulfill(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(35));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = gasoline/gas, PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(57));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = glove(s), PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(6));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = god/goddess, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(54));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = greeting(s), PartOfSpeech = n., Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(33));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = gymnasium/gym, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(13));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = hamburger/burger, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(15));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = harass(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(27));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Pronoun()); // WordData { Word = he (him, his, himself), PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(3));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = headphone(s), PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(31));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = hero/heroine, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(16));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = hippopotamus/hippo, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(46));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = host/hostess, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(47));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Pronoun()); // WordData { Word = I (me, my, mine, myself), PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(53));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = imprison(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = improve(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(129));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = Internet/internet, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(29));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = invest(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(5));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = involve(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(10));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Pronoun()); // WordData { Word = it (its, itself), PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(37));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = judgment/judgement, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(53));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = laboratory/lab, PartOfSpeech = n., Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(214));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = madam/ma’am, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(26));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = manage(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(5));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = mankind/humankind, PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(38));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = mathematics/math, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(17));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = measure(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = measure(s), PartOfSpeech = n., Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(14));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = medium/media, PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(35));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = microphone/mike, PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(121));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = move(ment), PartOfSpeech = v./(n.), Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = movie/film, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = Mr./Mister, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1)); // WordData { Word = Mrs., PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1)); // WordData { Word = Ms., PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(91));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_MultiPartsOfSpeech()); // WordData { Word = no/nope, PartOfSpeech = adj./adv./n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(30));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = nourish(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(19));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_MultiPartsOfSpeech()); // WordData { Word = O.K./OK/okay, PartOfSpeech = adj./adv./n./v., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1)); // WordData { Word = o’clock, PartOfSpeech = adv., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(130));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = outward/outwards, PartOfSpeech = adv., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(65));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = parent(s), PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(40));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = pave(ment), PartOfSpeech = v./(n.), Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = pay(ment), PartOfSpeech = v./(n.), Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(76));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_MultiPartsOfSpeech()); // WordData { Word = photograph/photo, PartOfSpeech = n./v., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(75));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = pm/p.m., PartOfSpeech = adv., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(13));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = policeman/cop, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(41));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = postpone(ment), PartOfSpeech = v./(n.), Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(76));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = prince/princess, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(106));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = punish(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(57));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = railroad/railway, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(81));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = refine(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(4));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = refresh(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = refreshment(s), PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = refrigerator/fridge, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(67));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = replace(ment), PartOfSpeech = v./(n.), Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(12));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = require(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(5));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = resent(ment), PartOfSpeech = v./(n.), Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(38));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = retire(ment), PartOfSpeech = v./(n.), Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(117));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = salesperson/salesman/saleswoman, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(21));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = saving(s), PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(2));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = scale(s), PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(47));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = seagull/gull, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(59));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = settle(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(26));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Pronoun()); // WordData { Word = she (her, hers, herself), PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(17));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = shoe(s), PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(103));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = slipper(s), PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(24));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = sneaker(s), PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(20));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = sock(s), PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(21));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_MultiPartsOfSpeech()); // WordData { Word = someone/somebody, PartOfSpeech = pron./n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(29));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = spacecraft/spaceship, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(47));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = spokesperson/spokesman/spokeswoman, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(6));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = sportsman/sportswoman, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(41));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = state(ment), PartOfSpeech = v./(n.), Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(4));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = statistic(s), PartOfSpeech = n., Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(34));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = stocking(s), PartOfSpeech = n., Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(75));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = subway/underground/metro, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(110));
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1)); // WordData { Word = T-shirt, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(3));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = tactic(s), PartOfSpeech = n., Level = 5 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(21));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = taxicab/taxi/cab, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(18));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_MultiPartsOfSpeech()); // WordData { Word = telephone/phone, PartOfSpeech = n./v., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(1));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = television/TV, PartOfSpeech = n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(55));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Pronoun()); // WordData { Word = they (them, their, theirs, themselves), PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(100));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = toward/towards, PartOfSpeech = prep., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(43));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Verb_Noun()); // WordData { Word = treat(ment), PartOfSpeech = v./(n.), Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(111));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = upward/upwards, PartOfSpeech = adv., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(59));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = veterinarian/vet, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(62));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = wage(s), PartOfSpeech = n., Level = 3 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(3));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = waiter/waitress, PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(29));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Pronoun()); // WordData { Word = we (us, our, ours, ourselves), PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(47));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = whiskey/whisky, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(15));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = widow/widower, PartOfSpeech = n., Level = 6 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(22));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_SinglePartOfSpeech()); // WordData { Word = witch/wizard, PartOfSpeech = n., Level = 4 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(13));
                wordInfoList.Add(inputReader.ReadWordInformation_PluralNoun()); // WordData { Word = wood(s), PartOfSpeech = n., Level = 2 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(38));
                wordInfoList.AddRange(inputReader.ReadWordInformation_MultiWords_MultiPartsOfSpeech()); // WordData { Word = yes/yeah, PartOfSpeech = adv./n., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(6));
                wordInfoList.AddRange(inputReader.ReadWordInformation_Pronoun()); // WordData { Word = you (your, yours, yourself, yourselves), PartOfSpeech = pron., Level = 1 }
                wordInfoList.AddRange(inputReader.ReadWordInformation_SingleWord_MultiPartsOfSpeech(10));
            }

            var outputFilePath = arguments[1];
            var sortedWordInfo =
                wordInfoList
                    .GroupBy(wordInfo => wordInfo.Word)
                    .Select(
                        wordInfoGroup =>
                        wordInfoGroup.Aggregate(
                            (wordInfo1, wordInfo2) =>
                            new(
                                wordInfoGroup.Key,
                                wordInfo1.PartsOfSpeech.Union(wordInfo2.PartsOfSpeech).ToArray(),
                                wordInfo1.Level.CompareTo(wordInfo2.Level) <= 0 ? wordInfo1.Level : wordInfo2.Level)))
                    .OrderBy(wordInfo => wordInfo.Word)
                    .Select(
                        wordInfo =>
                        new WordInformation(
                            wordInfo.Word,
                            wordInfo.PartsOfSpeech.OrderBy(partOfSpeech => partOfSpeech).ToArray(),
                            wordInfo.Level));
            var wordInfoJson = JsonSerializer.Serialize(sortedWordInfo);
            File.WriteAllText(outputFilePath, wordInfoJson);
        }
    }
}

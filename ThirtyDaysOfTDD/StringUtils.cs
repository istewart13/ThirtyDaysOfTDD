using System;

namespace ThirtyDaysOfTDD
{
    public class StringUtils
    {
        public int FindNumberOfOccurences(string sentenceToScan, string characterToScanFor)
        {
            try
            {
                var sentenceAsCharArray = sentenceToScan.ToCharArray();
                var charToCheck = Char.Parse(characterToScanFor);

                var occurences = 0;

                foreach (var character in sentenceAsCharArray)
                {
                    if (character == charToCheck)
                    {
                        occurences++;
                    }
                }

                return occurences;
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}

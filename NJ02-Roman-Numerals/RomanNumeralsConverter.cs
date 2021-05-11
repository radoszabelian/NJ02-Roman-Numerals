using System;
using System.Collections.Generic;
using System.Text;

namespace NJ02_Roman_Numerals
{
    public static class RomanNumeralsConverter
    {
        //support arabic number from 0 to 3999
        public static string ConvertToRomanNumber(this int arabicNumber)
        {
            StringBuilder result = new StringBuilder();

            if (arabicNumber <= 0 || arabicNumber > 3999)
            {
                return "";
            }

            char[] numbersArray = arabicNumber.ToString().ToCharArray();

            int totalNotationNumbers = numbersArray.Length;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                result.Append(convertSingleNumberToRomanNumber(int.Parse(numbersArray[i].ToString()), totalNotationNumbers - i));
            }

            return result.ToString();
        }

        public static string convertSingleNumberToRomanNumber(int singleNumber, int notationPlace)
        {
            switch (notationPlace)
            {
                case 1:
                    return ConvertToGeneralNotationPlaceRomanNumber("I", "V", "X", singleNumber);
                case 2:
                    return ConvertToGeneralNotationPlaceRomanNumber("X", "L", "C", singleNumber);
                case 3:
                    return ConvertToGeneralNotationPlaceRomanNumber("C", "D", "M", singleNumber);
                case 4:
                    return ConvertToGeneralNotationPlaceRomanNumber("M", "M", "M", singleNumber);
            }

            return "";
        }

        public static string ConvertToGeneralNotationPlaceRomanNumber(string baseRomanLetter, string midRomanLetter, string topRomanLetter, int numberToConvert)
        {
            if (baseRomanLetter == "M" && midRomanLetter == "M" && topRomanLetter == "M")
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < numberToConvert; i++)
                {
                    result.Append("M");
                }
                return result.ToString();
            }


            Dictionary<string, string> romanNumberConvertionDict = new Dictionary<string, string>() {
                { "1", $"{baseRomanLetter}" },
                { "2", $"{baseRomanLetter}{baseRomanLetter}" },
                { "3", $"{baseRomanLetter}{baseRomanLetter}{baseRomanLetter}" },
                { "4", $"{baseRomanLetter}{midRomanLetter}" },
                { "5", $"{midRomanLetter}" },
                { "6", $"{midRomanLetter}{baseRomanLetter}" },
                { "7", $"{midRomanLetter}{baseRomanLetter}{baseRomanLetter}" },
                { "8", $"{midRomanLetter}{baseRomanLetter}{baseRomanLetter}{baseRomanLetter}" },
                { "9", $"{baseRomanLetter}{topRomanLetter}" }
            };

            return romanNumberConvertionDict.GetValueOrDefault(numberToConvert.ToString());
        }


    }


}

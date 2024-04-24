namespace RomanToInteger;

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanDigits = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        char[] romanArray = s.ToCharArray();
        int result = 0;

        for (var i = 0; i < romanArray.Length; i++)
        {
            if (i != 0)
            {
                if (romanArray[i].ToString().Equals("V") &&
                    romanArray[i - 1].ToString().Equals("I"))
                {
                    result -= romanDigits['I'];
                    result += romanDigits['V'] - romanDigits['I'];
                    continue;
                }

                if (romanArray[i].ToString().Equals("X") &&
                    romanArray[i - 1].ToString().Equals("I"))
                {
                    result -= romanDigits['I'];
                    result += romanDigits['X'] - romanDigits['I'];
                    continue;
                }

                if (romanArray[i].ToString().Equals("L") &&
                    romanArray[i - 1].ToString().Equals("X"))
                {
                    result -= romanDigits['X'];
                    result += romanDigits['L'] - romanDigits['X'];
                    continue;
                }
                
                if (romanArray[i].ToString().Equals("C") &&
                    romanArray[i - 1].ToString().Equals("X"))
                {
                    result -= romanDigits['X'];
                    result += romanDigits['C'] - romanDigits['X'];
                    continue;
                }
                
                if (romanArray[i].ToString().Equals("D") &&
                    romanArray[i - 1].ToString().Equals("C"))
                {
                    result -= romanDigits['C'];
                    result += romanDigits['D'] - romanDigits['C'];
                    continue;
                }
                
                if (romanArray[i].ToString().Equals("M") &&
                    romanArray[i - 1].ToString().Equals("C"))
                {
                    result -= romanDigits['C'];
                    result += romanDigits['M'] - romanDigits['C'];
                    continue;
                }
            }

            result += romanDigits[romanArray[i]];
        }

        return result;
    }
}
/*
 * https://leetcode.com/problems/longest-common-prefix/
 */


namespace CS;

public class LongestCommonPrefix
{
    public static string LCP(string[] strs)
    {
        string prefix = "";
        string initalWord = strs[0];
        if (initalWord == string.Empty)
        {
            return prefix;
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }
        int[] checkLetterExisting = new int[strs.Length - 1];

        for (int i = 1; i < strs.Length; i++)
        {
                
            int indicator = initalWord.Length;
            if (strs[i].Length < indicator)
            {
                indicator = strs[i].Length;
            } 
            for (int j = 0; j < indicator ; j++)
            {
                    
                    
                if (initalWord[j] != strs[i][j])
                {
                    break;
                }
                else
                {
                    checkLetterExisting[i - 1] += 1;
                }
            }
                
        }

        int minValue = checkLetterExisting[0];
        foreach (int item in checkLetterExisting)
        {
            if (item < minValue)
            {
                minValue = item;
            }
        }

        if (minValue != 0)
        {

            for (int indexLetters = 0; indexLetters < minValue; indexLetters++)
            {
                prefix += initalWord[indexLetters];
            }

            return prefix;
        }
        return prefix;
    }
}
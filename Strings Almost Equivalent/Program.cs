class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CheckAlmostEquivalent("aaaa", "bccb")); //false
        Console.WriteLine(CheckAlmostEquivalent("abcdeef", "abaaacc")); //true
    }
    public static bool CheckAlmostEquivalent(string word1, string word2)
    {
        // first approach
        int[] count1 = new int[26];
       // int[] count2 = new int[26];
       for(int i=0; i< word1.Length; i++)
        {
            count1[word1[i] - 'a']++;
            count1[word2[i] - 'a']--;
        }
       
        for (int i = 0; i < 26; i++)
        {
            if (count1[i] > 3 || count1[i] < -3)
            {
                return false;
            }
        }

        // second approach

        //int[] count1 = new int[26];
        //int[] count2 = new int[26];
        //foreach (char c in word1)
        //{
        //    count1[c - 'a']++;
        //}
        //foreach (char c in word2)
        //{
        //    count2[c - 'a']++;
        //}
        //for (int i = 0; i < 26; i++)
        //{
        //    if(Math.Abs(count1[i] - count2[i])>3)
        //    {
        //        return false;
        //    }
        //}
        return true;
    }
}
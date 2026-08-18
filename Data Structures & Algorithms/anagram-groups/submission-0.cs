public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        foreach(var str in strs)
        {
            int[]counts = new int[26];
            foreach(var s in str)
            {
                counts[s - 'a']++;
            }

            string key = string.Join(',',counts);

            if(!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }
            dict[key].Add(str);
        }

        return dict.Values.ToList<List<string>>();
    }
}

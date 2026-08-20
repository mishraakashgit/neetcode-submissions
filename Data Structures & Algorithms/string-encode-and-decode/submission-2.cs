public class Solution {
    public string Encode(IList<string> strs) {
        string s = "";
        foreach(string str in strs)
        {
            s = s + str.Length + "#" + str;
        }

        return s;
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            int hashIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, hashIndex - i));
            i = hashIndex + 1;
            strs.Add(s.Substring(i, length));
            i += length;
        }

        return strs;
   }
}
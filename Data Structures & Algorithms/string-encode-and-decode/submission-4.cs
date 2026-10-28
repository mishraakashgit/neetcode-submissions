public class Solution {

    public string Encode(IList<string> strs) {
        string s = "";

        foreach(string str in strs)
        {
            s = s + str.Length + '#' + str;
        }

        return s;
    }

    public List<string> Decode(string s) {
        List<string> res = new();
        int i = 0;

        while(i<s.Length)
        {
            int index = s.IndexOf('#',i);
            int length = int.Parse(s.Substring(i, index - i));
            i = index + 1;
            res.Add(s.Substring(i,length));
            i = i + length;
        }

        return res;
   }
}

public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> track = new();

        foreach(var st in s)
        {
            if(track.ContainsKey(st))
            {
                track[st] = track[st] + 1;
            }
            else
            {
                track[st] = 1;
            }
        }

        foreach(var ts in t)
        {
            if(!track.ContainsKey(ts)) return false;

            track[ts] = track[ts] - 1;

            if(track[ts] < 0) return false;
        }

        foreach (KeyValuePair<char, int> kvp in track)
        {
            if(kvp.Value != 0) return false;
        }
        return true;
    }
}

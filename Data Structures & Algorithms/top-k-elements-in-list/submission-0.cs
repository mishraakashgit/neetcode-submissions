public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new();
        foreach(var num in nums)
        {
            if(dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        PriorityQueue<int,int> heap = new();

        foreach(var item in dict)
        {
            heap.Enqueue(item.Key, item.Value);
            if(heap.Count > k)
            {
                heap.Dequeue();
            }
        }

        int[]res = new int[k];

        for(int i =0; i<k; i++)
        {
            heap.TryDequeue(out int task, out int priority);
            res[i] = task;
        }

        return res;
    }
}

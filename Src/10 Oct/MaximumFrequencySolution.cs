namespace Src._10_Oct;

// This is not solved til the end. I am satisfied with the progress so far but
// for the complete solution it would require more time which I currently don't have
// This problem should be classified as hard and not as medium difficulty
public class MaximumFrequencySolution
{
    public static int MaxFrequency(int[] nums, int k, int numOperations)
    {
        var maxFreq = 1;

        for (var i = 0; i < numOperations; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                for (var n = -k; n <= k; n++)
                {
                    nums[j]+=n;
                    var currentFreq = GetFrequency(nums);
                    if (currentFreq > maxFreq)
                        maxFreq = currentFreq;
                    nums[j] -= n;
                }
            }
        }

        return maxFreq;
    }

    public static List<int> GenerateNumbers(int k)
    {
        var numbers = new List<int>();
        for (var i = -k; i <= k; i++)
        {
            numbers.Add(i);
        }

        return numbers;
    }

    public static int GetFrequency(int[] arr)
    {
        var seen = new HashSet<int>();
        var maximum = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            if (!seen.Contains(arr[i]))
            {
                var counter = 0;

                foreach (var number in arr)
                {
                    if (number == arr[i])
                        counter++;
                }

                if (counter > maximum)
                    maximum = counter;

                seen.Add(arr[i]);
            }
        }

        return maximum;
    }
}

namespace Src._10_Oct;

public class MakeArrayElementsEqualToZero
{
    public static int CountValidSelections(int[] nums)
    {
        var possibleDirection = new[] { "left", "right" };
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                foreach (var direction in possibleDirection)
                    if (ApplyMoves(nums, i, direction))
                       result++;
        }

        return result;
    }

    public static bool ApplyMoves(int[] inputArray, int position, string direction)
    {
        var curr = position;
        var nums = (int[])inputArray.Clone();

        while (0 <= curr && curr < nums.Length)
        {
            if (nums[curr] == 0)
            {
                if (direction == "right")
                    curr++;
                else if (direction == "left")
                    curr--;
            }

            else if (nums[curr] > 0)
            {
                nums[curr] -= 1;

                if (direction == "right")
                {
                    direction = "left";
                    curr--;
                }

                else if (direction == "left")
                {
                    direction = "right";
                    curr++;
                }
                    
            }
        }

        return nums.Sum() == 0;
    }
}

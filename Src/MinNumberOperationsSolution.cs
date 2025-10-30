namespace Src;

public class MinNumberOperationsSolution
{
    public static int MinNumberOperations(int[] target)
    {
        var operations = target[0];
        for (var i = 1; i < target.Length; i++)
        {
            var difference = target[i] - target[i - 1];
            if (difference > 0)
                operations += difference;
        }

        return operations; 
    }
}

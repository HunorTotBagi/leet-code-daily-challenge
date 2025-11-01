namespace Src._11_Nov;

public class DeleteNodesFromLinkedListPresentInArraySolution
{
    public static ListNode ModifiedList(int[] nums, ListNode head)
    {
        if (head == null) return null;

        var toDelete = new HashSet<int>(nums);

        var dummy = new ListNode(0, head);
        var prev = dummy;
        var curr = head;

        while (curr != null)
        {
            if (toDelete.Contains(curr.val))
                prev.next = curr.next;

            else
                prev = curr;

            curr = curr.next;
        }

        return dummy.next;
    }
}

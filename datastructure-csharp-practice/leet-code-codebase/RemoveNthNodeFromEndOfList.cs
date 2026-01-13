public class Solution {
    public static int Size(ListNode head){
        ListNode tem=head;
        int count=0;
        while(tem!=null){
            count++;
            tem=tem.next;
        }
        return count;
    }
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head==null || head.next==null){
            return null;
        }
        int size=Size(head);
        if(n==size){
         head=head.next;
         return head;
        }
        ListNode temp=head;
        for(int i=0;i<size-n-1;i++){
            temp=temp.next;
        }
        temp.next=temp.next.next;
        return head;
    }
}
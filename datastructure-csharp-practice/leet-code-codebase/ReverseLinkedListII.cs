public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(left==right){
            return head;
        }
       ListNode prev=null;
        ListNode curr=head;
        for(int i=0;i<left-1;i++){
            prev=curr;
            curr=curr.next;
        }
        ListNode temp=prev;
        ListNode temp1=curr;
        ListNode f=null;
        for(int i=left;i<=right;i++){
            f=curr.next;
            curr.next=prev;
            prev=curr;
            curr=f;
        }
       if(temp!=null){
        temp.next=prev;
       }
       else{
        head=prev;
       }
        temp1.next=curr;
    return head;
    }
}
public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) 
    {
        Array.Sort(hours);
        int count =0; 

        for(int i =0 ;i<hours.Length ; i++)
        {
            if(target <= hours[i])
            {
                count++;
            }
        }

        return count;
    }
}

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return false;
        int row = FindRow(matrix , target);
        if(row == -1) return false;

        return BinarySearch( matrix[row], target);
        
    }

    public int FindRow(int[][] matrix , int target){
        for(int i = 0 ; i < matrix.Length ; i++){
            int lastElement = matrix[i][matrix[i].Length - 1];
            if(target <= lastElement){
                return i;
            }
        }
        return -1;
    }

    public bool BinarySearch(int[] row , int target){
        int left = 0 ;
        int right = row.Length - 1;
        while(left <= right){
            int mid = left + (right - left) /2;
            if(row[mid] == target) return true;
            else if(row[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return false;
    }
}

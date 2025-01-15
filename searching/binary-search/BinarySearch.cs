public class BinarySearch {

    public int FindIndexByKey(int[] a, int n, int key) {
        int left = 0;
        int right = n - 1;

        while (left <= right) {

            int middle = (left + right) / 2;

            if(a[middle] == key) {
                return middle;
            }
            else if(key < a[middle]) {
                right = middle - 1;
            }
            else if(key > a[middle]) {
                left = middle + 1;
            }

        }

        return -1;

    } 

}
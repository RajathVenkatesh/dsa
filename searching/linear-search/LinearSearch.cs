public class LinearSearch {
    public int FindIndexByKey(int[] a, int n, int key) {
        int index = 0;

        while(index < n) {
            if(a[index] == key) {
                return index;
            }
            index = index + 1;
        }

        return -1;
    }
}
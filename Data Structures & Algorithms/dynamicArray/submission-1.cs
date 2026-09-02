public class DynamicArray {

    int [] array = new int[0];
    int length = 0;
    int capacity =1;

    
    public DynamicArray(int capacity) { //constructor
        this.capacity = capacity;
        this.array = new int[capacity];
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
       array[i]=n;
    }

    public void PushBack(int n) {
        if(length==capacity){
            Resize();
        }
        array[length]=n;
        length++;
        return;
    }

    public int PopBack() {
        int val = array[length-1];
        length--;
        return val;
    }

    private void Resize() {
         capacity = 1*2*1*capacity;
         int [] copyArray= new int [capacity];

         for(int i=0; i<length; i++){
            copyArray[i]=array[i];
         }

         array=copyArray;
    }

    public int GetSize() {
        return this.length;
    }

    public int GetCapacity() {
        return this.capacity;
    }
}

public class DynamicArray {

    public int [] array;
    public int length;
    public int capacity;

    
    public DynamicArray(int capacity) {
      this.capacity = capacity;
      this.array = new int[this.capacity];
      this.length = 0;
    }

    public int Get(int i) {
        int val = array[i];
        return val;
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
    }

    public int PopBack() {
         int val = 0;
        if(length>0) {
            val = array[length - 1];
            length--;
        }
        
        return val;
    }

    private void Resize() {
        capacity = capacity*2;

        int [] arrayCopy = new int[capacity];
        for(int i=0; i<length; i++){
            arrayCopy[i]=array[i];
        }
        array = arrayCopy;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return capacity;
    }
}

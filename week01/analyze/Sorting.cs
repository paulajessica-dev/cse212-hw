public static class Sorting {
    public static void Run() {
        var numbers = new[] { 3, 2, 4, 1, 7, 9 }; //, 1, 6, 4, 9, 8
        SortArray(numbers);
        //Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    private static void SortArray(int[] data) {
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--) { 
            Console.WriteLine($"sortPosTotal = {sortPos}"); //position
                      

            for (var swapPos = 0; swapPos < sortPos; ++swapPos) {
                
                Console.WriteLine($"swapPos = {swapPos}"); //position
                Console.WriteLine($"item = {data[swapPos]}"); // value in that position
                Console.WriteLine($"comparing:  {data[swapPos]} > {data[swapPos + 1]}");
                
                 

                if (data[swapPos] > data[swapPos + 1]) { // value in that position is greater than the next position value ?                    

                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);                    
                }
                Console.WriteLine($"volta swapPos = {swapPos} | array agora: {string.Join(", ", data)}");
            }
        }
    }
}
 


    void print(int [] Arr, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(Arr[n] + " "); 
      	print(Arr, n - 1); 
      } 
      else Console.WriteLine(Arr[0]); 
    } 
    
      int [] num = {2, 3, 5, 550, 100, 3004}; 
      print(num, num.Length - 1); 
    
  

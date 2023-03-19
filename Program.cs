// See https://aka.ms/new-console-template for more information


using System;

namespace Program{

    
    class Program{

        public int[,] Transpose(int[,] Arr, int size){

            int[,] TArray = new int[size,size];

            //i = column
            //j = row

            for(int i = 0; i < size; i++){
                for(int j = 0; j < size; j++){
                    TArray[i,j] = Arr[j,i];
                }
            }

            return TArray;
        }

        public int[] TwoSum(int[] nums, int target) {
        
        int[] arr = new int[2];
        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < nums.Length; j++){
                if(i == j){
                    continue;
                }
                int sum = nums[i] + nums[j];
                Console.WriteLine(sum);
                if(sum == target){
                    arr[0] = i;
                    arr[1] = j;
                    break;
                }
            }
        }
        return arr;
    }

    
    public int RomanToInt(string s) {
        Dictionary <string,int> Romans = new Dictionary<string,int>();
        Romans.Add("I",1);
        Romans.Add("V",5);
        Romans.Add("X",10);
        Romans.Add("L",50);
        Romans.Add("C",100);
        Romans.Add("D",500);
        Romans.Add("M",1000);

        int Output = 0;

        for(int i = 0; i < s.Length-1; i++){
            int iVal = Romans[s[i].ToString()];
            int iVal1 = Romans[s[i+1].ToString()];
            if(iVal > iVal1 || iVal == iVal1){
                Output += iVal;
            }else{
                Output += (iVal1 - iVal);
                i = (i+1);
            }           
                 
        }

      

        return Output;
    }



    public void PrintArr(int[,] Arr){
        for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    Console.Write(Arr[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
    }
        

        static void Main(string[] args){
            int[,] Arr = {{1,2,3}, {4,5,6},{7,8,9}};
            Program S = new Program();
           Console.WriteLine(S.RomanToInt("MCMXCIV"));

           Console.ReadLine();

            

             

            
        }


    }
}

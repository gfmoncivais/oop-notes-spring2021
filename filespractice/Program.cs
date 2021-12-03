using System;
using System.IO; //when we need to pull an outside code for StreamReader

namespace filespractice
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] names = new string[100];
          int[] hours = new int[100];
          int count = GetAllEmployees(names, hours);
          PrintAllEmployees(names,hours,count);
          hours[0] = 40;
          SaveAllEmployees(names, hours, count);
          PrintAllEmployees(names,hours,count);
        }

        static void SaveAllEmployees(string[] names,int[] hours, int count)
         {
            //open
            StreamWriter outFile = new StreamWriter("input.txt");
            //process
            for (int i = 0; i <count; i++)
            {
                outFile.WriteLine($"{names[i]}#{hours[i]}");
            }
            //close
            outFile.Close();
    }
        static int GetAllEmployees(string[] names, int[] hours)
        {
           int count = 0; //keeps the count 
            //open
           StreamReader inFile = new StreamReader("input.txt"); 
            //process the file
            //priming read
           string dataRow = inFile.ReadLine();
            //while condition
            while (dataRow!=null)
            {
                string[] tempData = dataRow.Split("#");
                names[count] = tempData[0];
                hours[count] = int.Parse(tempData[1]);
                count++;
                //update read
                dataRow = inFile.ReadLine();
                    }
            //close the file 
            inFile.Close(); 

            return count; 
        }

        static void PrintAllEmployees(string[] names, int[] hours, int count)
        {
            for(int i=0; i<count; i++)
            {
                Console.WriteLine($"{names[i]} worked {hours[i]}");
            }
        }
    }
}

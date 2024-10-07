//See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello C# ");
Console.WriteLine("Hello C# ");
Console.Write("First");
Console.Write("Second");
Console.WriteLine("Hello C# ");
Console.Write("Third");*/

// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            //// Each bit can be worth 0 or 1 of the value it is placed in
            ////// From the right we start with a value of 1 and double for each digit to the left
            //// 00000000 = 0
            //// 00000001 = 1
            //// 00000010 = 2
            //// 00000011 = 3
            //// 00000100 = 4
            //// 00000101 = 5
            //// 00000110 = 6
            //// 00000111 = 7
            //// 00001000 = 8
 
        //     1 byte (8 bit) unsigned, where signed means it can be negative
        //     byte myByte = 255;
        //     byte mySecondByte = 0;
 
        //     1 byte (8 bit) signed, where signed means it can be negative
        //     sbyte mySbyte = 127;
        //     sbyte mySecondSbyte = -128;
 
 
        //     // 2 byte (16 bit) unsigned, where signed means it can be negative
        //     ushort myUshort = 65535;
 
        //     // 2 byte (16 bit) signed, where signed means it can be negative
        //     short myShort = -32768;
 
        //     // 4 byte (32 bit) signed, where signed means it can be negative
        //     int myInt = 2147483647;
        //     int mySecondInt = -2147483648;
 
        //     // 8 byte (64 bit) signed, where signed means it can be negative
        //     long myLong = -9223372036854775808;
 
 
        //     // 4 byte (32 bit) floating point number
        //     float myFloat = 0.751f;
        //     float mySecondFloat = 0.75f;
 
        //     // 8 byte (64 bit) floating point number
        //     double myDouble = 0.751;
        //     double mySecondDouble = 0.75d;
 
            // // 16 byte (128 bit) floating point number
            // decimal myDecimal = 0.751m;
            // decimal mySecondDecimal = 0.75m;
 
            // // Console.WriteLine(myFloat - mySecondFloat);
            // // Console.WriteLine(myDouble - mySecondDouble);
            // // Console.WriteLine(myDecimal - mySecondDecimal);
 
 
 
            // string myString = "Hello World";
            // Console.WriteLine(myString);
            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // Console.WriteLine(myStringWithSymbols);
 
        //     bool myBool = true;

        //     //Data Structure

        //     string [] myGroceryArray=new string [2];
            
        //     myGroceryArray[0]="Guacamole";
        //     myGroceryArray[1]="Ice Cream";

        //     Console.WriteLine(myGroceryArray[0]);
        //     Console.WriteLine(myGroceryArray[1]);

        //    string [] mySecondGroceryArray={"Apple","Eggs"};

        //    Console.WriteLine(mySecondGroceryArray[0]);
        //    Console.WriteLine(mySecondGroceryArray[1]);

        //    List<string> myGroceryList=new List<string>(){"Milk", "Cheese"};
           
        //    Console.WriteLine(myGroceryList[0]);
        //    Console.WriteLine(myGroceryList[1]);

        //    myGroceryList.Add("Oranges");

          
        //    Console.WriteLine(myGroceryList[2]);

        //    IEnumerable <string> myGroceryIEnumerable=myGroceryList;

        //    Console.WriteLine(myGroceryIEnumerable.First());

        //    string [,] myTwoDimensionalArray=new string [,]{
        //     {"Apples","Eggs"},
        //     {"Milk", "Cheese"}
        //    };
        //    Console.WriteLine(myTwoDimensionalArray[1,1]);

        //   Dictionary<string,string> myGroceryDictionary=new Dictionary<string, string>{
        //   {"Cheese","Dairy"}//key & its value
        //   };
        //   Console.WriteLine(myGroceryDictionary["Cheese"]);


        //    Dictionary<string,string[]> mySecondGroceryDictionary=new Dictionary<string, string[]>{
        //   {"Dairy",new string[]{"Cheese","Milk","Eggs"}}//key & its value
        //   };
 
        //   Console.WriteLine(myGroceryDictionary["Cheese"]);
        //     int myInt =5;
        //     int mySecondInt =10;
        //     Console.WriteLine(myInt);
        //     myInt++;
        //     Console.WriteLine(myInt);
        //     Console.WriteLine(Math.Pow(5,2));
        //     Console.WriteLine(Math.Sqrt(4));

        //     string myString="test";
        //     Console.WriteLine(myString);
        //     myString+=". secodpart";
        //     Console.WriteLine(myString);
        //     string[] myStringArr=myString.Split(".");
        //    Console.WriteLine( myStringArr[0]);
        //    Console.WriteLine( myStringArr[1]);
        //    Console.WriteLine( myInt.Equals(myString));
        //    Console.WriteLine( myInt==mySecondInt);
        //    Console.WriteLine( myInt!=mySecondInt);
        //   int myFirstValue = 5;
        //     int mySecondValue = 5;
            
        //     Console.WriteLine( mySecondValue+=myFirstValue);
        //    Console.WriteLine( myFirstValue-=mySecondValue);
            // string myFirstValue = "some words";
            // string mySecondValue = "Some words";
using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
namespace HelloWorld 
{
    internal class Program
    {
         static void Main(String []args) {
             string connectionString="Server=localhost;Database=DotNetCourseDataBase;TrustServerCertificate=true;Trusted_Connection=true";
             IDbConnection dbConnection=new SqlConnection(connectionString);
             DateTime rightNow =dbConnection.QuerySingle<DateTime>("SELECT GETDATE()");
             Console.WriteLine(rightNow.ToString());
             

            Computer myComputer =new Computer(){
                Motherboard="Z690",
                HasWifi=true,
                HasLTE=false,
                ReleaseDate=DateTime.Now,
                Price=943.87m,
                VideoCard="RTX 2060"

            };

            string sql=@"INHSERT INTO TutorialAppSchema.Computer(
                Motherboard,
                HasWifi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
                )VALUES(
                    @Motherboard ,
                    @HasWifi,
                    @HasLTE,
                    @ReleaseDate,
                    @Price,
                    @VideoCard,
                )";
            
            Console.WriteLine(sql);

            int result=dbConnection.Execute(sql,myComputer);
            
            //Console.WriteLine(result);
             
           
            // List<int> myNumberList = new List<int>(){
            //     2, 3, 5, 6, 7, 9, 10, 123, 324, 54
            // };
            
            //  static  void PrintIfOdd(int n){
            //     if(!(n%2==0)){
            //         Console.WriteLine(n);
            //     };
            //  }
            // foreach (var number in myNumberList)
            // {
            //     PrintIfOdd(number);
            // }
        
       
            
            
       }
    }
}



   









           

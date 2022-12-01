using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulArrayv2
{
    internal class Program
    {
        public static void Shuffle(Random random, string[,] arr)
        {
            int height = arr.GetUpperBound(0) + 1; // Y same as getlen
            int width = arr.GetUpperBound(1) + 1; // X

            for (int i = 0; i < height; i++) //loop Y Questions
            {
                int randomRow = random.Next(i, height); //select a random number
                for (int j = 0; j < width; ++j) //retrieve Y and add the to new array
                {
                    string tmp = arr[i, j]; //select rows
                    arr[i, j] = arr[randomRow, j];//add new rows
                    arr[randomRow, j] = tmp; //save to the new array rows
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Array");
            //Create a multidimensional array
            string[,] questions = new string[3, 2];
            questions[0, 0] = "Question 1";
            questions[1, 0] = "Question 2";
            questions[2, 0] = "Question 3";
            questions[0, 1] = "Answer 1";
            questions[1, 1] = "Answer 2";
            questions[2, 1] = "Answer 3";

            //show values of the array (first col)
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(questions[i, 0]);
            }
            //Display answer located in the second col of the array
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(questions[i, 1]);
            }

            //Create a dynamic multidimensional array
            string[,] QA = new string[,] 
            {    //0   1   2   3   4   5
                {"What language used in Prog2","C","C#","Python","HTML","C#"},    //0
                {"Q1","A","B","C","D","A"},   //1
                {"Q2","A","B","C","D","B"},    //2
                {"Q3","A","B","C","D","C"},     //3
                {"Q4","A","B","C","D","D"}    //4                     
            };
            Random rnd = new Random(); //declare a randomizer
            Shuffle(rnd, QA); //function call

            int Ysize = QA.GetLength(0); //rows      4
            int Xsize=QA.GetLength(1);  //cols        6     
            string ca = "";
            string ans = "";

            Console.WriteLine($"Y:{Ysize} X:{Xsize}");
            for (int i = 0; i < Ysize;  i++) //loop question
            {
                Console.WriteLine(QA[i,0]); //display quetion
                for (int j = 1; j < Xsize; j++) //loop display choices
                {
                    if (j==5)
                    {
                        ca = QA[i, j]; //get the correct answer
                    }
                    else
                    {
                        Console.Write($" {QA[i, j]} "); //show choices
                    }                   
                }//end of loop that display answer
                Console.WriteLine();//spacing 
                Console.Write("What is your answer: "); //ask answer to user
                ans = Console.ReadLine();
                //determine if the answer is correct 
                if(ans == ca)
                {
                    Console.WriteLine("Correct!"); //if correct answer
                }
                else //if wrong answer
                {
                    Console.WriteLine($"The correct answer is: {ca}");
                }
            }//end of loop question

            Console.ReadLine();
        }
    }
}

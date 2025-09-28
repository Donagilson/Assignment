namespace ConsoleAppStringJaggedArray
{ 
using System.Text;


    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             //Creating two strings objects in the intern pool
             //by directly assigning a string literal value.
             String sOne = "sky";
             String sTwo = "Blue";

             //Adding two strings
             sOne = sOne + sTwo;

             //SKY BECOME GARBAGE - gc();

             char[] strCity = { 'N', 'e', 'w' };
             string sThree = new string(strCity);
             string sFour = new StringBuilder("York").ToString();

             StringBuilder sb = new StringBuilder();
             sb.Append("Hello");
             sb.Append("World");

             Console.WriteLine(sThree);

             //save memory & no garbage
             sThree = sThree + sFour;
             Console.WriteLine(sThree);
            */





            /*
             * imagine you are managing a classroom where each student has 
             * tken a different number of exams . You want to store the scores of these exams in a jagged 
             * array where each row represents a student and each column represents an exam score.
             */
            // Initialize the jagged array

            int[][] studentscores = new int[3][];

            //Each student has taken a different number of exams
            studentscores[0] = new int[] { 85, 90, 78 };//student 1 scores
            studentscores[1] = new int[] { 83, 80};//student 2 scores
            studentscores[2] = new int[] { 75, 80, 85,90 };//student 3 scores
            
            //print the score for each student
            for (int i = 0; i < studentscores.Length; i++)
            {
                Console.Write("Student {0} scores:", i + 1);
                for(int j = 0; j < studentscores[i].Length; j++)
                {
                    Console.Write(studentscores[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

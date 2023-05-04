using System.Drawing;
namespace Exercise001
{
    using System.Collections.Generic;
    using System;
    public class GradeRegister
    {
        private List<int> grades;
        private List<int> pointlist;

        public GradeRegister()
        {
            this.grades = new List<int>();
            this.pointlist = new List<int>();
        }

        public void AddGradeBasedOnPoints(int points)
        {
            this.grades.Add(PointsToGrades(points));
            this.pointlist.Add(points);
        }

        public int NumberOfGrades(int grade)
        { //how many time grade eg 5 is achieved.(2 time, 3 time etc)
            int count = 0;
            foreach (int received in this.grades)
            {
                if (received == grade)
                {
                    count++;
                }
            }
            return count;
        }

        public static int PointsToGrades(int points)
        {
            int grade = 0;
            if (points < 50)
            {
                grade = 0;
            }
            else if (points < 60)
            {
                grade = 1;
            }
            else if (points < 70)
            {
                grade = 2;
            }
            else if (points < 80)
            {
                grade = 3;
            }
            else if (points < 90)
            {
                grade = 4;
            }
            else
            {
                grade = 5;
            }
            return grade;
        }

        public double AverageOfGrades()
        {

            if (this.grades.Count > 0)
            {
                double sum = 0;
                int count = 0;
                for (int i = 0; i < grades.Count; i++)
                {
                    sum = sum + grades[i];
                    count++;

                }
                double average = (sum / count) + 0.00;


                return Math.Round(average, 2); /* to round the double decimal to 2 values only*/

            }
            else
            {
                return Math.Round(-1.0, 2);
            }

        }

        public double AverageOfPoints()
        {

            double sum = 0.00;
            double count = 0.00;
            if (pointlist.Count > 0)
            {

                foreach (double allpoints in pointlist)
                {
                    sum = sum + allpoints;
                    count++;
                }
                double average = (sum / count) + 0.00;
                return Math.Round(average, 2);

            }

            else
            {
                return Math.Round(-1.0, 2);
            }



        }
    }
}
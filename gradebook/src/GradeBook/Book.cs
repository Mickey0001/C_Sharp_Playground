using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
           if(grade <= 100 && grade >= 0)
           {
                grades.Add(grade);
           }
           else
           {
               throw new ArgumentException($"Invalid {nameof(grade)}");
           }
        }

        public void AddALetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }


        public Statistics GetStatistics()
        {   
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var i = 0;
            while(i < grades.Count)
            {
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
                i +=1;
            }

            result.Average /= grades.Count;

            return result;
        }
        private List<double> grades;

        public string Name;
        }
    }
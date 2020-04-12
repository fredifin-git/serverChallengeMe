﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using serverChallengeMe.Models.DAL;

namespace serverChallengeMe.Models
{
    public class StudentFeatures
    {
        public int Answer { get; set; }
        public int StudentID { get; set; }
        public int QuestionID { get; set; }
        public StudentFeatures() { }
        public StudentFeatures(int answer, int studentID, int questionID)
        {
            Answer = answer;
            StudentID = studentID;
            QuestionID = questionID;
        }

        public DataTable getFQBystudentID(int studentID)
        {
            DBservices dBservices = new DBservices();
            return dBservices.getFQBystudentID(studentID);
        }

        public DataTable getQuestionsAndAnswers(int studentID)
        {
            DBservices dBservices = new DBservices();
            return dBservices.getQuestionsAndAnswers(studentID);
        }

        public int postStudentFeatures(List<StudentFeatures> StudentFeaturesArr)
        {
            var x = 0;
            DBservices dbs = new DBservices();
            for (int i = 0; i < StudentFeaturesArr.Count; i++)
            {
                x = dbs.postStudentFeatures(StudentFeaturesArr[i]);
            }
            return x;
        }
    }
}
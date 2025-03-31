using System;

// initialize variables - graded assignments 
int examAssignmentsCount = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");


foreach (string student in studentNames)
{
    string currentStudent = student;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }

    decimal currentStudentExamScore = 0;
    int examAssignments = 0;
    int extraCreditAssignmentsCount = 0;

    int examScore = 0;
    decimal extraCreditScore = 0;

    foreach (int score in studentScores)
    {
        examAssignments ++;

        if (examAssignments <= examAssignmentsCount)
        {
            examScore += score;
        }
        else 
        {
            extraCreditAssignmentsCount ++;
            extraCreditScore += score;
        }
    }

    currentStudentExamScore = (decimal) examScore / examAssignmentsCount;
    var currentStudentExtraCreditScore = (decimal) extraCreditScore / extraCreditAssignmentsCount;
    var currentStudentOverallScore = (decimal) ((examScore + (extraCreditScore / 10)) / examAssignmentsCount);

    var currentStudentExtraCreditPoints = (decimal) (extraCreditScore / 10) / examAssignmentsCount;

    if (currentStudentOverallScore >= 97) {currentStudentLetterGrade = "A+";}
    else if (currentStudentOverallScore >= 93) {currentStudentLetterGrade = "A";}
    else if (currentStudentOverallScore >= 90) {currentStudentLetterGrade = "A-";}
    else if (currentStudentOverallScore >= 87) {currentStudentLetterGrade = "B+";}
    else if (currentStudentOverallScore >= 83) {currentStudentLetterGrade = "B";}
    else if (currentStudentOverallScore >= 80) {currentStudentLetterGrade = "B-";}
    else if (currentStudentOverallScore >= 77) {currentStudentLetterGrade = "C+";}
    else if (currentStudentOverallScore >= 73) {currentStudentLetterGrade = "C";}
    else if (currentStudentOverallScore >= 70) {currentStudentLetterGrade = "C-";}
    else if (currentStudentOverallScore >= 67) {currentStudentLetterGrade = "D+";}
    else if (currentStudentOverallScore >= 63) {currentStudentLetterGrade = "D";}
    else if (currentStudentOverallScore >= 60) {currentStudentLetterGrade = "D-";}
    else {currentStudentLetterGrade = "F";}

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentOverallScore}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({currentStudentExtraCreditPoints} pts)");

};


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


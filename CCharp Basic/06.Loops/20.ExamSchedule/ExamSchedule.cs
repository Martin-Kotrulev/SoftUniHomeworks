using System;
//Problem 20.	** – Exam Schedule
//At SoftUni we have a new trainee Stamat, who is 
//assigned to make schedules for the entrance exams.
//Since today is his first day at work he is a little
//bit nervous and he is not working very fast. 
//Unfortunately, it seems that he will not have
//enough time to make the schedule for the next 
//exam and there is no one else to do the job …
//except you of course. You will be given exam 
//starting time in the standard 12-hour clock 
//(hours, minutes and part of the day) and exam
//duration (hours and minutes). Your job is to write
//a program that calculates at what time the exam ends.

//Input
//The input data should be read from the console. 
//The input data consists of exactly 5 lines:
//•	The first three lines are holding the exam
//start time: hour, minutes and part of the day (AM or PM).
//•	The last two lines are holding two integer
//number: the exam duration hours and minutes.

//Output
//You have to print the time the exam ends in format HH:MM:PartOfDay.

//SOLUTION TESTED - 100%

class ExamSchedule
{
    static void Main()
    {
        int hh = int.Parse(Console.ReadLine());
        int mm = int.Parse(Console.ReadLine());
        string pod = Console.ReadLine();
        int examHh = int.Parse(Console.ReadLine());
        int examMm = int.Parse(Console.ReadLine());

        // start hour
        DateTime start = new DateTime();
        start = start.AddHours(hh);
        start = start.AddMinutes(mm);
        if (pod == "PM") start = start.AddHours(12);

        //adding exam time
        start = start.AddHours(examHh);
        start = start.AddMinutes(examMm);
        
        Console.WriteLine(start.ToString("hh:mm:tt"));
    }
}
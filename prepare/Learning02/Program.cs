using System;

class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job();

        myFirstJob._companyName = "Digitran";
        myFirstJob._jobTitles = "Software Engineer";
        myFirstJob._startYear = 1989;
        myFirstJob._endYear = 1994;

        myFirstJob.DisplayJob();

      Job mySecondJob = new Job();

        myFirstJob._companyName = "HP";
        myFirstJob._jobTitles = "Software Engineer";
        myFirstJob._startYear = 1994;
        myFirstJob._endYear = 2022;

        mySecondJob.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Vanessa Jimenez";
        myResume._jobs = new List<Job>();
        myResume._jobs.Add(myFirstJob);
        myResume._jobs.Add(mySecondJob);

        myResume.DisplayResume();

    }

}
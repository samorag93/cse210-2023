using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Ahorramas S.A";
        job1._jobTitle = "Auxiliar";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Cash Unide";
        job2._jobTitle = "Cajero";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._company = "Carrefour";
        job3._jobTitle = "Auxiliar";
        job3._startYear = 2021;
        job3._endYear = 2023;

        Resume miResume = new Resume();
        miResume._name = "Samuel Moroni Aguilar Cordova";

        miResume._jobs.Add(job1);
        miResume._jobs.Add(job2);
        miResume._jobs.Add(job3);

        miResume.Display();
    }
}
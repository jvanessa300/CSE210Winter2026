class Job
{
    public string _companyName;

    public string _jobTitles;

    public int _startYear;

    public int _endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"Name: {_companyName}, Title: {_jobTitles}, Started: {_startYear}, Ended: {_endYear}");
    }
}
public class Job
{
    // Responsibility: Keeps track of the company, job title, start year, and end year
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Behaviors: Displays the job information in the format "Job Title (Company) StartYear-EndYear"
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    
}


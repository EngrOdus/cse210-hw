public class Resume
{
    public string _personalName;
    public List<Job> _job = new List<Job>();

    public Resume() //created the Resume class constructor.
    {

    }

    public void DisplayResume()
    {
        int jobCount = 0;
        Console.WriteLine($"{_personalName}");
        Console.WriteLine("Jobs Experience:");
        foreach (Job j in _job)
        {
            jobCount += 1;
            Console.WriteLine($"({jobCount}) Company: {j._companyName}, Job Title: {j._jobTitle}, Start Year: {j._startYear} - End Year: {j._endYear} for duration of {j._endYear - j._startYear}yrs.");
        }
    }
}
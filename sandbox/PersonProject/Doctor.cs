class Doctor : Person
{
    private string _tools;

    public Doctor(string tools, string firstName, string lastName, int age, int weight)
    : base(firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    //  public string GetDoctorInformation()
    // {
    //     return $"tools: {_tools}, {GetPersonInformation()}";
    // }

    public override string GetPersonInformation()
    {
        return $"Tools: {_tools}, {base.GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        return 397542.23;
    }
}
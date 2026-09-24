using System.Globalization;


/*Part 1 — Starter Data*/
string[] sessionNames =
{
    "C# Basics",
    "Arrays",
    "Functions",
    "Date and Time",
    "Exception Handling"
};

DateTime[] sessionDates =
{
    new DateTime(2026, 9, 10, 18, 0, 0),
    new DateTime(2026, 9, 13, 18, 0, 0),
    new DateTime(2026, 9, 17, 18, 0, 0),
    new DateTime(2026, 9, 20, 18, 0, 0),
    new DateTime(2026, 9, 24, 18, 0, 0)
};

int[] sessionDurations =
{
    180,
    240,
    180,
    240,
    180
};


/*Part 2 — Display All Sessions*/
static void DisplayAllSessions(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
{
    for (int i = 0; i < sessionNames.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {sessionNames[i]}");
        Console.WriteLine($"Date: {sessionDates[i].ToString("dd MMMM yyyy", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Start Time: {sessionDates[i].ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Duration: {sessionDurations[i]} minutes");
    }
}

//DisplayAllSessions(sessionNames, sessionDates, sessionDurations);


/*Part 3 — Search for a Session*/
static void SearchSession(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations, string searchName)
{
    int index = Array.FindIndex(sessionNames, name => name == searchName);
    if (index != -1)
    {
        Console.WriteLine($"{index + 1}. {sessionNames[index]}");
        Console.WriteLine($"Date: {sessionDates[index].ToString("dd MMMM yyyy", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Start Time: {sessionDates[index].ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Duration: {sessionDurations[index]} minutes");}
      else
       Console.WriteLine("Session not found.");
}
//SearchSession(sessionNames, sessionDates, sessionDurations,"C# Basics");


/*Part 4 — Array Methods Practice*/
//4.1 Sort Session Names
static void SortSessionNames(string[] sessionNames)
{
    
    string[] sortSession = new string[sessionNames.Length];
    Array.Copy(sessionNames,sortSession,sessionNames.Length);
    Array.Sort(sortSession);
    foreach (var item in sortSession)
    {
        Console.WriteLine(item);
    }

}
//SortSessionNames(sessionNames);


//4.2 Reverse Session Names
static void ReverseSessionNames(string[] sessionNames)
{
    string[] reverseSession = new string[sessionNames.Length];
    Array.Copy(sessionNames,reverseSession,sessionNames.Length);
    Array.Reverse(reverseSession);
    foreach(var item in reverseSession)
        Console.WriteLine(item);
}
ReverseSessionNames(sessionNames);
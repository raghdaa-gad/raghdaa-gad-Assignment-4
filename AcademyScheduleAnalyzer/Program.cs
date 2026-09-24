using System.Globalization;
using System.Text;


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
static void DisplayAllSessions(
    string[] sessionNames,
    DateTime[] sessionDates,
    int[] sessionDurations)
{
    for (int i = 0; i < sessionNames.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {sessionNames[i]}");
        Console.WriteLine(
            $"Date: {sessionDates[i].ToString("dd MMMM yyyy", CultureInfo.InvariantCulture)}");
        Console.WriteLine(
            $"Start Time: {sessionDates[i].ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Duration: {sessionDurations[i]} minutes");
    }
}

// DisplayAllSessions(sessionNames, sessionDates, sessionDurations);


/*Part 3 — Search for a Session*/
static void SearchSession(
    string[] sessionNames,
    DateTime[] sessionDates,
    int[] sessionDurations,
    string searchName)
{
    int index = Array.FindIndex(
        sessionNames,
        name => name == searchName);

    if (index != -1)
    {
        Console.WriteLine($"{index + 1}. {sessionNames[index]}");
        Console.WriteLine(
            $"Date: {sessionDates[index].ToString("dd MMMM yyyy", CultureInfo.InvariantCulture)}");
        Console.WriteLine(
            $"Start Time: {sessionDates[index].ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Duration: {sessionDurations[index]} minutes");
    }
    else
    {
        Console.WriteLine("Session not found.");
    }
}

// SearchSession(sessionNames, sessionDates, sessionDurations, "C# Basics");


/*Part 4 — Array Methods Practice*/

// 4.1 Sort Session Names
static void SortSessionNames(string[] sessionNames)
{
    string[] sortSession = new string[sessionNames.Length];

    Array.Copy(
        sessionNames,
        sortSession,
        sessionNames.Length);

    Array.Sort(sortSession);

    foreach (var item in sortSession)
    {
        Console.WriteLine(item);
    }
}

// SortSessionNames(sessionNames);


// 4.2 Reverse Session Names
static void ReverseSessionNames(string[] sessionNames)
{
    string[] reverseSession = new string[sessionNames.Length];

    Array.Copy(
        sessionNames,
        reverseSession,
        sessionNames.Length);

    Array.Reverse(reverseSession);

    foreach (var item in reverseSession)
    {
        Console.WriteLine(item);
    }
}

// ReverseSessionNames(sessionNames);


// 4.3 Find Session Index
static void FindSessionIndex(
    string[] sessionNames,
    string searchSession)
{
    int index = Array.IndexOf(
        sessionNames,
        searchSession);

    if (index != -1)
    {
        Console.WriteLine($"Index: {index}");
    }
    else
    {
        Console.WriteLine("Session not found.");
    }
}

/*
Console.Write("Enter session name: ");
string searchSession = Console.ReadLine()!;

FindSessionIndex(sessionNames, searchSession);
*/


// 4.4 Check if a Session Exists
static void SessionExit(
    string[] sessionNames,
    string existSession)
{
    var result = Array.Exists(
        sessionNames,
        name => name == existSession);

    if (result)
    {
        Console.WriteLine("Session exists.\n");
    }
    else
    {
        Console.WriteLine("Session does not exist.\n");
    }
}

// SessionExit(sessionNames, "Functions");


// 4.5 Find a Session
static void FindSession(
    string[] sessionNames,
    string findSession)
{
    var result = Array.Find(
        sessionNames,
        name => name == findSession);

    if (result != null)
    {
        Console.WriteLine($"Session found: {result}");
    }
    else
    {
        Console.WriteLine("Session not found.");
    }
}

// FindSession(sessionNames, "Functions");


// 4.6 Find a Session Index Using a Condition
static void FindSessionIndex2(
    string[] sessionNames,
    string searchSession)
{
    int index = Array.FindIndex(
        sessionNames,
        name => name == searchSession);

    if (index != -1)
    {
        Console.WriteLine($"Index: {index}");
    }
    else
    {
        Console.WriteLine("Session not found.");
    }
}

// FindSessionIndex2(sessionNames, "Date and Time");


// 4.7 Copy an Array
static void CopyArray(string[] sessionNames)
{
    string[] copiedArray = new string[sessionNames.Length];

    Array.Copy(
        sessionNames,
        copiedArray,
        sessionNames.Length);

    copiedArray[0] = "JAVA";

    Console.WriteLine("--------------------");
    Console.Write("Original array:");

    foreach (var item in sessionNames)
    {
        Console.Write($",{item}");
    }

    Console.WriteLine("\n--------------------");
    Console.Write("Copied array:");

    foreach (var item in copiedArray)
    {
        Console.Write($",{item}");
    }
}

// CopyArray(sessionNames);


/*Part 5 — Duration Analysis*/

static int GetTotalDuration(int[] sessionDurations)
{
    var result = 0;

    foreach (var number in sessionDurations)
    {
        result += number;
    }

    return result;
}

static double GetAverageDuration(int[] sessionDurations)
{
    return (double)GetTotalDuration(sessionDurations)
           / sessionDurations.Length;
}

static int GetShortestDuration(int[] sessionDurations)
{
    int minNum = sessionDurations[0];

    for (int i = 1; i < sessionDurations.Length; i++)
    {
        if (sessionDurations[i] < minNum)
        {
            minNum = sessionDurations[i];
        }
    }

    return minNum;
}

static int GetLongestDuration(int[] sessionDurations)
{
    int longNum = sessionDurations[0];

    for (int i = 1; i < sessionDurations.Length; i++)
    {
        if (sessionDurations[i] > longNum)
        {
            longNum = sessionDurations[i];
        }
    }

    return longNum;
}

static void SortDurations(int[] sessionDurations)
{
    int[] copyDu = new int[sessionDurations.Length];

    Array.Copy(
        sessionDurations,
        copyDu,
        sessionDurations.Length);

    Array.Sort(copyDu);

    foreach (var item in copyDu)
    {
        Console.WriteLine(item);
    }
}

Console.WriteLine(
    $"Total Duration: {GetTotalDuration(sessionDurations)} minutes");

Console.WriteLine(
    $"Average Duration: {GetAverageDuration(sessionDurations)} minutes");

Console.WriteLine(
    $"Shortest Duration: {GetShortestDuration(sessionDurations)} minutes");

Console.WriteLine(
    $"Longest Duration: {GetLongestDuration(sessionDurations)} minutes");

Console.WriteLine("Sorted Durations:");

SortDurations(sessionDurations);


/*Part 6 — Functions*/

static void DisplaySessionDetails(
    string name,
    DateTime date,
    int duration)
{
    Console.WriteLine($"Session: {name}");
    Console.WriteLine(
        $"Date: {date.ToString("dd MMMM yyyy", CultureInfo.InvariantCulture)}");
    Console.WriteLine(
        $"Start Time: {date.ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Duration: {duration} minutes");
}

static DateTime GetSessionEndTime(
    DateTime startTime,
    int duration)
{
    return startTime.AddMinutes(duration);
}

static DateTime ReadSessionDate()
{
    Console.Write("Enter session date (yyyy-MM-dd HH:mm): ");

    while (true)
    {
        if (DateTime.TryParseExact(
                Console.ReadLine(),
                "yyyy-MM-dd HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime date))
        {
            return date;
        }

        Console.Write("Invalid date. Try again: ");
    }
}

static string BuildReportUsingString(
    string[] sessionNames,
    DateTime[] sessionDates,
    int[] sessionDurations)
{
    string report = "";

    for (int i = 0; i < sessionNames.Length; i++)
    {
        report += $"{i + 1}. {sessionNames[i]} - " +
                  $"{sessionDates[i]:dd MMMM yyyy} - " +
                  $"{sessionDurations[i]} minutes\n";
    }

    return report;
}

static string BuildReportUsingStringBuilder(
    string[] sessionNames,
    DateTime[] sessionDates,
    int[] sessionDurations)
{
    StringBuilder report = new StringBuilder();

    for (int i = 0; i < sessionNames.Length; i++)
    {
        report.AppendLine(
            $"{i + 1}. {sessionNames[i]} - " +
            $"{sessionDates[i]:dd MMMM yyyy} - " +
            $"{sessionDurations[i]} minutes");
    }

    return report.ToString();
}
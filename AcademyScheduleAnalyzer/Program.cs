using System.Globalization;
using System.Text;
using BenchmarkDotNet.Running;
using Benchmarks;

if (args.Contains("--benchmark"))
{
    BenchmarkRunner.Run<StringBenchmark>();
    return;
}


/* Part 1 — Starter Data */

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


/* Part 2 — Display All Sessions */

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
        Console.WriteLine();
    }
}

DisplayAllSessions(sessionNames, sessionDates, sessionDurations);


/* Part 3 — Search for a Session */

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

Console.Write("Enter session name to search: ");
string searchName = Console.ReadLine() ?? "";
SearchSession(sessionNames, sessionDates, sessionDurations, searchName);


/* Part 4 — Array Methods Practice */

// 4.1 Sort Session Names

static void SortSessionNames(string[] sessionNames)
{
    string[] sortSession = new string[sessionNames.Length];

    Array.Copy(
        sessionNames,
        sortSession,
        sessionNames.Length);

    Array.Sort(sortSession);

    Console.WriteLine("\nSorted Session Names:");

    foreach (string item in sortSession)
    {
        Console.WriteLine(item);
    }
}

SortSessionNames(sessionNames);


// 4.2 Reverse Session Names

static void ReverseSessionNames(string[] sessionNames)
{
    string[] reverseSession = new string[sessionNames.Length];

    Array.Copy(
        sessionNames,
        reverseSession,
        sessionNames.Length);

    Array.Reverse(reverseSession);

    Console.WriteLine("\nReversed Session Names:");

    foreach (string item in reverseSession)
    {
        Console.WriteLine(item);
    }
}

ReverseSessionNames(sessionNames);


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

Console.Write("\nEnter session name to find its index: ");
string indexSearch = Console.ReadLine() ?? "";
FindSessionIndex(sessionNames, indexSearch);


// 4.4 Check if a Session Exists

static void SessionExists(
    string[] sessionNames,
    string existSession)
{
    bool result = Array.Exists(
        sessionNames,
        name => name == existSession);

    if (result)
    {
        Console.WriteLine("Session exists.");
    }
    else
    {
        Console.WriteLine("Session does not exist.");
    }
}

Console.Write("\nEnter session name to check existence: ");
string existSession = Console.ReadLine() ?? "";
SessionExists(sessionNames, existSession);


// 4.5 Find a Session

static void FindSession(
    string[] sessionNames,
    string findSession)
{
    string? result = Array.Find(
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

Console.Write("\nEnter session name to find: ");
string findSessionName = Console.ReadLine() ?? "";
FindSession(sessionNames, findSessionName);


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

Console.Write("\nEnter session name to find index using condition: ");
string conditionSearch = Console.ReadLine() ?? "";
FindSessionIndex2(sessionNames, conditionSearch);


// 4.7 Copy an Array

static void CopyArray(string[] sessionNames)
{
    string[] copiedArray = new string[sessionNames.Length];

    Array.Copy(
        sessionNames,
        copiedArray,
        sessionNames.Length);

    copiedArray[0] = "JAVA";

    Console.WriteLine("\nOriginal array:");

    foreach (string item in sessionNames)
    {
        Console.Write($"{item}, ");
    }

    Console.WriteLine("\nCopied array:");

    foreach (string item in copiedArray)
    {
        Console.Write($"{item}, ");
    }

    Console.WriteLine();
}

CopyArray(sessionNames);


/* Part 5 — Duration Analysis */

static int GetTotalDuration(int[] sessionDurations)
{
    int result = 0;

    foreach (int number in sessionDurations)
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

    foreach (int item in copyDu)
    {
        Console.WriteLine(item);
    }
}

Console.WriteLine("\n--- Duration Analysis ---");

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


/* Part 6 — Functions */

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

Console.WriteLine("\n--- Session Details ---");

DisplaySessionDetails(
    sessionNames[0],
    sessionDates[0],
    sessionDurations[0]);

DateTime endTime = GetSessionEndTime(
    sessionDates[0],
    sessionDurations[0]);

Console.WriteLine(
    $"End Time: {endTime.ToString("hh:mm tt", CultureInfo.InvariantCulture)}");

Console.WriteLine("\n--- Read Session Date ---");

DateTime enteredSessionDate = ReadSessionDate();

Console.WriteLine(
    $"Entered Date: {enteredSessionDate.ToString("dd MMMM yyyy hh:mm tt", CultureInfo.InvariantCulture)}");

Console.WriteLine("\n--- String Report ---");
Console.WriteLine(
    BuildReportUsingString(
        sessionNames,
        sessionDates,
        sessionDurations));

Console.WriteLine("--- StringBuilder Report ---");
Console.WriteLine(
    BuildReportUsingStringBuilder(
        sessionNames,
        sessionDates,
        sessionDurations));


/* Part 7 — ref, out, and Reference-Type Parameters */

// 7.1 ref

static void ChangeValue(ref int number)
{
    number = 100;
}

int number = 50;

Console.WriteLine("--- ref Example ---");
Console.WriteLine($"Before calling method: {number}");

ChangeValue(ref number);

Console.WriteLine($"After calling method: {number}");


// 7.2 out

static bool GetSessionInfo(
    string[] sessionNames,
    int[] sessionDurations,
    string searchSession,
    out int index,
    out int duration)
{
    index = Array.IndexOf(
        sessionNames,
        searchSession);

    if (index != -1)
    {
        duration = sessionDurations[index];
        return true;
    }

    duration = 0;
    return false;
}

Console.Write("\nEnter session for out example: ");
string outSearchSession = Console.ReadLine() ?? "";

int outIndex;
int outDuration;

bool found = GetSessionInfo(
    sessionNames,
    sessionDurations,
    outSearchSession,
    out outIndex,
    out outDuration);

if (found)
{
    Console.WriteLine($"Index: {outIndex}");
    Console.WriteLine($"Duration: {outDuration} minutes");
}
else
{
    Console.WriteLine("Session not found.");
}


// 7.3 Reference Type Without ref

static void ChangeArrayValue(int[] numbers)
{
    numbers[0] = 444;
}

int[] arrayNumbers = { 1, 2, 3, 4 };

Console.WriteLine("\n--- Reference Type Without ref ---");

Console.WriteLine("Array before calling method:");

foreach (int item in arrayNumbers)
{
    Console.Write($"{item} ");
}

ChangeArrayValue(arrayNumbers);

Console.WriteLine("\nArray after calling method:");

foreach (int item in arrayNumbers)
{
    Console.Write($"{item} ");
}

Console.WriteLine();


/* Part 8 — params Keyword */

static int CalculateTotalDuration(params int[] sessionDurations)
{
    int result = 0;

    foreach (int item in sessionDurations)
    {
        result += item;
    }

    return result;
}

Console.WriteLine(
    $"\nTotal Duration using params: " +
    $"{CalculateTotalDuration(60, 90, 120, 180, 240)} minutes");


/* Part 9 — Session Date Details */

static void DisplaySessionDateDetails(
    string[] sessionNames,
    DateTime[] sessionDates,
    int[] sessionDurations,
    string searchSession)
{
    int index = Array.IndexOf(
        sessionNames,
        searchSession);

    if (index == -1)
    {
        Console.WriteLine("Session not found.");
        return;
    }

    DateTime date = sessionDates[index];

    Console.WriteLine($"Session: {sessionNames[index]}");
    Console.WriteLine(
        $"Date: {date.ToString("dd MMMM yyyy", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Day: {date.DayOfWeek}");
    Console.WriteLine($"Year: {date.Year}");
    Console.WriteLine($"Month: {date.Month}");
    Console.WriteLine($"Day Number: {date.Day}");
    Console.WriteLine(
        $"Start Time: {date.ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Duration: {sessionDurations[index]} minutes");

    DateTime endTime = date.AddMinutes(sessionDurations[index]);

    Console.WriteLine(
        $"End Time: {endTime.ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
}

Console.Write("\nEnter session for date details: ");
string dateDetailsSession = Console.ReadLine() ?? "";

DisplaySessionDateDetails(
    sessionNames,
    sessionDates,
    sessionDurations,
    dateDetailsSession);


/* Part 10 — Date Difference */

static void CalculateDateDifference(
    string[] sessionNames,
    DateTime[] sessionDates,
    string firstSession,
    string secondSession)
{
    int firstIndex = Array.IndexOf(
        sessionNames,
        firstSession);

    int secondIndex = Array.IndexOf(
        sessionNames,
        secondSession);

    if (firstIndex == -1 || secondIndex == -1)
    {
        Console.WriteLine("Session not found.");
        return;
    }

    DateTime firstDate = sessionDates[firstIndex];
    DateTime secondDate = sessionDates[secondIndex];

    TimeSpan difference = secondDate - firstDate;

    Console.WriteLine(
        $"Difference: {difference.Days} days, " +
        $"{difference.Hours} hours");
}

Console.Write("\nEnter first session: ");
string firstSession = Console.ReadLine() ?? "";

Console.Write("Enter second session: ");
string secondSession = Console.ReadLine() ?? "";

CalculateDateDifference(
    sessionNames,
    sessionDates,
    firstSession,
    secondSession);


/* Part 11 — Past and Upcoming Sessions */

static void DisplaySessionStatus(
    string[] sessionNames,
    DateTime[] sessionDates)
{
    for (int i = 0; i < sessionNames.Length; i++)
    {
        if (sessionDates[i] < DateTime.Now)
        {
            Console.WriteLine($"{sessionNames[i]} - Past");
        }
        else
        {
            Console.WriteLine($"{sessionNames[i]} - Upcoming");
        }
    }
}

Console.WriteLine("\n--- Session Status ---");

DisplaySessionStatus(
    sessionNames,
    sessionDates);


/* Part 12 — Find Next Session */

static void FindNextSession(
    string[] sessionNames,
    DateTime[] sessionDates)
{
    int nextIndex = -1;

    for (int i = 0; i < sessionDates.Length; i++)
    {
        if (sessionDates[i] > DateTime.Now)
        {
            if (nextIndex == -1 ||
                sessionDates[i] < sessionDates[nextIndex])
            {
                nextIndex = i;
            }
        }
    }

    if (nextIndex != -1)
    {
        Console.WriteLine(
            $"Next Session: {sessionNames[nextIndex]}");

        Console.WriteLine(
            $"Date: {sessionDates[nextIndex].ToString(
                "dd MMMM yyyy hh:mm tt",
                CultureInfo.InvariantCulture)}");
    }
    else
    {
        Console.WriteLine("There are no upcoming sessions.");
    }
}

Console.WriteLine("\n--- Next Session ---");

FindNextSession(
    sessionNames,
    sessionDates);


/* Part 13 — Date Formatting */

static void DisplayDateFormats(
    string[] sessionNames,
    DateTime[] sessionDates,
    string searchSession)
{
    int index = Array.IndexOf(
        sessionNames,
        searchSession);

    if (index == -1)
    {
        Console.WriteLine("Session not found.");
        return;
    }

    DateTime date = sessionDates[index];

    Console.WriteLine(date.ToString(
        "yyyy-MM-dd",
        CultureInfo.InvariantCulture));

    Console.WriteLine(date.ToString(
        "dd/MM/yyyy",
        CultureInfo.InvariantCulture));

    Console.WriteLine(date.ToString(
        "dd MMMM yyyy",
        CultureInfo.InvariantCulture));

    Console.WriteLine(date.ToString(
        "dddd, dd MMMM yyyy",
        CultureInfo.InvariantCulture));

    Console.WriteLine(date.ToString(
        "hh:mm tt",
        CultureInfo.InvariantCulture));
}

Console.Write("\nEnter session for date formatting: ");
string formattingSession = Console.ReadLine() ?? "";

DisplayDateFormats(
    sessionNames,
    sessionDates,
    formattingSession);


/* Part 14 — Read and Validate a Date */

static DateTime ReadAndValidateDate()
{
    Console.Write("Enter date (yyyy-MM-dd HH:mm): ");

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

        Console.WriteLine("Invalid date. Try again.");
    }
}

Console.WriteLine("\n--- Validate Date ---");

DateTime validatedDate = ReadAndValidateDate();

Console.WriteLine(
    $"Valid date: {validatedDate.ToString(
        "dd MMMM yyyy hh:mm tt",
        CultureInfo.InvariantCulture)}");


/* Part 15 — Exception Handling: Menu Input */

static int ReadMenuOption()
{
    while (true)
    {
        try
        {
            Console.Write("Choose an option: ");

            string input = Console.ReadLine() ?? "";

            int number = int.Parse(input);

            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Invalid menu option. Enter a number.");
        }
    }
}

Console.WriteLine("\n--- Menu Input ---");

int menuOption = ReadMenuOption();

Console.WriteLine($"You entered: {menuOption}");


/* Part 16 — Exception Handling: Invalid Array Index */

static void AccessSessionByIndex(
    string[] sessionNames)
{
    try
    {
        Console.Write("Enter session index: ");

        string input = Console.ReadLine() ?? "";

        int index = int.Parse(input);

        Console.WriteLine(
            $"Session: {sessionNames[index]}");
    }
    catch (FormatException)
    {
        Console.WriteLine(
            "Invalid input. Enter a valid number.");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine(
            "The selected session index is out of range.");
    }
}

Console.WriteLine("\n--- Array Index Exception ---");

AccessSessionByIndex(sessionNames);


/* Part 17 — Throw an Exception */

static void ValidateDuration(int duration)
{
    if (duration <= 0)
    {
        throw new ArgumentException(
            "Duration must be greater than zero.");
    }
}

Console.Write("\nEnter duration: ");

string durationInput = Console.ReadLine() ?? "";

try
{
    int duration = int.Parse(durationInput);

    ValidateDuration(duration);

    Console.WriteLine("Duration accepted.");
}
catch (FormatException)
{
    Console.WriteLine("Invalid duration. Enter a number.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}


/* Part 18 — finally */

static void ReadNumber()
{
    try
    {
        Console.Write("Enter a number: ");

        string input = Console.ReadLine() ?? "";

        int number = int.Parse(input);

        Console.WriteLine($"You entered: {number}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input.");
    }
    finally
    {
        Console.WriteLine("Input operation finished.");
    }
}

Console.WriteLine("\n--- finally Example ---");

ReadNumber();
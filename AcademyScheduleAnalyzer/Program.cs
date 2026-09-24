using System.Globalization;
using System.Net.Security;
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

        Console.Write("Invalid date ,Try again: ");
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


/*Part 7 — ref, out, and Reference-Type Parameters*/
//7.1 ref
static void ChangeValue(ref int number)
{
    number = 100;
}

int number = 50;
Console.WriteLine($"before calling method:{number}");
ChangeValue(ref number);
Console.WriteLine($"after calling method::{number}");

//7.2 out
static bool GetSessionInfo(string[] sessionNames, int[] sessionDurations, string searchSession, out int index,
    out int duration)
{
     index  = Array.IndexOf(sessionNames, searchSession);
     if (index != -1)
     {
         duration = sessionDurations[index];
         return true;
     }
     else
     {
         duration = 0;
         return false;
     }

}
Console.Write("Enter session: ");
string searchSession=Console.ReadLine()!;
int index;
int duration;

var found=GetSessionInfo(sessionNames, sessionDurations, searchSession, out index, out duration);
if (found)
{
    Console.WriteLine($"Index: {index} ");
    Console.WriteLine($"Duration: {duration} minutes");
}
else
{ Console.WriteLine("Session not found."); }


//7.3 Reference Type Without ref
static void change(int[] x)
{
    x[0] = 444;
    
}

int [] arrayNumbs= [1,2,3,4];
Console.WriteLine("array before calling method :");
for (int i = 0; i < arrayNumbs.Length; i++)
{
    Console.Write(arrayNumbs[i]);

    if (i < arrayNumbs.Length - 1)
    {
        Console.Write(",");
    }
}
change(arrayNumbs);
Console.WriteLine("\narray after calling method :");
for (int i = 0; i < arrayNumbs.Length; i++)
{
    Console.Write(arrayNumbs[i]);

    if (i < arrayNumbs.Length - 1)
    {
        Console.Write(",");
    }
}



/*Part 8 — params Keyword*/

static int CalculateTotalDuration(params int[] sessionDurations)
{
    int result = 0;
    foreach (var items in sessionDurations )
    {
        result += items;
    }

    return result;
}
Console.WriteLine($"\n Total Duration: {CalculateTotalDuration(60, 90, 120, 180, 240)}");



/*Part 9 — Session Date Details*/

static void DisplaySessionDateDetails(
    string[] sessionNames,
    DateTime[] sessionDates,
    int[] sessionDurations,
    string searchSession)
{
    
    int index = Array.IndexOf(sessionNames, searchSession);

    if (index == -1)
    {
        Console.WriteLine("Session not found.");
        return;
    }
    
    DateTime date = sessionDates[index];

    Console.WriteLine($"Session: {sessionNames[index]}");
    Console.WriteLine($"Date: {date.ToString("dd MMMM yyyy", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Day: {date.DayOfWeek}");
    Console.WriteLine($"Year: {date.Year}");
    Console.WriteLine($"Month: {date.Month}");
    Console.WriteLine($"Day Number: {date.Day}");
    Console.WriteLine($"Start Time: {date.ToString("hh:mm tt", CultureInfo.InvariantCulture)}");

    Console.WriteLine($"Duration: {sessionDurations[index]} minutes");

    DateTime endTime = date.AddMinutes(sessionDurations[index]);

    Console.WriteLine($"End Time: {endTime.ToString("hh:mm tt", CultureInfo.InvariantCulture)}");
}


/*Part 10 — Date Difference*/
static void CalculateDateDifference(string[] sessionNames,  DateTime[] sessionDates, string firstSession, string secondSession)
{
    int firstIndex = Array.IndexOf(sessionNames, firstSession);
    int secondIndex = Array.IndexOf(sessionNames, secondSession);
    if (firstIndex==-1 || secondIndex== -1)
    {
        Console.WriteLine("Session not found.");
        return;
    }

    DateTime firstDate = sessionDates[firstIndex];
    DateTime secondDate = sessionDates[secondIndex];

    TimeSpan difference = secondDate - firstDate;
}


/*Part 11 — Past and Upcoming Sessions*/

static void DisplaySessionStatus(string[] sessionNames, DateTime[] sessionDates)
{
    for (int i = 0; i < sessionNames.Length; i++)
    {
        if (sessionDates[i]<DateTime.Now)
        {
            Console.WriteLine($"{sessionNames[i]} Past ");
        }
        else
        {
            Console.WriteLine($"{sessionNames[i]} Upcoming ");

        }
    }

}
DisplaySessionStatus(sessionNames, sessionDates);

/*
Part 13 — Date Formatting
 */
static void DisplayDateFormats(string[] sessionNames, DateTime[] sessionDates, string searchSession)
{
    int index = Array.IndexOf(sessionNames, searchSession);

    if (index == -1)
    {
        Console.WriteLine("Session not found.");
        return;
    }

    DateTime date = sessionDates[index];

    Console.WriteLine(date.ToString("yyyy-MM-dd"));
    Console.WriteLine(date.ToString("dd/MM/yyyy"));
    Console.WriteLine(date.ToString("dd MMMM yyyy"));
    Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
    Console.WriteLine(date.ToString("hh:mm tt"));
}

/*Part 14 — Read and Validate a Date*/
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
        Console.WriteLine("invalid date");
    }
}


/*Part 15 — Exception Handling: Menu Input*/
static int ReadMenuOption()
{
    while (true)
    {
        try
        {
           Console.Write("Choose an option: ");
           string? input = Console.ReadLine();
           int num = int.Parse(input);
           return num;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid menu option. Enter a number.");

        }
    }
}
int n=ReadMenuOption();
Console.WriteLine($"{n}");



/*Part 16 — Exception Handling: Invalid Array Index*/

static void AccessSessionByIndex(
    string[] sessionNames)
{
    Console.Write("Enter session index: ");
    int index = int.Parse(Console.ReadLine()!);

    try
    {
        Console.WriteLine($"session :{sessionNames[index]}");
             
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("The selected session index is out of range.\n");
       
    }
   
} 

/*Part 17 — Throw an Exception*/             
                                                                                          
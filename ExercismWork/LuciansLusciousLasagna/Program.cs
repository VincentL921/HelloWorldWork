
//var lasagna = new Food();

//lasagna.CookMinutes = 40;
//lasagna.LasagnaLayers = 5;

//var logLine = "[ERROR] this is my message";
//var messageSplit = logLine.Split(":");
//Console.WriteLine(messageSplit);

//var colon = logLine.Split(":");
//// ternary operator 
//var message = colon.Length > 2 ? colon[2] : colon[1];
//message = message.Trim();


//var colonOne = logLine.Split(":");
////ternary operator
//var messageOne = colonOne[0];
//messageOne = messageOne.Trim();


//Log Analysis work
var result = "[INFO]: File Deleted.".SubstringAfter(":");
Console.WriteLine(result);

var log = "[INFO]: File Deleted.";
var splitLog = log.SubstringBetween("[", "]"); // => returns "INFO"
Console.WriteLine(splitLog);

var logAndMessage = "[WARNING]: Library is deprecated.";
var message = logAndMessage.Message();
Console.WriteLine(message);

var messageAndlog = "[WARNING]: Library is deprecated.";
var logLine = messageAndlog.LogLevel();
Console.WriteLine(logLine);

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string log, string divider)
    {
        var logSplit = log.Split(divider);
        var message = logSplit.Length > 1 ? logSplit[1] : logSplit[0];
        message = message.Trim();
        return message;
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string log, string splitOne, string splitTwo)
    {
        var logSplit = log.Split(splitOne);
        var logLevel = logSplit[1];
        var secondSplit = logLevel.Split(splitTwo);
        var anotherVariable = secondSplit[0];
        return anotherVariable;

    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logline)
    {
        var splitLogLine = logline.Split(":");
        var message = splitLogLine.Length > 1 ? splitLogLine[1] : splitLogLine[0];
        message = message.Trim();
        return message;
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logline)
    {
        var splitLogLine = logline.Split(":");
        var logLevel = splitLogLine[0];
        logLevel = logLevel.Trim().Replace("[", "").Replace("]", "");
        return logLevel;
    }

}




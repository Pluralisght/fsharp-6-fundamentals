using System.Text;

var path = @"F:\fsharp-6-fundamentals\media\02\02-01 Module Introduction.tscproj\02 - 01 merged subs.srt";

var all = File.ReadAllLines(path);

var allLines = all.Where((l, i) => (i<=3 && i== 2) || (i >= 3 && ((i-6)%4 == 0))).ToArray();

var swaps = new Dictionary<string, string>()
{
    { "F. sharp", "F#" },
    { "F. shark", "F#" },
    { "F.", "F#" },
    { "C. sharp", "C#" },
    { "C. short", "C#" },
    { "C .", "C#" },
    { "C.", "C#" },
    { "half sharp", "F#" },
    { "F# short", "F#" },
    { "F#est", "F# is" },
    { "N. night", "F#" },
    { "have sharp", "F#" },
    { "semi colons", "semi-colons" },
    { "semi colon", "semi-colons" },
    { "F#s", "F#'s" },
    { "I N. I. dash F.", "ionide-fsharp" },
    { "FSR", "FSI" },
    { "have short", "F#" },
    { "dot net K.", ".NET SDK" },
    { "check brains writer", "JetBrains Rider" },
    { "F# dash I United", "ionide-fsharp" },
    { "S. T. K.", "SDK" },
    { "T. DST case", "SDK is" },
    { "T. DST", "SDK" },
    { "S. T. case", "SDKs" },
    { "I. N. I.", "ionide" },
    { "illiterate", "editor" },
    { "diluting K.", "SDK" },
    { "K.", "SDK" },
    { "deluded", "downloaded" },
    { "market please", "market place" },
    { "hi night hyphen", "ionide-dash" },
    { "I. dash F#", "ionide-fsharp" },
    { "Lennix", "Linux" },
    { "two point two", "Ubuntu" },
    { "page forty", "page for the" },
    { "in instead", "and instead" },
    { "Lestat's case", "SDKs" },
    { "F#ener active", "interactive" },
    { "FSI interactive", "F# interactive" },
    { "in there", "and there" },
    { "in that", "and that" },
    { "in install", "and install" },
    { "so phone is", "so from this" },
    { "is that whatus", "and that will take us" },
    { "thirty STK", "there the SDK" },
    { "hi I'd hyphen", "ionide-" },
    { "I and II", "ionide" },
    { "comedians", "commands" },
    { "in the central", "An essential" },
    { "darknet commander", "dotnet commands" },
    { "we'll give", "will give" },
    { "dash dash Lestat's", "dash dash list" },
    { "runtimes NST case", "runtime and SDKs" },
    { "aftershock project", "F# project" },
    { "S. P. dot", "ASP .net" },
    { "Blazers", "Blazor" },
    { "see sharp", "C#" },
    { "I. night", "ionide" },
    { "F#er", "F# or" },
    { "XC", "EXE" },
    { "it it's", "and its" },
    { "deal well", "DLL" },
    { "counsel", "console" },
    { "in in", "and in" },
    { "F# S.", "fsproj" },
    { "in if", "and if" },
    { "dash flying", "-lang" },
    { "that's Wang sharp", "-lang F#" },
    { "new get", "NUGET" },
    { "comet", "comment" },
    { "I checks", "projects" },
    { "dot net site", "dotnet fsi" },
    { "S. short", "F#" },
    { "go in", "go and" },
    { "dash line", "dash F#" },
    { "dot net sex", "dot net 6" },
    { "executed will", "executable" },
    { "a deal",  "a DLL" },
    { "wanna", "want to" },
    { "gonna", "going to" },
    { "coat", "code" },
    { "fiasco", " VS Code" },
    { "ionized", "ionide" },
    { "Iranian night dash", "ionide-" },
    { "launch dot chase", "launch.json" },
    { "yeah we're", "Now we're" },
    { "one star chaser", "launch.json" },
    { "free work", "framework" },
    { "six", "6" },
    { "five", "5" },
    { "T. L. L.", "DLL" },
    { "hours simply", "our assembly" },
    { "honest", "on this" },
    { "task dot song", "task.json" },
    { "chase on", "JSON" },
    { "offshore", "F#" },
    { "yeah there", "and there" },
    { "debunking", "debugging" },
    { "council", "console" },
    { "to buggy", "debugging" },
    { "control F# 5", "control-F5" },
    { "depart consul", "debug console" },
    { "ended bunker", "in the debugger" },
    { "to cope", "the code" },
    { "pressing F# 5", "F5" },
    { "F# ten", "F10" },
    { "F# eleven", "F11" },
    { "dysfunction", "this function" },
    { "Michael height", "Michael Heydt" },
    { "C#en", "C# and" }
};

allLines.ToList().ForEach(global::System.Console.WriteLine);

var allText = string.Join(" ", allLines);
Console.WriteLine(allText);

while (true)
{
    var any = false;
    foreach (var k in swaps.Keys)
    {
        var newText = allText.Replace(k, swaps[k]);
        if (newText != allText)
        {
            any = true;
        }
        allText = newText;
    }
    if (!any) break;
}

var builder = new StringBuilder();
var wordsPerLine = 10;
var allWords = allText.Split(' ');
var i = 0;
while (i < allWords.Length)
{
    if (((i + 1) % wordsPerLine) == 0)
    {
        builder.AppendLine();
    }
    builder.Append(allWords[i]);
    builder.Append(" ");
    i++;
}

Console.WriteLine(builder);

var outfile = path + ".txt";
File.WriteAllText(outfile, String.Join(' ', allWords));
File.AppendAllText(outfile, "\r\n\r\n");
File.AppendAllText(outfile, builder.ToString());
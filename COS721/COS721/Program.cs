using COS721.ToolMarks;

string[] eMFiles =
{
    "eM - image - eM",
    "eM - image - gmail",
    "eM - image - thunderbird",
    "eM - image - windows",
    "eM - text - eM",
    "eM - text - gmail",
    "eM - text - thunderbird",
    "eM - text - windows",
};

string[] gmailFiles =
{
    "gmail - image - eM",
    "gmail - image - gmail",
    "gmail - image - thunderbird",
    "gmail - image - windows",
    "gmail - text - eM",
    "gmail - text - gmail",
    "gmail - text - thunderbird",
    "gmail - text - windows",
};

string[] thunderbirdFiles =
{
    "Thunderbird - image - eM",
    "Thunderbird - image - gmail",
    "Thunderbird - image - thunderbird",
    "Thunderbird - image - windows",
    "Thunderbird - text - eM",
    "Thunderbird - text - gmail",
    "Thunderbird - text - thunderbird",
    "Thunderbird - text - windows",
};

string[] windowsFiles =
{
    "windows - image - eM",
    "windows - image - gmail",
    "windows - image - thunderbird",
    "windows - image - windows"
};

var files = eMFiles.Concat(gmailFiles).Concat(thunderbirdFiles).Concat(windowsFiles);
var path = "C:/Users/arno1/Documents/Tuks/Honeurs/COS721/A3/TestFiles/";
var tools = new List<ToolMark>();

tools.Add(new EM());
tools.Add(new Gmail());
tools.Add(new Thunderbird());
tools.Add(new SentByWindowsSavedByOtherTools());
tools.Add(new WindowsWindows());
tools.Add(new WindowsEm());
tools.Add(new WindowsGmail());
tools.Add(new WindowsThunderbird());
tools.Add(new WindowsWindows());
tools.Add(new WindowsEm());
tools.Add(new WindowsThunderbird());
tools.Add(new WindowsGmail());
var savedByWindows = new SavedByWindows();

var winningTool = new List<double>();

foreach (var fileName in files)
{
    // Keep the console window open in debug mode.
    Console.WriteLine();

    if (fileName == "q")
    {
        Environment.Exit(0);
    }

    winningTool.Add(tools[0].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[1].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[2].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[3].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[4].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[5].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[6].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[7].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[8].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[9].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[10].ReadFile(path, fileName ?? ""));
    winningTool.Add( tools[11].ReadFile(path, fileName ?? ""));

    var max = winningTool.Max(x => x);
    var winner = winningTool.FindIndex(x => x == max);

    if (max > 0.5)
    {
        Console.WriteLine("Creator tool: " + tools[winner].GetToolName() + ", toolMarks matched: " + max * 100 + "%");
    }
    else
    {
        Console.WriteLine("Creator tool: could not be determined, toolMarks matched: " + max * 100 + "%");
    }

    var containsAttachmentProbability = tools[winner].ContainsAttachmentProbability();
    if (containsAttachmentProbability > 0.8)
    {
        Console.WriteLine("Attachment, toolMarks matched: " + containsAttachmentProbability * 100 + "%");
    }
    else
    {
        Console.WriteLine("No attachment, toolMarks matched: " + containsAttachmentProbability * 100 + "%");
    }

    var isSavedByWindows = savedByWindows.ReadFile(path, fileName ?? "");
    if (isSavedByWindows > 0.8)
    {
        Console.WriteLine("The file was likely saved by the windows client, probability: " + isSavedByWindows * 100 + "%");
    }
    
    winningTool.Clear();
}
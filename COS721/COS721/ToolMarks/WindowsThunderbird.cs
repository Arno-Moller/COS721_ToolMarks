namespace COS721.ToolMarks;

public class WindowsThunderbird : ToolMark
{
    public WindowsThunderbird()
    {
        string[] featureVector =
        {
            "MIME-Version: 1.0",
            "Date: ",
            "From:",
            "Subject: ",
            "Thread-Topic: ",
            "Message-ID:",
            "To:",
            "Content-Transfer-Encoding: base64",
        };

        string[] exactFeatureVector =
        {
            "<html>",
            "<head>",
            "=20",
            "</head>",
            "<body>",
            "</body>",
            "</html>="
        };

        CreateDictionary(featureVector, Array.Empty<string>(), exactFeatureVector);

        ToolName = "Thunderbird";
    }
}
namespace COS721.ToolMarks;

public class SavedByWindows : ToolMark
{
    public SavedByWindows()
    {
        string[] featureVector =
        {
            "MIME-Version: 1.0",
            "Date:",
            "From: ",
            "Subject:",
            "Thread-Topic:",
            "Message-ID:",
            "To:",
            "Content-Type:",
        };

        string[] containsFeatureVector = { };

        CreateDictionary(featureVector, containsFeatureVector,Array.Empty<string>());

        ToolName = "Saved Widows";
    }
}
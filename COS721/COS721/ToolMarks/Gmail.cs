namespace COS721.ToolMarks;

public class Gmail : ToolMark
{
    public Gmail()
    {
        string[] featureVector =
        {
            "MIME-Version: 1.0",
            "Date:",
            "Message-ID:",
            "Subject:",
            "From:",
            "To:",
            "Content-Type:",
            "<div dir=\"ltr\">",
        };
        
        string[] attachmentFeatureVector =
        {
            "Content-Type: multipart/alternative;",
            "Content-Disposition:",
            "Content-Transfer-Encoding: base64",
            "X-Attachment-Id:",
            "Content-ID:"
        };
        
        CreateDictionary(featureVector, Array.Empty<string>(), attachmentFeatureVector);

        ToolName = "gmail";
    }
}
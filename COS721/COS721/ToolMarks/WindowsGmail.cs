namespace COS721.ToolMarks;

public class WindowsGmail : ToolMark
{
    public WindowsGmail()
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
            "Content-Transfer-Encoding: quoted-printable",
            "Content-Type: text/html; charset=\"utf-8\""
        };

        string[] exactFeatureVector =
        {
            "<div dir=3D\"ltr\">"
        };

        CreateDictionary(featureVector, Array.Empty<string>(), exactFeatureVector);

        ToolName = "Thunderbird";
    }
}
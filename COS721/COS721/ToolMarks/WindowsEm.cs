namespace COS721.ToolMarks;

public class WindowsEm : ToolMark
{
    public WindowsEm()
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
            "Content-Type: text/html; charset=\"utf-8\"",
            "<html><head>",
            "<style id=3D\"css_styles\">",
            "--></style>",
            "</head>",
        };

        string[] exactFeatureVector =
        {
            "Content-Type: multipart/mixed;",
            "<body>",
            "</body></html>=",
        };

        CreateDictionary(featureVector, Array.Empty<string>(), exactFeatureVector);

        ToolName = "eM";
    }
}
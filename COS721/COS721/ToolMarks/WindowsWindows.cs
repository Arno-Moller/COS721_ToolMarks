namespace COS721.ToolMarks;

public class WindowsWindows : ToolMark
{
    public WindowsWindows()
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
            "<html><head><meta name=3D\"Generator\" content=3D\"Microsoft Word 15 (filtered=",
            " medium)\"><style><!--",
            "--></style></head><body lang=3D\"EN-ZA\" link=3D\"blue\" vlink=3D\"#954F72\" styl=",
            "e=3D\"word-wrap:break-word\"><div class=3D\"WordSection1\">"
        };

        string[] exactFeatureVector =
        {
            "Content-Type:",
            "Content-Transfer-Encoding:",
            "Content-Disposition: attachment",
        };

        CreateDictionary(featureVector, Array.Empty<string>(), exactFeatureVector);

        ToolName = "Widows";
    }
}
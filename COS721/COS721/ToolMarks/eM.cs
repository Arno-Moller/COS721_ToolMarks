namespace COS721.ToolMarks;

public class EM : ToolMark
{
    public EM()
    {
        string[] featureVector =
        {
            "Return-Path:",
            "Received: from",
            "From: ",
            "To:",
            "Subject:",
            "Date:",
            "Message-Id:",
            "Reply-To:",
            "User-Agent: eM_Client/9.1.2109.0",
            "MIME-Version: 1.0",
            "Content-Type: multipart/alternative;",
            "Content-Type: text/plain; charset=utf-8; format=flowed",
            "Content-Transfer-Encoding: quoted-printable",
            "Content-Type: text/html; charset=utf-8",
            "<html><head>",
            "<style id=3D\"css_styles\">=20",
            " </style>",
            "</head>",
            "<body>",
        };
        
        string[] containsFeatureVector =
        {
            "by",
            "for",
            "(version=TLS1_",
        };
        
        string[] attachmentFeatureVector =
        {
            "Content-Type: multipart/mixed;"
        };
        
        CreateDictionary(featureVector, containsFeatureVector, attachmentFeatureVector);

        ToolName = "eM";
    }
}
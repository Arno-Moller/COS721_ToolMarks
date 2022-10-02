namespace COS721.ToolMarks;

public class Thunderbird: ToolMark
{
    public Thunderbird()
    {
        string[] featureVector =
        {
            "Return-Path:",
            "Received: from",
            "Message-ID:",
            "Date:",
            "MIME-Version: 1.0",
            "User-Agent: Mozilla/5.0",
            "Content-Language: en-US",
            "To: ",
            "From:",
            "Subject:",
            "Content-Type: text/plain; charset=UTF-8; format=flowed",
            "Content-Transfer-Encoding: 7bit",
        };

        string[] containsFeatureVector =
        {
            "by",
            "for",
            "(version=TLS1_",
            "Thunderbird"
        };
        
        string[] attachmentFeatureVector =
        {
            "<html>",
            "  <head>",
            "    <meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\">",
            "  </head>",
            "  <body>",
            "  </body>",
            "</html>",
            "Content-Disposition: ",
            "Content-Id: ",
        };

        CreateDictionary(featureVector, containsFeatureVector,  attachmentFeatureVector);

        ToolName = "Thunderbird";
    }
}
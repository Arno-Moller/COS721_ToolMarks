namespace COS721.ToolMarks;

public class SentByWindowsSavedByOtherTools : ToolMark
{
    public SentByWindowsSavedByOtherTools()
    {
        string[] featureVector =
        {
            "Return-Path:",
            "Received: from",
            "MIME-Version: 1.0",
            "Date:",
            "From:",
            "Subject:",
            "Thread-Topic:",
            "Message-ID:",
            "To:",
            "Content-Transfer-Encoding: quoted-printable",
            "Content-Type: text/html; charset=\"utf-8\"",
            "<html xmlns:o=3D\"urn:schemas-microsoft-com:office:office\" xmlns:w=3D\"urn:sc=",
            "hemas-microsoft-com:office:word\" xmlns:m=3D\"http://schemas.microsoft.com/of=",
            "fice/2004/12/omml\" xmlns=3D\"http://www.w3.org/TR/REC-html40\"><head><meta ht=",
            "tp-equiv=3DContent-Type content=3D\"text/html; charset=3Dutf-8\"><meta name=",
            "=3DGenerator content=3D\"Microsoft Word 15 (filtered medium)\"><style><!--",
        };

        string[] containsFeatureVector =
        {
            
        };
        
        string[] attachmentFeatureVector =
        {
          "Content-Type: multipart/mixed;" 
        };

        CreateDictionary(featureVector, containsFeatureVector,  attachmentFeatureVector);

        ToolName = "Windows";
    }
}
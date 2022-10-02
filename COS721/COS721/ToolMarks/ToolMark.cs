namespace COS721.ToolMarks;

public class ToolMark
{
    private readonly Dictionary<string, bool> _toolMarks = new Dictionary<string, bool>();
    private readonly Dictionary<string, bool> _containsToolMarks = new Dictionary<string, bool>();
    private readonly Dictionary<string, bool> _exactToolMarks = new Dictionary<string, bool>();
    private List<string> _featureVector = new List<string>();
    private List<string> _containsFeatureVector = new List<string>();
    private List<string> _exactFeatureVector = new List<string>();
    protected string? ToolName;
    
    public double ReadFile(string path, string fileName)
    {
        ResetDictionary();

        var lines = File.ReadAllLines(path + fileName + ".eml");

        foreach (var line in lines)
        {
            if(_featureVector.Count > 0) CheckToolMark(line, _featureVector, _toolMarks, "start");
            if(_featureVector.Count > 0) CheckToolMark(line, _featureVector, _toolMarks, "end");
            if(_containsFeatureVector.Count > 0) CheckToolMark(line, _containsFeatureVector, _containsToolMarks, "contain");
            if(_exactFeatureVector.Count > 0) CheckToolMark(line, _exactFeatureVector, _exactToolMarks, "attach");
        }

        var trueFeaturesCount = 0.0;
        trueFeaturesCount += _featureVector.Count > 0 ? _toolMarks.Where(x => x.Value).Count() : 0;
        trueFeaturesCount += _containsFeatureVector.Count > 0 ? _containsToolMarks.Where(x => x.Value).Count() : 0;

        var totalFeatureCount = (double)(_toolMarks.Count + _containsToolMarks.Count );
        return (double)(trueFeaturesCount / totalFeatureCount);
    }

    public string GetToolName()
    {
        return ToolName;
    }

    public double ContainsAttachmentProbability()
    {
        return _exactToolMarks.Count > 0 ? (_exactToolMarks.Where(x => x.Value).Count() / _exactToolMarks.Count) : 0;
    }
    
    protected void CreateDictionary(string[] featureVector, string[] containsFeatureVector, string[] exactFeatureVector)
    {
        _featureVector = featureVector.ToList();
        foreach (var feature in featureVector)
        {
            _toolMarks.Add(feature, false);
        }

        _containsFeatureVector = containsFeatureVector.ToList();
        foreach (var feature in containsFeatureVector)
        {
            _containsToolMarks.Add(feature, false);
        }

        _exactFeatureVector = exactFeatureVector.ToList();
        foreach (var feature in exactFeatureVector)
        {
            _exactToolMarks.Add(feature, false);
        }
    }

    private void ResetDictionary()
    {
        foreach (var toolMark in _toolMarks)
        {
            _toolMarks[toolMark.Key] = false;
        }

        foreach (var toolMark in _containsToolMarks)
        {
            _containsToolMarks[toolMark.Key] = false;
        }

        foreach (var toolMark in _exactToolMarks)
        {
            _exactToolMarks[toolMark.Key] = false;
        }
    }

    private void CheckToolMark(string line, List<string> featureVector, Dictionary<string, bool> dictionary,
        string type)
    {
        var featureExists = "";
        switch (type)
        {
            case "start":
                featureExists = dictionary.Keys.ToList().Find(x => line.StartsWith(x));
                break;
            case "end":
                featureExists = dictionary.Keys.ToList().Find(x => line.EndsWith(x));
                break;
            case "contain":
                featureExists = dictionary.Keys.ToList().Find(x => line.Contains(x));
                break;
            case "attach":
                featureExists = dictionary.Keys.ToList().Find(x => line.Contains(x));
                break;
            default:
                return;
        }

        if (featureExists is null) return;

        var featureIndex = featureVector.FindIndex(x => x == featureExists);
        if (featureIndex > 0)
        {
            if (dictionary[featureVector[featureIndex - 1]])
            {
                dictionary[featureExists] = true;
            }
        }
        else
        {
            dictionary[featureExists] = true;
        }
    }

}
using System.Text.RegularExpressions;

int idStart = 15790;
int freeId = 15893;
var file = File.ReadAllText("cs_eveda.xml");
var matches = Regex.Matches(file, "/#(\\d+)/");
foreach (Match match in matches)
{
    var val = match.Value;
}
using System.Text.Json;

namespace CookiesRecipeApp.DataAccess;

public class StringsJsonRepository : StringsRepository
{
	public void Write(string filePath, List<string> strings)
	{
		File.WriteAllText(filePath, JsonSerializer.Serialize(strings));
	}

	protected override string StringsToText(List<string> strings)
	{
		return JsonSerializer.Serialize(strings);
	}

	protected override List<string> TextToStrings(string fileContents)
	{
		return JsonSerializer.Deserialize<List<string>>(fileContents);
	}
}

namespace MysticPartyTracker.Models;

public class Result
{
	public string Index { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public int Level { get; set; }
	public string Url { get; set; } = string.Empty;
}

public class Response
{
	public int Count { get; set; }
	public List<Result> Results { get; set; }
}
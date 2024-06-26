namespace ktsu;

using CommandLine;

internal class Arguments
{
	[Option('l')]
	public bool Alliterate { get; set; } = false;

	[Option('c')]
	public string CaseType { get; set; } = "title";

	[Option('f')]
	public char FirstLetter { get; set; } = char.MinValue;

	[Option('a')]
	public int Amount { get; set; } = 1;

	[Option('p')]
	public bool Pause { get; set; } = false;
}

namespace ktsu;

using CommandLine;

internal class Arguments
{
	[Option]
	public bool Alliterate { get; set; } = false;

	[Option]
	public CaseType CaseType { get; set; } = CaseType.Title;

	[Option]
	public char FirstLetter { get; set; } = char.MinValue;

	[Option]
	public int Amount { get; set; } = 1;

	[Option]
	public bool Pause { get; set; } = true;
}

using System;

namespace HebCalCSharp
{
	public class ParashaAnnual2
	{
		public int Id { get; set; }
		public string Torah { get; set; }
		public DateTime ReadDate { get; set; }
		public string HebrewDate { get; set; } //
		public string ParashaName { get; set; }
		public string NameUrl { get; set; }
		public string Meaning { get; set; }
		public byte DoubleHeader { get; set; }
		public bool IsWeeklyParasha { get; set; }
	}
}

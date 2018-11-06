
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace HebCalCSharp
{
  [DataContract(Name = "converter")]
  public class Converter
  {
    [DataMember(Name = "gy")]
    public int GregorianYear { get; set; }

    [DataMember(Name = "gm")]
    public int GregorianMonth { get; set; }

    [DataMember(Name = "gd")]
    public int GregorianDay { get; set; }

    [DataMember(Name = "hy")]
    public int HebrewYear { get; set; } // 5771

    [DataMember(Name = "hm")]
    public string HebrewMonth { get; set; }  //"Iyyar"

    public String HebrewMonthTsql
    {
      //get { return HebrewMonth.Replace("'", "''"); }
      get { return HebrewMonth.Replace("Sh'vat", "Shevat"); }
    }

    [DataMember(Name = "hd")]
    public int HebrewDay { get; set; }

    [DataMember(Name = "hebrew")]
    public string HebrewDateName { get; set; } // json

    [DataMember(Name = "events")]
    public List<string> Events { get; set; }

    public String UpdateSql
    {
      get
      {
        return $"UPDATE ParashaAnnual SET HebrewDate = '{HebrewDay} {HebrewMonthTsql}' WHERE ReadDate = '{GregorianYear}-{GregorianMonth}-{GregorianDay}' -- {HebrewYear} {EventsDump}";
      }
    }

    public String SelectRowCountSql
    {
      get
      {
        return $"SELECT COUNT(*) AS RowCnt{GregorianYear}{GregorianMonth}{GregorianDay} FROM ParashaAnnual WHERE ReadDate = '{GregorianYear}-{GregorianMonth}-{GregorianDay}' -- {HebrewYear} {EventsDump}";
      }
    }

    public String EventsDump
    {
      get { return string.Join(",", Events.ToArray()); }
    }
    
  }
}
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HebCalCSharp
{
  class Program
  {
    private static readonly HttpClient client = new HttpClient();

    static void Main(string[] args)
    {
      Console.WriteLine("Start...");

      List<ParashaAnnual2> db = new List<ParashaAnnual2>(ParashaAnnual2DataFactory.GetAll());
      
      foreach (var item in db)
			{
        GetUpdateSql(item.ReadDate.ToString("yyyy"), item.ReadDate.ToString("MM"),item.ReadDate.ToString("dd")).Wait();
        //GetSelectRowCountSql(item.ReadDate.ToString("yyyy"), item.ReadDate.ToString("MM"),item.ReadDate.ToString("dd")).Wait();
      }
      Console.WriteLine("Finish");
    }

    private static async Task GetUpdateSql(string yyyy, string mm, string dd)
    {
      string ConverterUri = $"https://www.hebcal.com/converter/?cfg=json&gy={yyyy}&gm={mm}&gd={dd}&g2h=1";
      client.DefaultRequestHeaders.Accept.Clear();
      var stringTask = client.GetStringAsync(ConverterUri);
      var msg = await stringTask;
      Converter converter = JsonConvert.DeserializeObject<Converter>(msg);
      Console.WriteLine($"{converter.UpdateSql}");
    }

/*
If any of the TSql run query shows up not != 1, then you need to take notice e.g. if 2, then DoubleHeader == 1 and 2
*/
    private static async Task GetSelectRowCountSql(string yyyy, string mm, string dd)
    {
      string ConverterUri = $"https://www.hebcal.com/converter/?cfg=json&gy={yyyy}&gm={mm}&gd={dd}&g2h=1";
      client.DefaultRequestHeaders.Accept.Clear();
      var stringTask = client.GetStringAsync(ConverterUri);
      var msg = await stringTask;
      Converter converter = JsonConvert.DeserializeObject<Converter>(msg);
      //Console.WriteLine($"Greg YMD - {converter.GregorianYear}/{converter.GregorianMonth}/{converter.GregorianDay} ");
      //Console.WriteLine($"Heb YMD - {converter.HebrewYear}/{converter.HebrewMonth}/{converter.HebrewDay} in Hebrew -> {vm.HebrewDateName} ");
      Console.WriteLine($"{converter.SelectRowCountSql}");
    }



  }
}

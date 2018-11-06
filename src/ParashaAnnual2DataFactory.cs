using System;
using System.Collections.Generic;
using System.Linq;

namespace HebCalCSharp
{
	public class ParashaAnnual2DataFactory
	{
		public static IQueryable<ParashaAnnual2> GetAll()
		{
			/*  Copied from d:\tfs\myhebrewbiblevnext\bible.domain\dictionaries\parashaannual2datafactory.cs  */
			return new List<ParashaAnnual2>
			{
new ParashaAnnual2 {  Id=1, Torah="Gen 1:1-6:8", ReadDate=DateTime.Parse("10/06/2018"), ParashaName="B'reisheet", NameUrl="b-reisheet-genesis-1-1-to-6-8", Meaning="In the beginning", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=2, Torah="Gen 6:9-11:32", ReadDate=DateTime.Parse("10/13/2018"), ParashaName="Noach", NameUrl="noach-genesis-6-9-to-11-32", Meaning="Rest", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=3, Torah="Gen 12:1-17:27", ReadDate=DateTime.Parse("10/20/2018"), ParashaName="Lech L’cha", NameUrl="lech-l-cha-genesis-12-1-to-17-27", Meaning="Get yourself", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=4, Torah="Gen 18:1-22:24", ReadDate=DateTime.Parse("10/27/2018"), ParashaName="Vayera", NameUrl="vayera-genesis-18-1-to-22-24", Meaning="And He appeared", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=5, Torah="Gen 23:1-25:18", ReadDate=DateTime.Parse("11/03/2018"), ParashaName="Chaye Sarah", NameUrl="chaye-sarah-genesis-23-1-to-25-18", Meaning="Life of Sarah", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=6, Torah="Gen 25:19-28:9", ReadDate=DateTime.Parse("11/10/2018"), ParashaName="Tole'dot", NameUrl="tole-dot-genesis-25-19-to-28-9", Meaning="Generations", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=7, Torah="Gen 28:10-32:3", ReadDate=DateTime.Parse("11/17/2018"), ParashaName="Vayetse", NameUrl="vayetse-genesis-28-10-to-32-3", Meaning="And He went out", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=8, Torah="Gen 32:4-36:43", ReadDate=DateTime.Parse("11/24/2018"), ParashaName="Vayishlach", NameUrl="vayishlach-genesis-32-4-to-36-43", Meaning="And He sent", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=9, Torah="Gen 37:1-40:23", ReadDate=DateTime.Parse("12/01/2018"), ParashaName="Vayeshev", NameUrl="vayeshev-genesis-37-1-to-40-23", Meaning="And He settled", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=61, Torah="Num 7:1-8:4", ReadDate=DateTime.Parse("12/02/2018"), ParashaName="Erev Hanukkah", NameUrl="erev-hanukkah-numbers-7-1-to-8-4", Meaning="Feast of Dedication", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=10, Torah="Gen 41:1-44:17", ReadDate=DateTime.Parse("12/08/2018"), ParashaName="Mikketz", NameUrl="mikketz-genesis-41-1-to-44-17", Meaning="At the end of", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=11, Torah="Gen 44:18-47:27", ReadDate=DateTime.Parse("12/15/2018"), ParashaName="Vayigash", NameUrl="vayigash-genesis-44-18-to-47-27", Meaning="And He drew near", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=12, Torah="Gen 47:28-50:26", ReadDate=DateTime.Parse("12/22/2018"), ParashaName="Vay’chi", NameUrl="vay-chi-genesis-47-28-to-50-26", Meaning="And He lived", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=13, Torah="Exo 1:1-6:1", ReadDate=DateTime.Parse("12/29/2018"), ParashaName="Shemot", NameUrl="shemot-exodus-1-1-to-6-1", Meaning="Names", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=14, Torah="Exo 6:2-9:35", ReadDate=DateTime.Parse("01/05/2019"), ParashaName="Va’era", NameUrl="va-era-exodus-6-2-to-9-35", Meaning="And I appeared", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=15, Torah="Exo 10:1-13:16", ReadDate=DateTime.Parse("01/12/2019"), ParashaName="Bo", NameUrl="bo-exodus-10-1-to-13-16", Meaning="Enter / Go", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=16, Torah="Exo 13:17-17:16", ReadDate=DateTime.Parse("01/19/2019"), ParashaName="B’shalach", NameUrl="b-shalach-exodus-13-17-to-17-16", Meaning="When He let go", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=17, Torah="Exo 18:1-20:23", ReadDate=DateTime.Parse("01/26/2019"), ParashaName="Yithro", NameUrl="yithro-exodus-18-1-to-20-23", Meaning="Jethro", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=18, Torah="Exo 21:1-24:18", ReadDate=DateTime.Parse("02/02/2019"), ParashaName="Mishpatim", NameUrl="mishpatim-exodus-21-1-to-24-18", Meaning="Ordinances", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=19, Torah="Exo 25:1-27:19", ReadDate=DateTime.Parse("02/09/2019"), ParashaName="Terumah", NameUrl="terumah-exodus-25-1-to-27-19", Meaning="Offerings", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=20, Torah="Exo 27:20-30:10", ReadDate=DateTime.Parse("02/16/2019"), ParashaName="Tetsaveh", NameUrl="tetsaveh-exodus-27-20-to-30-10", Meaning="You shall command", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=21, Torah="Exo 30:11-34:35", ReadDate=DateTime.Parse("02/23/2019"), ParashaName="Ki Tisa", NameUrl="ki-tisa-exodus-30-11-to-34-35", Meaning="When you elevate", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=22, Torah="Exo 35:1-38:20", ReadDate=DateTime.Parse("03/02/2019"), ParashaName="Vayakhel", NameUrl="vayakhel-exodus-35-1-to-38-20", Meaning="And he assembled", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=23, Torah="Exo 38:21-40:38", ReadDate=DateTime.Parse("03/09/2019"), ParashaName="Pekude", NameUrl="pekude-exodus-38-21-to-40-38", Meaning="Accounts of", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=24, Torah="Lev 1:1-6:7", ReadDate=DateTime.Parse("03/16/2019"), ParashaName="Vayikra", NameUrl="vayikra-leviticus-1-1-to-5-19", Meaning="And He called", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=25, Torah="Lev 6:1-8:36", ReadDate=DateTime.Parse("03/23/2019"), ParashaName="Tzav", NameUrl="tzav-leviticus-6-1-to-8-36", Meaning="Command", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=26, Torah="Lev 9:1-11:47", ReadDate=DateTime.Parse("03/30/2019"), ParashaName="Shemeni", NameUrl="shemeni-leviticus-9-1-to-11-47", Meaning="Eighth", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=27, Torah="Lev 12:1-13:59", ReadDate=DateTime.Parse("04/06/2019"), ParashaName="Tazria", NameUrl="tazria-leviticus-12-1-to-13-59", Meaning="Leprosy", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=28, Torah="Lev 14:1-15:33", ReadDate=DateTime.Parse("04/13/2019"), ParashaName="Metzorah", NameUrl="metzorah -leviticus-14-1-to-15-33", Meaning="Cleansing the leper", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=59, Torah="Lev 23:4-8; Exo 12:1-51; Exo 33:12-34:26; Num 28:16-31", ReadDate=DateTime.Parse("04/19/2019"), ParashaName="Erev Pesach", NameUrl="erev-pesach-leviticus-23-4-to-8", Meaning="Passover Eve", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=60, Torah="Lev 23:4-8", ReadDate=DateTime.Parse("04/20/2019"), ParashaName="Yom Pesach", NameUrl="yom-pesach-leviticus-23-4-to-8", Meaning="Passover Day", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=29, Torah="Exo 33:12-34:26; Num 28:19-25", ReadDate=DateTime.Parse("04/27/2019"), ParashaName="Pesach", NameUrl="pesach -exodus-33-12-to-34-26", Meaning="Passover Sabbath", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=30, Torah="Lev 16:1-18:30", ReadDate=DateTime.Parse("05/04/2019"), ParashaName="Achare Mot", NameUrl="achare-mot-leviticus-16-1-to-18-30", Meaning="After the Death", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=31, Torah="Lev 19:1-20:27", ReadDate=DateTime.Parse("05/11/2019"), ParashaName="Kedoshim", NameUrl="kedoshim-leviticus-19-1-to-20-27", Meaning="Holy ones", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=32, Torah="Lev 21:1-24:23", ReadDate=DateTime.Parse("05/18/2019"), ParashaName="Emor", NameUrl="emor-leviticus-21-1-to-24-23", Meaning="Say", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=33, Torah="Lev 25:1-26:2", ReadDate=DateTime.Parse("05/25/2019"), ParashaName="Behar", NameUrl="behar-leviticus-25-1-to-26-2", Meaning="On the mount", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=34, Torah="Lev 26:3-27:34", ReadDate=DateTime.Parse("06/01/2019"), ParashaName="Bechukkotai", NameUrl="bechukkotai-leviticus-26-3-to-27-34", Meaning="In My statutes", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=35, Torah="Num 1:1-4:20", ReadDate=DateTime.Parse("06/08/2019"), ParashaName="Bemidbar", NameUrl="bemidbar-numbers-1-1-to-4-20", Meaning="In wilderness", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=36, Torah="Deu 14:22-16:17", ReadDate=DateTime.Parse("06/09/2019"), ParashaName="Shavuot", NameUrl="shavuot-deuteronomy-14-22-to-16-17", Meaning="Pentecost", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=37, Torah="Num 4:21-7:89", ReadDate=DateTime.Parse("06/15/2019"), ParashaName="Naso", NameUrl="naso-numbers-4-21-to-7-89", Meaning="Elevate", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=38, Torah="Num 8:1-12:16", ReadDate=DateTime.Parse("06/22/2019"), ParashaName="Behaalotcha", NameUrl="behaalotcha-numbers-8-1-to-12-16", Meaning="In your going up", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=39, Torah="Num 13:1-15:41", ReadDate=DateTime.Parse("06/29/2019"), ParashaName="Shelah L’cha", NameUrl="shelah-l-cha-numbers-13-1-to-15-41", Meaning="Send for yourself", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=40, Torah="Num 16:1-18:32", ReadDate=DateTime.Parse("07/06/2019"), ParashaName="Korach", NameUrl="korach-numbers-16-1-to-18-32", Meaning="Korah", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=41, Torah="Num 19:1-22:1", ReadDate=DateTime.Parse("07/13/2019"), ParashaName="Hukkat", NameUrl="hukkat-numbers-19-1-to-22-1", Meaning="Ordinance of", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=42, Torah="Num 22:2-25:9", ReadDate=DateTime.Parse("07/20/2019"), ParashaName="Balak", NameUrl="balak-numbers-22-2-to-25-9", Meaning="Balak", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=43, Torah="Num 25:10-30:1", ReadDate=DateTime.Parse("07/27/2019"), ParashaName="Pinchas", NameUrl="pinchas-numbers-25-10-to-30-1", Meaning="Phinehas", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=44, Torah="Num 30:2-32:42", ReadDate=DateTime.Parse("08/03/2019"), ParashaName="Mattot", NameUrl="mattot-numbers-30-2-to-32-42", Meaning="Tribes", DoubleHeader=1, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=45, Torah="Num 33:1-36:13", ReadDate=DateTime.Parse("08/03/2019"), ParashaName="Massey", NameUrl="massey-numbers-33-1-to-36-13", Meaning="Stages", DoubleHeader=2, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=46, Torah="Deu 1:1-3:22", ReadDate=DateTime.Parse("08/10/2019"), ParashaName="Devarim", NameUrl="devarim-deuteronomy-1-1-to-3-22", Meaning="Words", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=47, Torah="Deu 3:23-7:11", ReadDate=DateTime.Parse("08/17/2019"), ParashaName="Va’etchanan", NameUrl="va-etchanan-deuteronomy-3-23-to-7-11", Meaning="And I pleaded", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=48, Torah="Deu 7:12-11:25", ReadDate=DateTime.Parse("08/24/2019"), ParashaName="Ekev", NameUrl="ekev-deuteronomy-7-12-to-11-25", Meaning="On the heel of", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=49, Torah="Deu 11:26-16:17", ReadDate=DateTime.Parse("08/31/2019"), ParashaName="Re'eh", NameUrl="re-eh-deuteronomy-11-26-to-16-17", Meaning="See!", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=50, Torah="Deu 16:18-21:9", ReadDate=DateTime.Parse("09/07/2019"), ParashaName="Shoftim", NameUrl="shoftim-deuteronomy-16-18-to-21-9", Meaning="Judges", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=51, Torah="Deu 21:10-25:19", ReadDate=DateTime.Parse("09/14/2019"), ParashaName="Ki Tetse", NameUrl="ki-tetse-deuteronomy-21-10-to-25-19", Meaning="When you go out", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=52, Torah="Deu 26:1-29:8", ReadDate=DateTime.Parse("09/21/2019"), ParashaName="Ki Tavo", NameUrl="ki-tavo-deuteronomy-26-1-to-29-8", Meaning="When you enter in", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=53, Torah="Deu 29:9-30:20", ReadDate=DateTime.Parse("09/28/2019"), ParashaName="Nitsavim", NameUrl="nitsavim-deuteronomy-29-9-to-30-20", Meaning="You are standing", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=55, Torah="Gen 21:1-34", ReadDate=DateTime.Parse("09/30/2019"), ParashaName="Rosh Hashana", NameUrl="rosh-hashana-genesis-21-1-to-34", Meaning="Feast of Trumpets", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=54, Torah="Deu 31:1-30", ReadDate=DateTime.Parse("10/05/2019"), ParashaName="Vayelekh", NameUrl="vayelekh-deuteronomy-31-1-to-30", Meaning="And he went", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=62, Torah="Lev 16:1-34; Lev 18:1-30; Num 29:7-11", ReadDate=DateTime.Parse("10/09/2019"), ParashaName="Yom Kippur", NameUrl="yom-kippur-leviticus-16-1-to-34", Meaning="Day of Atonement", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=56, Torah="Deu 32:1-52", ReadDate=DateTime.Parse("10/12/2019"), ParashaName="Haazinu", NameUrl="haazinu-deuteronomy-31-1-to-32-52", Meaning="Give ear", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=57, Torah="Lev 22:26-23:44; Num 29:12-16", ReadDate=DateTime.Parse("10/14/2019"), ParashaName="Sukkot", NameUrl="sukkot-numbers-29-12-to-16", Meaning="Feast of Tabernacles", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=63, Torah="Exo 33:12-34:26; Num 29:17-25", ReadDate=DateTime.Parse("10/19/2019"), ParashaName="Sukkot Shabbat", NameUrl="sukkot-shabbat-exodus-33-12-to-34-26", Meaning="Tabernacles Sabbath", DoubleHeader=0, IsWeeklyParasha=true },
new ParashaAnnual2 {  Id=64, Torah="Num 29:26-34", ReadDate=DateTime.Parse("10/20/2019"), ParashaName="Hoshanah Rabbah", NameUrl="hoshanah-rabbah-numbers-29-26-to-34", Meaning="Great Supplication", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=58, Torah="Deu 14:22-16:17; Num 29:35-30:1", ReadDate=DateTime.Parse("10/21/2019"), ParashaName="Shemini-Atzeret", NameUrl="shemini-atzeret-numbers-29-35-to-30-1", Meaning="And this the Blessing", DoubleHeader=0, IsWeeklyParasha=false },
new ParashaAnnual2 {  Id=65, Torah="Deu 33:1-34:12; Num 29:35-30:1", ReadDate=DateTime.Parse("10/22/2019"), ParashaName="Simchat Torah", NameUrl="simchat-torah-deuteronomy-33-1-to-34-12", Meaning="Rejoicing of the Torah", DoubleHeader=0, IsWeeklyParasha=false }
			}.AsQueryable();
		}

  }
}
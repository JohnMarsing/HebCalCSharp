# HebCalCSharp
A c# .net core console app designed to pull content from the HebCall Rest API on an annual (and in the future triennial) basis.  

# Output
The product of this app is to generate **TSql Statements** like...
```SQL
UPDATE ParashaAnnual SET HebrewDate = '27 Tishrei' WHERE ReadDate = '2018-10-6' -- 5779 Parashat Bereshit
```

# My Hebrew Bible Association
For my website [My Hebrew Bible](https://myhebrewbible.com/) I have to update the list of weekly *parashot* (Torah portion reading list) on an annual basis [see the list](https://myhebrewbible.com/Parasha/Annual).  What date the portion is read gets changed every year (by whom exactly I don't know) and I need to pull from the **HebCal API** using **REST**.

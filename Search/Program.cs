/*
     let search = {
           text: 'kebab',
           dates: {
               includeFromAndTo: true,
               from: {
                   day: 10,
                   month: 5,
                   year: 2023
               },
               to: {
                   day: 10,
                   month: 5,
                   year: 2023
               }
           }
       }
 */

using Search;

var search = new SearchQuery();
search.Text = "kebab";
search.Dates = new Dates
{
    IncludeFromAndTo = true,
    From = DateTime.Parse("10.05.2025"),
    To = new DateTime(2025, 5, 10),
};

//var search2 = new SearchQuery("kebab",
//        new Dates
//        {
//            IncludeFromAndTo = true,
//            From = new DateTime(2025, 5, 10),
//            To = new DateTime(2025, 5, 10),
//        }
//    );

Console.WriteLine(search.Dates.From);






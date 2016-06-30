using Nancy;
using System.Collections.Generic;
using CDOrganizer.Objects;

namespace CDOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var allCDs = CD.GetAllCDs();
        return View["index.cshtml", allCDs];
      };
      Get["/cd/new"] = _ => {
        return View["add_cd_form.cshtml"];
      };
      Get["/artist_search"] = _ => {
        return View["artist_search_form.cshtml"];
      };
      Post["/"] = _ => {
        var newCD = new CD(Request.Form["cd-name"], Request.Form["artist-name"]);
        var allCDs = CD.GetAllCDs();
        return View["index.cshtml", allCDs];
      };
      Post["/artist_cds"] = _ =>{
        var allCDs = CD.GetAllCDs();
        if (Request.Form["artist-id"] == "" || allCDs.Count < 1) {
          return View["not_found.cshtml"];
        }
        var SearchedArtist = Request.Form["artist-id"];
        var returnedList = CD.SearchForArtist(SearchedArtist);
        return View["Artist_CDs.cshtml", returnedList];
      };
    }
  }
}

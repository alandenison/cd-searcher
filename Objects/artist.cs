using System.Collections.Generic;

namespace CDOrganizer.Objects
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    public string ArtistName { get; set; }
    public int Id { get;set; }
    private List<CD> _cds;

    public Artist(string name)
    {
      ArtistName = name;
      _instances.Add(this);
      Id = _instances.Count;
      _cds = new List<CD>{};

    }

    public List<CD> GetCDs()
    {
      return _cds;
    }
    public void AddCD(CD cd)
    {
      _cds.Add(cd);
    }
    public static List<Artist> GetAll()
    {
      return _instances;
    }
    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }
    // public static List<Artist> SearchArtist(string artistName)
    // {
    //   foreach(Artist artist in _instances)
    //   {
    //     if(artist.ArtistName == artistName)
    //     {
    //       return true;
    //     }
    //     else{
    //       return false;
    //     }
    //   }
    // }
  }
}

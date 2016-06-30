using System.Collections.Generic;

namespace CDOrganizer.Objects
{
  public class CD
  {
    public string CDName { get; set;}
    private static List<CD> _allCDs = new List<CD>{};
    public string CDArtist { get; set; }

    public CD(string name, string artist)
    {
      CDName = name;
      CDArtist = artist;
      _allCDs.Add(this);
    }

    public static List<CD> GetAllCDs()
    {
      return _allCDs;
    }
  }
}

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
    public static List<CD> SearchForArtist(string searchName)
    {
      List<CD> returnedList = new List<CD>{};
      char delimiter = ' ';
      foreach (CD cd in _allCDs)
      {
         if (cd.CDArtist.ToUpper() == searchName.ToUpper())
        {
          returnedList.Add(cd);
        }
         else
         {
           string[] searchValue = searchName.Split(delimiter);
           for(int i = 0; i < searchValue.Length; i++)
           {
             if(cd.CDArtist.ToUpper().Contains(searchValue[i].ToUpper()))
             {
               returnedList.Add(cd);
             }
           }
         }
    }
    return returnedList;
  }
}
}

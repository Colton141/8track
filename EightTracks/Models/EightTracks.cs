using System.Collections.Generic;

namespace EightTracks.Models
{
  public class EightTrackTape
  {
    public string AlbumName { get; set; }
    public string Artist { get; set; }
    public string Year { get; set; }
    public string Id { get; set; }
    private static List<EightTrackTape> _instances = new List<EightTrackTape> {};

    public EightTrackTape (string albumname, string artist, string year)
    {
      AlbumName = albumname;
      Artist = artist;
      Year = year;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public int GetId()
    {
      return _id;
    }

    public static EightTrackTape Find(int searchId)
    {
      for(int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].GetId() == searchId)
        {
          return _instances[i];
        }
      }
      return _instances[0];
    }

    public static List<EightTrackTape> GetAll()
    {
      return _instances;
    }

    public static void DeleteEightTrackTape(int id)
    {
      for(int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].GetId() == id)
        {
          _instances.RemoveAt(i);
        }
      }
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<EightTrackTape> FindAll(string year)
    {
      List<EightTrackTape> _tapes = new List<EightTrackTape>{};
      for(int i = 0; i < _instances.Count; i++)
      {
        if(year == _instances[i].Year)
        {
          _tapes.Add(_instances[i]);
        }
      }
      return _tapes;
    }

    public static List<EightTrackTape> FindAll(string artist)
    {
      List<EightTrackTape> _artists = new List<EightTrackTape>{};
      for(int i = 0; i < _instances.Count; i++)
      {
        if(artist == _instances[i].Artist)
        {
          _artists.Add(_instances[i]);
        }
      }
      return _artists;
    }

    public static List<EightTrackTape> FindAll(string albumname)
    {
      List<EightTrackTape> _albums = new List<EightTrackTape>{};
      for(int i = 0; i < _instances.Count; i++)
      {
        if(albumname == _instances[i].AlbumName)
        {
          _albums.Add(_instances[i]);
        }
      }
      return _albums;
    }
  }
}
#if GENERATEDCODE_ON
using System.Globalization;
using System.Reflection;

namespace SEMusicStoreBase.ConApp
{
    partial class Program
    {
        static partial void ImportData()
        {
            var executionPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dataPath = Path.Combine(executionPath!, "data");
            var genres = File.ReadAllLines(Path.Combine(dataPath, "genres.csv"))
                             .Skip(1)
                             .Select(l => l.Split(";"))
                             .Select(d => new
                             {
                                 id = d[0],
                                 entity = new Logic.Entities.Genre
                                 {
                                     Name = d[1]
                                 }
                             }).ToArray();

            var artists = File.ReadAllLines(Path.Combine(dataPath, "artists.csv"))
                              .Skip(1)
                              .Select(l => l.Split(";"))
                              .Select(d => new
                              {
                                  id = d[0],
                                  entity = new Logic.Entities.Artist
                                  {
                                      Name = d[1]
                                  }
                              }).ToArray();

            var context = CreateContext();

            context.GenreSet.AddRange(genres.Select(g => g.entity));
            context.ArtistSet.AddRange(artists.Select(a => a.entity));
            context.SaveChanges();

            var albums = File.ReadAllLines(Path.Combine(dataPath, "albums.csv"))
                             .Skip(1)
                             .Select(l => l.Split(";"))
                             .Select(d => new
                             {
                                 id = d[0],
                                 entity = new Logic.Entities.Album
                                 {
                                     Title = d[1],
                                     ArtistId = artists.First(a => a.id == d[2]).entity.Id,
                                 }
                             }).ToArray();

            context.AlbumSet.AddRange(albums.Select(a => a.entity));
            context.SaveChanges();

            var tracks = File.ReadAllLines(Path.Combine(dataPath, "tracks.csv"))
                             .Skip(1)
                             .Select(l => l.Split(";"))
                             .Select(d => new
                             {
                                 id = d[0],
                                 entity = new Logic.Entities.Track
                                 {
                                     Title = d[1],
                                     AlbumId = albums.First(a => a.id == d[2]).entity.Id,
                                     GenreId = genres.First(g => g.id == d[3]).entity.Id,
                                     Composer = d[4],
                                     Milliseconds = int.Parse(d[5]),
                                     Bytes = int.Parse(d[6]),
                                     UnitPrice = double.Parse(d[7], CultureInfo.CurrentCulture)
                                 }
                             }).ToArray();

            context.TrackSet.AddRange(tracks.Select(a => a.entity));
            context.SaveChanges();
        }
    }
}
#endif
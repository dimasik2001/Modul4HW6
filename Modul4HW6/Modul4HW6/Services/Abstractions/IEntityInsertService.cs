using Modul4HW6.Entities;

namespace Modul4HW6.Services.Absractions
{
    public interface IEntityInsertService
    {
        public Artist[] GetArtist();
        public ArtistSong[] GetArtistSong();
        public Genre[] GetGenres();
        public Song[] GetSongs();
    }
}
namespace SEMusicStoreBase.Logic.Entities
{
    [Table("Albums")]
    [Index(nameof(Title), IsUnique = true)]
    public partial class Album : VersionEntityObject
    {
        #region Properties
        public int ArtistId { get; set; }
        [Required]
        [MaxLength(1024)]
        public string Title { get; set; } = string.Empty;
        #endregion Properties

        #region Navigation properties
        public Artist? Artist { get; set; }
        public List<Track> Tracks { get; set; } = [];
        #endregion Navigation properties

        public override string ToString()
        {
            return $"Album: {Title, -10}";
        }
    }
}

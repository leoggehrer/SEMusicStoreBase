namespace SEMusicStoreBase.Logic.Entities
{
    [Table("Genres")]
    [Index(nameof(Name), IsUnique = true)]
    public partial class Genre : VersionEntityObject
    {
        #region Properties
        [MaxLength(256)]
        [Required]
        public string Name { get; set; } = string.Empty;
        #endregion Properties

        #region Navigation properties
        public List<Track> Tracks { get; set; } = [];
        #endregion Navigation properties

        public override string ToString()
        {
            return $"Genre: {Name, -10}";
        }
    }
}

namespace SEMusicStoreBase.Logic.Entities
{
    [Table("Artists")]
    [Index(nameof(Name), IsUnique = true)]
    public partial class Artist : VersionEntityObject
    {
        #region Properties
        [Required]
        [MaxLength(1024)]
        public string Name { get; set; } = string.Empty;
        #endregion Properties

        #region Navigation properties
        public List<Album> Albums { get; set; } = [];
        #endregion Navigation properties

        public override string ToString()
        {
            return $"Artist: {Name, -10}";
        }
    }
}

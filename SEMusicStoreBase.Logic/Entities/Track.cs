namespace SEMusicStoreBase.Logic.Entities
{
  [Table("Tracks")]
  public partial class Track : VersionEntityObject
  {
    #region Properties
    public int AlbumId { get; set; }
    public int GenreId { get; set; }
    [Required]
    [MaxLength(1024)]
    public string Title { get; set; } = string.Empty;
    [MaxLength(512)]
    public string Composer { get; set; } = string.Empty;
    public long Milliseconds { get; set; }
    public long Bytes { get; set; }
    public double UnitPrice { get; set; }
    #endregion Properties

    #region Navigation properties
    public Album? Album { get; set; }
    public Genre? Genre { get; set; }
    #endregion Navigation properties

    public override string ToString()
    {
      return $"Track: {Title,-10}";
    }
  }
}

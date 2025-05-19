# MusicStoreBase

**Inhaltsverzeichnis:**

- [MusicStoreBase](#musicstorebase)
  - [Einleitung](#einleitung)
  - [Aufgabenstellung](#aufgabenstellung)
  - [Umsetzung der Aufgabe mit dem SETemplate](#umsetzung-der-aufgabe-mit-dem-setemplate)
    - [Schritt 1: Repository klonen](#schritt-1-repository-klonen)
    - [Schritt 2: `SETemplate` mit der IDE öffnen](#schritt-2-setemplate-mit-der-ide-öffnen)
    - [Schritt 3: Starten der Anwendung `TemplateTools.ConApp`](#schritt-3-starten-der-anwendung-templatetoolsconapp)
    - [Schritt 4: `SETemplate` kopieren =\> `SEMusicStoreBase`](#schritt-4-setemplate-kopieren--semusicstorebase)
    - [Schritt 5: `SEMusicStoreBase` mit der IDE öffnen](#schritt-5-semusicstorebase-mit-der-ide-öffnen)
    - [Schritt 6: Starten der Anwendung `TemplateTools.ConApp`](#schritt-6-starten-der-anwendung-templatetoolsconapp)
    - [Schritt 7: `Preprocessor` einstellen](#schritt-7-preprocessor-einstellen)
    - [Schritt 8: Entity-`Genre` erstellen](#schritt-8-entity-genre-erstellen)
    - [Schritt 9: Entity-`Artist` erstellen](#schritt-9-entity-artist-erstellen)
    - [Schritt 10: Entity-`Album` erstellen](#schritt-10-entity-album-erstellen)
    - [Schritt 11: Entity-`Track` erstellen](#schritt-11-entity-track-erstellen)
    - [Schritt 12: Starten der `CodeGenerierung`](#schritt-12-starten-der-codegenerierung)
  - [Erweiterungen nach der CodeGenerierung](#erweiterungen-nach-der-codegenerierung)
    - [Datenimport](#datenimport)
      - [Testen des Imports](#testen-des-imports)

---

## Einleitung

Dieses Projekt ist der **erste** Teil aus einer mehrteiligen Reihe, die sich mit der Erstellung eines Software-Systems beschäftigt. Als Startvorlage für eine schnelle Entwicklung wird [SETemplate](https://github.com/leoggehrer/SETemplate) verwendet. Diese Vorlage orientiert sich an der Umsetzung der [SEArchitecture](https://github.com/leoggehrer/SEArchitecture) und bietet bereits eine Vielzahl von Komponenten.

Hauptthema dieser Reihe ist die Erstellung der **Datenbank** mit den entsprechenden **Entitäten** `Genre`, `Artist`, `Album` und `Track`. Zudem soll ein Datenimport aus csv-Daten implementiert werden.

## Aufgabenstellung

Eine detailierte Aufgabenstellung mit dem Titel **MusicStore** finden [hier](https://github.com/leoggehrer/MusicStore).

---

## Umsetzung der Aufgabe mit dem SETemplate

Mit dem `SETemplate` können Sie die Aufgabenstellung in wenigen Schritten umsetzen.

**Umsetzungstabelle:**

| Schritt | Beschreibung                                   |
|---------|------------------------------------------------|
| 1       | `SETemplate` klonen                            |
| 2       | `SETemplate` mit der IDE öffnen                |
| 3       | Starten der Anwendung `TemplateTools.ConApp`   |
| 4       | `SETemplate` kopieren => `SEMusicStoreBase`    |
| 5       | `SEMusicStoreBase` mit der IDE öffnen          |
| 6       | Starten der Anwendung `TemplateTools.ConApp`   |
| 7       | `Preprocessor` einstellen                      |
| 8       | Entity-`Genre` erstellen                       |
| 9       | Entity-`Artist` erstellen                      |
| 10      | Entity-`Album` erstellen                       |
| 11      | Entity-`Track` erstellen                       |
| 12      | Starten der `CodeGenerierung`                  |

### Schritt 1: Repository klonen

```bash
git clone https://github.com/leoggehrer/SETemplate.git
cd SETemplate
```

---

### Schritt 2: `SETemplate` mit der IDE öffnen

Öffnen Sie das `SETemplate` mit der IDE (Visual Studio 2022, Rider oder Visual Studio Code).

### Schritt 3: Starten der Anwendung `TemplateTools.ConApp`

Nach dem Start von `TemplateTools.ConApp` wird folgendes Menü angezeigt:

```bash
==============
Template Tools
==============

Solution path: ...\SETemplate

[ ----] -----------------------------------------------------------------
[    1] Path................Change solution path
[ ----] -----------------------------------------------------------------
[    2] Copier..............Copy this solution to a domain solution
[    3] Preprocessor........Setting defines for project options
[    4] CodeGenerator.......Generate code for this solution
[    5] Synchronization.....Matches a project with the template
[    6] Cleanup.............Deletes the temporary directories
[-----] -----------------------------------------------------------------
[  x|X] Exit................Exits the application

Choose [n|n,n|a...all|x|X]:
```

> **HINWEIS:** Eine ausführliche Bedienungsanleitung für das Programm **TemplateTools** finden Sie [hier](https://github.com/leoggehrer/SETemplate).

---

### Schritt 4: `SETemplate` kopieren => `SEMusicStoreBase`

Wählen Sie die **Menü-Option:** 2 - `Copier` aus. Anschließend wird das folgende Menü angezeigt:

```bash
===============
Template Copier
===============

'SETemplate' from:   ...\SETemplate
  -> copy ->
'TargetSolution' to: ...\TargetSolution

[  ---] -----------------------------------------------------------------
[    1] 1...................Change max sub path depth
[    2] Source path.........Change the source solution path
[    3] Target path.........Change the target solution path
[    4] Target name.........Change the target solution name
[  ---] -----------------------------------------------------------------
[    5] Start...............Start copy process
[-----] -----------------------------------------------------------------
[  x|X] Exit................Exits the application

Choose [n|n,n|a...all|x|X]:
```

Wählen Sie die **Menü-Option:** 3 - `Target path` aus und geben Sie den Zielpfad an, in dem das Projekt erstellt werden soll. Zum Beispiel: `C:\Users\...\source\repos`.

Wählen Sie die **Menü-Option:** 4 - `Target name` aus und geben Sie den Namen `SEMusicStoreBase` an. Das Ergebnis sollte wie folgt aussehen:

```bash
===============
Template Copier
===============

'SETemplate' from: ...\SETemplate
  -> copy ->
'SEMusicStoreBase' to:  C:\Users\...\source\repos\SEMusicStoreBase

[  ---] -----------------------------------------------------------------
[    1] 1...................Change max sub path depth
[    2] Source path.........Change the source solution path
[    3] Target path.........Change the target solution path
[    4] Target name.........Change the target solution name
[  ---] -----------------------------------------------------------------
[    5] Start...............Start copy process
[-----] -----------------------------------------------------------------
[  x|X] Exit................Exits the application

Choose [n|n,n|a...all|x|X]:
```

Wählen Sie die **Menü-Option:** 5 - `Start` aus. Das System kopiert nun die Projektmappe und ersetzt die entsprechenden Projektnamen mit `SEMusicStoreBase`. Wenn sie ein Windows-System verwenden, wird automatisch der Datei-Explorer mit dem Pfad 'C:\Users\...\source\repos\SEMusicStoreBase' geöffnet.

> **HINWEIS:** Sie können nun die **TemplateTools** von **SETemplate** beenden.

---

### Schritt 5: `SEMusicStoreBase` mit der IDE öffnen

Im nächsten Schritt öffnen Sie nun die Projektmappe `SEMusicStoreBase` mit der IDE (Visual Studio, VSCode oder Rider). Wenn alles erfolgreich war, sollte das Ergebnis wie folgt aussehen:

```bash
-|- SEMusicStoreBase
  |- Diagrams
  |- SEMusicStoreBase.AngularApp
   |- ...
   |- src
    |- app
   |- ...
  |- SEMusicStoreBase.CodeGenApp
   |- ...
  |- SEMusicStoreBase.Common
   |- Contracts
   |- Enums
   |- Extensions
   |- Models
   |- Modules
   |- ...
  |- SEMusicStoreBase.ConApp
   |- ...
  |- SEMusicStoreBase.Logic
   |- Contracts
   |- Enums
   |- DataContext
   |- Entities
   |- Exceptions
   |- Models
   |- Modules
   |- ...
  |- SEMusicStoreBase.MVVMApp
   |- Models
   |- ViewModels
   |- Views
   |- ...
  |- SEMusicStoreBase.WebApi
   |- Contracts
   |- Controllers
   |- Models
   |- ...
  |- TemplateTools.ConApp
   |- ...
  |- TemplateTools.Logic
   |- ...
  |- README.md
  |- SETemplate.sln
```

---

### Schritt 6: Starten der Anwendung `TemplateTools.ConApp`

Nach dem Start von `TemplateTools.ConApp` wird folgendes Menü angezeigt:

```bash
==============
Template Tools
==============

Solution path: C:\Users\...\repos\SEMusicStoreBase

[ ----] -----------------------------------------------------------------
[    1] Path................Change solution path
[ ----] -----------------------------------------------------------------
[    2] Copier..............Copy this solution to a domain solution
[    3] Preprocessor........Setting defines for project options
[    4] CodeGenerator.......Generate code for this solution
[    5] Synchronization.....Matches a project with the template
[    6] Cleanup.............Deletes the temporary directories
[-----] -----------------------------------------------------------------
[  x|X] Exit................Exits the application

Choose [n|n,n|a...all|x|X]:
```

---

### Schritt 7: `Preprocessor` einstellen

Wählen Sie die **Menü-Option:** 3 - `Preprocessor` aus. Anschließend wird das folgende Menü angezeigt:

```bash
========================
Template Setting Defines
========================

Solution path: C:\Users\...\source\repos\SEMusicStoreBase

[  ---] -----------------------------------------------------------------
[    1] Path................Change preprocessor solution path
[  ---] -----------------------------------------------------------------
[    2] Set definition ACCOUNT_OFF               ==> ACCOUNT_ON
[  ---] -----------------------------------------------------------------
[    3] Set definition IDINT_ON                  ==> IDINT_OFF
[    4] Set definition IDLONG_OFF                ==> IDLONG_ON
[    5] Set definition IDGUID_OFF                ==> IDGUID_ON
[  ---] -----------------------------------------------------------------
[    6] Set definition ROWVERSION_OFF            ==> ROWVERSION_ON
[    7] Set definition EXTERNALGUID_OFF          ==> EXTERNALGUID_ON
[  ---] -----------------------------------------------------------------
[    8] Set definition POSTGRES_OFF              ==> POSTGRES_ON
[    9] Set definition SQLSERVER_OFF             ==> SQLSERVER_ON
[   10] Set definition SQLITE_ON                 ==> SQLITE_OFF
[  ---] -----------------------------------------------------------------
[   11] Set definition DOCKER_OFF                ==> DOCKER_ON
[   12] Set definition DEVELOP_ON                ==> DEVELOP_OFF
[   13] Set definition DBOPERATION_ON            ==> DBOPERATION_OFF
[   14] Set definition GENERATEDCODE_ON          ==> GENERATEDCODE_OFF
[  ---] -----------------------------------------------------------------
[   15] Start...............Start assignment process
[-----] -----------------------------------------------------------------
[  x|X] Exit................Exits the application

Choose [n|n,n|a...all|x|X]:
```

Mit diesem Menü können die Projektparameter eingestellt werden.

> **HINWEIS**: Wenn die Einstellung `SQLITE_ON` gesetzt ist, dann sind folgende Einstellungen in Abhängigkeit des OS in den `AppSettings` zu berücksichtigen:

**OS-Windows:** appsettings.Development.json in der Projektmappe `SEMusicStoreBase.ConApp`:

```json
{
  ...
  "ConnectionStrings": {
    "SqliteConnectionString": "Data Source=..\\..\\..\\..\\SEMusicStoreBaseDb.db",
    ...
  }
}
```

**OS-Windows:** appsettings.Development.json in der Projektmappe `SEMusicStoreBase.WebApi`:

```json
{
  ...
  "ConnectionStrings": {
    "SqliteConnectionString": "Data Source=..\\SEMusicStoreBaseDb.db",
    ...
  }
}
```

**OS-Mac:** appsettings.Development.json in der Projektmappe `SEMusicStoreBase.ConApp`:

```json
{
  ...
  "ConnectionStrings": {
    "SqliteConnectionString": "Data Source=SEMusicStoreBaseDb.db",
    ...
  }
}
```

**OS-Mac:** appsettings.Development.json in der Projektmappe `SEMusicStoreBase.WebApi`:

```json
{
  ...
  "ConnectionStrings": {
    "SqliteConnectionString": "Data Source=SEMusicStoreBaseDb.db",
    ...
  }
}
```

---

### Schritt 8: Entity-`Genre` erstellen

```bash
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
```

---

### Schritt 9: Entity-`Artist` erstellen

```bash
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
```

---

### Schritt 10: Entity-`Album` erstellen

```bash
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
```

---

### Schritt 11: Entity-`Track` erstellen

```bash
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
```

---

**Erstellungsrichtlinien für Entitäten:**

- Erstellen alle Entitäten als `public partial class Entity`-Klasse.
- Leiten alle Entitäten von `EntityObject` oder `VersionEntityObject` ab.
- Geben Sie für alle Entitäten den Tabellenname als Klassen-Attribut `[Table("...")]` über der Klasse an.
- Erstellen Sie alle Eigenschaften mit eventuellen Einschränkungen - z.B.: `[MaxLength(10)]`, falls erforderlich.
- Geben Sie für alle Entitäten die Index-Einschränkungen als Klassen-Attribute `[Index(..., IsUnique = true)]` über der Klasse an.

**Prüfung der Entitäten:**

| Entität/Klasse | Prüfung | Ergebnis | Beschreibung |
|----------------|---------|----------|--------------|
| **Genre**      | Ist die Klasse als `public partial class Genre` deklariert? | Ja | Wenn nein, tritt ein Fehler beim Verbinden von der Schnittstelle `IGenre` mit der `Genre`-Klasse auf. |
| **Genre**      | Ist die Klasse von `EntityObject` oder `VersionEntityObject` abgeleitet? | Ja |  Wenn nein, wird `Genre` nicht als Entität erkannt. |
| **Genre**      | Ist die Klasse mit dem Attribut `[Table("...")]` versehen? | Ja | Wenn nein, wird ein Standardnamen (`GenreSet`) vergeben. |
| **Genre**      | Sind die Eigenschaften mit Einschränkungen mit den entsprechenden Attributen `[MaxLength(...)]` versehen? | Ja | Wenn nein, werden die Standardwerte verwendet. |
| **Genre**      | Sind die `NOT NULL`-Eigenschaften mit den Attributen [Required] versehen? | Ja | Wenn nein, werden die Standardwerte verwendet (Abhängig von der dotnet- Version). |
| **Genre**      | Ist die Klasse mit den Attributen `[Index(..., IsUnique = true)]` versehen? |Ja  | Wenn nein, wird kein Index erstellt. |
| | | | |
| **Artist**     | Alle Prüfungen wie bei `Genre` durchführen. | Ja | Wenn nein, kann ein unerwünschte Verhalten auftreten. |
| | | | |
| **Album**      | Alle Prüfungen wie bei `Genre` durchführen. | Ja | Wenn nein, kann ein unerwünschte Verhalten auftreten. |
| | | | |
| **Track**      | Alle Prüfungen wie bei `Genre` durchführen. | Ja | Wenn nein, kann ein unerwünschte Verhalten auftreten. |

---

### Schritt 12: Starten der `CodeGenerierung`

Bevor mit der Code-Generierung begonnen werden kann, müssen die folgenden Schritte durchgeführt werden:

- Die Entität-`Genre` ist erstellt und alle Prüfschritte haben das Ergebniss 'Ja'.
- Die Entität-`Artist` ist erstellt und alle Prüfschritte haben das Ergebniss 'Ja'.
- Die Entität-`Album` ist erstellt und alle Prüfschritte haben das Ergebniss 'Ja'.
- Die Entität-`Track` ist erstellt und alle Prüfschritte haben das Ergebniss 'Ja'.
- Die Projektmappe `SEMusicStoreBase` kann fehlerfrei erstellt werden.

Starten das Programm `TemplateTools.ConApp` und wählen Sie die **Menü-Option:** 4 - `CodeGenerator` aus. Anschließend wird das folgende Menü angezeigt:

```bash
=======================
Template Code Generator
=======================

Solution path:                    C:\Users\...\repos\SEMusicStoreBase
---------------------------------
Write generated source into:      Single files
Write info header into source:    True
Delete empty folders in the path: True
Exclude generated files from GIT: True

[-----] -----------------------------------------------------------------
[    1] Generation file.....Change generation file option
[    2] Add info header.....Change add info header option
[    3] Delete folders......Change delete empty folders option
[    4] Exclude files.......Change the exclusion of generated files from GIT
[    5] Source path.........Change the source solution path
[-----] -----------------------------------------------------------------
[    6] Compile.............Compile logic project
[    7] Delete files........Delete generated files
[    8] Delete folders......Delete empty folders in the path
[    9] Start...............Start code generation
[-----] -----------------------------------------------------------------
[  x|X] Exit................Exits the application

Choose [n|n,n|a...all|x|X]:
```

Bevor Sie mit der `CodeGenerierung` beginnen, können einige Einstellungen vorgenommen werden. Sie finden die Beschreibung in der Dokumentation für [Menü: CodeGenerator](https://github.com/leoggehrer/SETemplate?tab=readme-ov-file#men%C3%BC-codegenerator).

Nachdem die Einstellung vorgenommen wurde, wählen Sie die **Menü-option:** 9 - `Start` aus. Die `CodeGenerierung` startet und hat folgende Code-Teile generiert:

| Module      | Ordner        | Komponente         | Dateiname                     | Beschreibung                                   |
|-------------|---------------|--------------------|-------------------------------|------------------------------------------------|
| **Common**  | Contracts     | `IGenre`           | IGenre.cs                     | Die Schnittstelle für das Entity-`Genre` mit `CopyProperties(...)`. |
| **Common**  | Contracts     | `IArtist`          | IArtist.cs                    | Die Schnittstelle für das Entity-`Artist` mit `CopyProperties(...)`. |
| **Common**  | Contracts     | `IAlbum`           | IAlbum.cs                     | Die Schnittstelle für das Entity-`Album` mit `CopyProperties(...)`. |
| **Common**  | Contracts     | `ITrack`           | ITrack.cs                     | Die Schnittstelle für das Entity-`Track` mit `CopyProperties(...)`. |
| **Logic**   | Entities      | `Genre`            | GenreGeneration.cs            | Die Schnittstelle wird mit dem Entity-`Genre` verbunden. |
| **Logic**   | DataContext   | `GenreSet`         | BookSet.cs                    | Die `Set`-Management Klasse für den Zugriff. |
| **Logic**   | Contracts     | `IGenreSet`        | IGenreSet.cs                  | Die Schnittstelle für die `GenreSet`-Klasse. |
| **Logic**   | Entities      | `Artist`           | ArtistGeneration.cs           | Die Schnittstelle wird mit dem Entity-`Artist` verbunden. |
| **Logic**   | DataContext   | `ArtistSet`        | ArtistSet.cs                  | Die `Set`-Management Klasse für den Zugriff. |
| **Logic**   | Contracts     | `IArtistSet`       | IArtistSet.cs                 | Die Schnittstelle für die `ArtistSet`-Klasse. |
| **Logic**   | Entities      | `Album`            | AlbumGeneration.cs            | Die Schnittstelle wird mit dem Entity-`Album` verbunden. |
| **Logic**   | DataContext   | `AlbumSet`         | AlbumSet.cs                   | Die `Set`-Management Klasse für den Zugriff. |
| **Logic**   | Contracts     | `IAlbumSet`        | IAlbumSet.cs                  | Die Schnittstelle für die `AlbumSet`-Klasse. |
| **Logic**   | Entities      | `Track`            | TrackGeneration.cs            | Die Schnittstelle wird mit dem Entity-`Track` verbunden. |
| **Logic**   | DataContext   | `TrackSet`         | TrackSet.cs                   | Die `Set`-Management Klasse für den Zugriff. |
| **Logic**   | Contracts     | `ITrackSet`        | ITrackSet.cs                  | Die Schnittstelle für die `TrackSet`-Klasse. |
| **Logic**   | DataContext   | `ProjectDbContext` | ProjectDbContextGeneration.cs | Enthält die Felder und Eigenschaften `DbGenreSet`, `GenreSet`, `DbArtistSet`, `ArtistSet`, `DbAlbumSet`, `AlbumSet`, `DbTrackSet`, `TrackSet` und die entsprechenden Methoden. |
| **Logic**   | Contracts     | `IContext`         | IContextGeneration.cs         | Die Schnittstelle für den öffentlichen Zugriff auf das `GenreSet`, `ArtisSet`, `AlbumSet`, `TrackSet`. |
| **WebApi**  | Models        | `Genre`            | Genre.cs                      | Das Model-`Genre` für die `WebApi`-Übertragung. |
| **WebApi**  | Models        | `GenreEdit`        | GenreEdit.cs                  | Das Model-`GenreEdit`für die `WebApi`-Übertragung. |
| **WebApi**  | Models        | `Genre`            | GenreInheritance.cs           | Eine `partial`-Klasse in welche die Ableitung des Models definiert ist. |
| **WebApi**  | Models        | `Artist`           | Artist.cs                     | Das Model-`Artist` für die `WebApi`-Übertragung. |
| **WebApi**  | Models        | `ArtistEdit`       | ArtistEdit.cs                 | Das Model-`ArtistEdit`für die `WebApi`-Übertragung. |
| **WebApi**  | Models        | `Artist`           | ArtistInheritance.cs          | Eine `partial`-Klasse in welche die Ableitung des Models definiert ist. |
| **WebApi**  | Models        | `Album`            | Album.cs                      | Das Model-`Album` für die `WebApi`-Übertragung. |
| **WebApi**  | Models        | `AlbumEdit`        | AlbumEdit.cs                  | Das Model-`AlbumEdit`für die `WebApi`-Übertragung. |
| **WebApi**  | Models        | `Album`            | AlbumInheritance.cs           | Eine `partial`-Klasse in welche die Ableitung des Models definiert ist. |
| **WebApi**  | Models        | `Track`            | Track.cs                      | Das Model-`Track` für die `WebApi`-Übertragung. |
| **WebApi**  | Models        | `TrackEdit`        | TrackEdit.cs                  | Das Model-`TrackEdit`für die `WebApi`-Übertragung. |
| **WebApi**  | Models        | `Track`            | TrackInheritance.cs           | Eine `partial`-Klasse in welche die Ableitung des Models definiert ist. |
| **WebApi**  | Controllers   | `GenresController` | GenresController.cs           | Die standard Implementierung der `CRUD`-Operationen für das Entity `Genre` |
| **WebApi**  | Controllers   | `ArtistsController`| ArtistsController.cs          | Die standard Implementierung der `CRUD`-Operationen für das Entity `Artist` |
| **WebApi**  | Controllers   | `AlbumsController` | AlbumsController.cs           | Die standard Implementierung der `CRUD`-Operationen für das Entity `Album` |
| **WebApi**  | Controllers   | `TracksController` | TracksController.cs           | Die standard Implementierung der `CRUD`-Operationen für das Entity `Track` |
| **WebApi**  | Controllers   | `ContextAccessor`  | ContextAccessorGeneration.cs  | Die Methode für den Zugriff auf die Eigenschaften  `GenreSet`, `ArtistSet`, `AlbumSet`, `TrackSet` in der Logik. |
| **MVVMApp** | Models        | `Genre`            | Genre.cs                      | Das Model-`Genre` für die `WebApi`-Übertragung. |
| **MVVMApp** | Models        | `Genre`            | GenreInheritance.cs           | Eine `partial`-Klasse in welche die Ableitung des Models definiert ist. |
| **MVVMApp** | ViewModels    | `GenresViewModel`   | GenresViewModel.cs           | Ein `ViewModel` für die `Genre`-Tabellen-Ansicht. |
| **MVVMApp** | ViewModels    | `GenreViewModel`    | GenreViewModel.cs            | Ein `ViewModel` für die `Genre`-Einzel-Ansicht. |
| **MVVMApp** | Models        | `Artist`            | Artist.cs                    | Das Model-`Artist` für die `WebApi`-Übertragung. |
| **MVVMApp** | Models        | `Artist`            | ArtistInheritance.cs         | Eine `partial`-Klasse in welche die Ableitung des Models definiert ist. |
| **MVVMApp** | ViewModels    | `ArtistsViewModel`  | ArtistsViewModel.cs          | Ein `ViewModel` für die `Artist`-Tabellen-Ansicht. |
| **MVVMApp** | ViewModels    | `ArtistViewModel`   | ArtistViewModel.cs           | Ein `ViewModel` für die `Artist`-Einzel-Ansicht. |
| **MVVMApp** | Models        | `Album`             | Album.cs                     | Das Model-`Album` für die `WebApi`-Übertragung. |
| **MVVMApp** | Models        | `Album`             | AlbumInheritance.cs          | Eine `partial`-Klasse in welche die Ableitung des Models definiert ist. |
| **MVVMApp** | ViewModels    | `AlbumsViewModel`   | AlbumsViewModel.cs           | Ein `ViewModel` für die `Album`-Tabellen-Ansicht. |
| **MVVMApp** | ViewModels    | `AlbumViewModel`    | AlbumViewModel.cs            | Ein `ViewModel` für die `Album`-Einzel-Ansicht. |
| **MVVMApp** | Models        | `Track`             | Track.cs                     | Das Model-`Track` für die `WebApi`-Übertragung. |
| **MVVMApp** | Models        | `Track`             | TrackInheritance.cs          | Eine `partial`-Klasse in welche die Ableitung des Models definiert ist. |
| **MVVMApp** | ViewModels    | `TracksViewModel`   | TracksViewModel.cs           | Ein `ViewModel` für die `Track`-Tabellen-Ansicht. |
| **MVVMApp** | ViewModels    | `TrackViewModel`    | TrackViewModel.cs            | Ein `ViewModel` für die `Track`-Einzel-Ansicht. |
| **AngularApp** | app/models/entities | `IGenre`        | i-genre.ts              | Die Schnittstelle-`IGenre` für die `WebApi`-Übertragung. |
| **AngularApp** | app/services/http   | `GenreService`  | genre-service.ts        | Der Service für den `Genre-WebApi`-Zugriff. |
| **AngularApp** | app/models/entities | `IArtist`       | i-artist.ts             | Die Schnittstelle-`IArtist` für die `WebApi`-Übertragung. |
| **AngularApp** | app/services/http   | `ArtistService` | artist-service.ts       | Der Service für den `Artist-WebApi`-Zugriff. |
| **AngularApp** | app/models/entities | `IAlbum`        | i-artist.ts             | Die Schnittstelle-`IAlbum` für die `WebApi`-Übertragung. |
| **AngularApp** | app/services/http   | `AlbumService`  | album-service.ts        | Der Service für den `Album-WebApi`-Zugriff. |
| **AngularApp** | app/models/entities | `Itrack`        | i-track.ts              | Die Schnittstelle-`ITrack` für die `WebApi`-Übertragung. |
| **AngularApp** | app/services/http   | `TrackService`  | track-service.ts        | Der Service für den `Track-WebApi`-Zugriff. |

> **HINWEIS:** Die **Dateinamen** gelten nur für den Mode *Write generated source into: Single files*.

## Erweiterungen nach der CodeGenerierung

**Erweiterungsrichtlinien:**

- Wenn eine Klasse erweitert werden soll, dann erfolgt dies in einer `partial class Name`.
- Zusätzlich muss die Code-Generierung geprüft werden und mit der Konstanten `GENERATEDCODE_ON` eingeschaltet werden.
- Der folgende Programmausschnitt zeigt eine mögliche Erweiterung:

```csharp
#if GENERATEDCODE_ON
namespace SEMusicStoreBase.MVVMApp.Models
{
    partial class Book
    {
        public override string ToString()
        {
            return $"{Author} {Title}";
        }
    }
}
#endif
```

### Datenimport

Für den Datenimport erweitern wir im Modul `SEMusicStoreBase.ConApp` die Klasse `Program`. Zu diesem Zweck wird eine partiele Klasse mit dem Dateinamen **ProgramImport.cs** erstellt. In dieser Klasse erfolgt das Einlesen der csv-Daten und die Übertragung in das System:

```csharp
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
```

Das Programm `SEMusicStoreBase.ConApp` kann nun gestartet werden. Anschließend führen Sie die Auswahl: **InitDatabase...1** durch - die Erstellung der Datenbank und der Import startet. In der Konsole werden eventuelle Fehler des Imports ausgegeben:

```bash
SEMusicStoreBase
==========================================
InitDatabase             ....1

Exit...............x
```

#### Testen des Imports

Sie können den Import Testen. Starten Sie dazu die `WebApi`-Anwendung `SEMusicStoreBase.WebApi` und rufen Sie die URL `https://localhost:7074/api/Genres` auf. Es sollte eine Liste mit den Genres angezeigt werden.

```json
[{"name":"Rock","id":1},{"name":"Jazz","id":2},{"name":"Metal","id":3},{"name":"Alternative & Punk","id":4},{"name":"Rock And Roll","id":5},{"name":"Blues","id":6},{"name":"Latin","id":7},{"name":"Reggae","id":8},{"name":"Pop","id":9},{"name":"Soundtrack","id":10},{"name":"Bossa Nova","id":11},{"name":"Easy Listening","id":12},{"name":"Heavy Metal","id":13},{"name":"R&B/Soul","id":14},{"name":"Electronica/Dance","id":15},{"name":"World","id":16},{"name":"Hip Hop/Rap","id":17},{"name":"Science Fiction","id":18},{"name":"TV Shows","id":19},{"name":"Sci Fi & Fantasy","id":20},{"name":"Drama","id":21},{"name":"Comedy","id":22},{"name":"Alternative","id":23},{"name":"Classical","id":24},{"name":"Opera","id":25}]
```

**Viel Erfolg beim Umsetzen!**

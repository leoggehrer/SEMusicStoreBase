-- SQL-Server: GenreTitleStatistics
SELECT Id AS GenreId, Name,
(SELECT COUNT(*) AS Count
FROM dbo.Tracks AS t
WHERE (GenreId = g.Id)) AS TitleCount
FROM dbo.Genres AS g

-- SQL Server: View mit JOIN und GROUP BY (skalierbarer)
CREATE VIEW dbo.GenreTitleStatistics
AS
SELECT g.Id AS GenreId,
g.Name,
COUNT(t.Id) AS TitleCount
FROM dbo.Genres AS g
LEFT JOIN dbo.Tracks AS t ON t.GenreId = g.Id
GROUP BY g.Id, g.Name;
GO

-- SQL Server: View ArtistAlbums
CREATE VIEW dbo.ArtistAlbums
AS
SELECT dbo.Artists.Id AS ArtistId, 
dbo.Artists.Name, 
dbo.Albums.Id AS AlbumId, 
dbo.Albums.Title
FROM dbo.Artists 
LEFT OUTER JOIN dbo.Albums ON dbo.Artists.Id = dbo.Albums.ArtistId;
GO

-- SQL Server: View ArtistTracks
CREATE VIEW dbo.ArtistTracks
AS
SELECT dbo.Artists.Id AS ArtistId, 
dbo.Artists.Name, 
dbo.Albums.Id AS AlbumId, 
dbo.Albums.Title AS AlbumTitle, 
dbo.Tracks.Id AS TrackId, 
dbo.Tracks.Title AS TrackTitle, 
dbo.Tracks.GenreId, 
dbo.Genres.Name AS GenreName
FROM dbo.Genres INNER JOIN
dbo.Tracks ON dbo.Genres.Id = dbo.Tracks.GenreId RIGHT OUTER JOIN
dbo.Albums ON dbo.Tracks.AlbumId = dbo.Albums.Id RIGHT OUTER JOIN
dbo.Artists ON dbo.Albums.ArtistId = dbo.Artists.Id
GO


-- SQLITE: GenreTitleStatistics (skalierbare Variante)
CREATE VIEW IF NOT EXISTS GenreTitleStatistics AS
SELECT 
g.Id AS GenreId,
g.Name AS Name,
COUNT(t.Id) AS TitleCount
FROM Genres AS g
LEFT JOIN Tracks AS t 
ON t.GenreId = g.Id
GROUP BY 
g.Id, 
g.Name;

-- SQLITE: ArtistAlbums
CREATE VIEW IF NOT EXISTS ArtistAlbums AS
SELECT 
a.Id AS ArtistId,
a.Name AS Name,
al.Id AS AlbumId,
al.Title
FROM Artists AS a
LEFT JOIN Albums AS al
ON al.ArtistId = a.Id;

-- SQLITE ArtistTracks
CREATE VIEW IF NOT EXISTS ArtistTracks AS
SELECT
art.Id AS ArtistId,
art.Name AS Name,
al.Id AS AlbumId,
al.Title AS AlbumTitle,
tr.Id AS TrackId,
tr.Title AS TrackTitle,
tr.GenreId AS GenreId,
g.Name AS GenreName
FROM Artists AS art
LEFT JOIN Albums AS al
ON al.ArtistId = art.Id
LEFT JOIN Tracks AS tr
ON tr.AlbumId = al.Id
LEFT JOIN Genres AS g
ON g.Id = tr.GenreId;

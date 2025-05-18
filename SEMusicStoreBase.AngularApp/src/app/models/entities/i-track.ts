//@GeneratedCode
import { IVersionModel } from '@app-models/i-version-model';
import { IAlbum } from '@app-models/entities/i-album';
import { IGenre } from '@app-models/entities/i-genre';
//@CustomImportBegin
//@CustomImportEnd
export interface ITrack extends IVersionModel {
  albumId: number;
  genreId: number;
  title: string;
  composer: string;
  milliseconds: number;
  bytes: number;
  unitPrice: number;
  album: IAlbum;
  genre: IGenre;
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}

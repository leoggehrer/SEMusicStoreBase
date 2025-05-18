//@GeneratedCode
import { IVersionModel } from '@app-models/i-version-model';
import { ITrack } from '@app-models/entities/i-track';
import { IArtist } from '@app-models/entities/i-artist';
//@CustomImportBegin
//@CustomImportEnd
export interface IAlbum extends IVersionModel {
  artistId: number;
  title: string;
  artist: IArtist;
  tracks: ITrack[];
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}

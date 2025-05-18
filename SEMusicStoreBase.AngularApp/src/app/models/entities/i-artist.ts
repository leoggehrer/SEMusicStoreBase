//@GeneratedCode
import { IVersionModel } from '@app-models/i-version-model';
import { IAlbum } from '@app-models/entities/i-album';
//@CustomImportBegin
//@CustomImportEnd
export interface IArtist extends IVersionModel {
  name: string;
  albums: IAlbum[];
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}

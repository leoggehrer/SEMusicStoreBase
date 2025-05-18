//@GeneratedCode
import { IVersionModel } from '@app-models/i-version-model';
import { ITrack } from '@app-models/entities/i-track';
//@CustomImportBegin
//@CustomImportEnd
export interface IGenre extends IVersionModel {
  name: string;
  tracks: ITrack[];
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}

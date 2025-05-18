//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { IAlbum } from '@app-models/entities/i-album';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class AlbumService extends ApiEntityBaseService<IAlbum> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/albums');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}

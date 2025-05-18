//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { IArtist } from '@app-models/entities/i-artist';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class ArtistService extends ApiEntityBaseService<IArtist> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/artists');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}

//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { ITrack } from '@app-models/entities/i-track';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class TrackService extends ApiEntityBaseService<ITrack> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/tracks');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}

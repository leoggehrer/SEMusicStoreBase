//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { IGenre } from '@app-models/entities/i-genre';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class GenreService extends ApiEntityBaseService<IGenre> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/genres');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}

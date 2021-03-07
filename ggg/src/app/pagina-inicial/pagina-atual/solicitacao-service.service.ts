import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { httpOptions } from 'src/environments/httpOptions';
import { ModeloConferencia } from './model/modelo-conferencia';
@Injectable({
  providedIn: 'root'
})
export class SolicitacaoServiceService {

  constructor(
    private http: HttpClient
  ) { }

  postSolicitacao(conferenciaModel: ModeloConferencia): Observable<ModeloConferencia>
  {
    return this.http.post<ModeloConferencia>(`${environment.API_URL}Solicitacao`, conferenciaModel, httpOptions);
  }
}

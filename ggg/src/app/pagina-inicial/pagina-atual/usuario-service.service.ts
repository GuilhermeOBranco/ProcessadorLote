import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ModeloUsuario } from './modelo-usuario';
import { httpOptions } from 'src/environments/httpOptions';


@Injectable({
  providedIn: 'root'
})
export class UsuarioServiceService  {

  constructor(
    private http: HttpClient
  ) {}

  postUsuarios(usuarioModel: ModeloUsuario): Observable<ModeloUsuario>
  {
    return this.http.post<ModeloUsuario>(`${environment.API_URL}Usuario`, usuarioModel, httpOptions);
  }

  
}

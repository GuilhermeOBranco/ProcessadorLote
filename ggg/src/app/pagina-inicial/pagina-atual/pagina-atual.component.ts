import { Component, OnInit } from '@angular/core';
import { ModeloConferencia } from './model/modelo-conferencia';
import { ModeloUsuario } from './modelo-usuario';
import { SolicitacaoServiceService } from './solicitacao-service.service';
import { UsuarioServiceService } from './usuario-service.service';

@Component({
  selector: 'app-pagina-atual',
  templateUrl: './pagina-atual.component.html',
  styleUrls: ['./pagina-atual.component.scss']
})
export class PaginaAtualComponent implements OnInit {

  constructor(
    private usuarioService: UsuarioServiceService,
    private soliciatcaoService: SolicitacaoServiceService) { }

  ngOnInit(): void {
  }

  lote: string;

  processarLote() {

    let usuarios = Array<ModeloUsuario>();
    let solicitacoes = Array<ModeloConferencia>();

    let line = this.lote.split('\n');

    //PREENCHE A FILA DE SOLICITAÇÕES E USUARIOS
    for (let i = 0; i < line.length; i++) {

      let funcionalPonto = line[i].split('|');

      let modelUsuario = <ModeloUsuario>
        {
          funcional: funcionalPonto[0],
          racf: `CONFERENTE ${funcionalPonto[0]}`,
          area: 10,
          tipoLogin: 15
        }

      let modelSolicitacao = <ModeloConferencia>
        {
          funcionalConferente: funcionalPonto[0],
          numeroPonto: funcionalPonto[1]
        }

      //PREENCHE O ARRAY DE USUARIOS E SOLICITAÇÕES
      usuarios.push(modelUsuario);
      solicitacoes.push(modelSolicitacao);

    }

    for (let i = 0; i < usuarios.length; i++) {
      this.usuarioService.postUsuarios(usuarios[i]).subscribe((result) => 
      {
        console.log('sucesso', result);
      })
    }

    for (let i = 0; i < solicitacoes.length; i++) {
      this.soliciatcaoService.postSolicitacao(solicitacoes[i]).subscribe((result) => 
      {
        console.log('sucesso', result);
      })
    }
    
    console.log(solicitacoes);
    console.log(usuarios);
  }

}

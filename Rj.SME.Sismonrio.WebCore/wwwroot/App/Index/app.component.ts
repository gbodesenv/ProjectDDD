import { Component  } from '@angular/core';
import { AppService } from './app.component.service';

@Component({
    selector : 'meu-app',
    templateUrl: "App/Index/app.component.html",
    providers:[AppService]
})
export class MeuPrimeiroComponent {
    titulo : string = 'Angular 2';
    mensagem ='';
    nome :  string = '';

constructor(private _appService: AppService) {
    this.getNomeInicial();
   }

   getNomeInicial() {
       this.nome = this._appService.getNome();
   }

   onClickMe() {
        this.mensagem = "clica em mim teste gabigol";
   }

}
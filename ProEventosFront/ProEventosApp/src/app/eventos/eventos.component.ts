import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
  showImagens : boolean = true;
  widthImagemEvento : number = 100;
  eventos : any = [];

  filtroEvento : string = "";

  constructor(private http : HttpClient) { }

  ngOnInit(): void {
    this.GetEventos();
  }

  public GetEventos() : void {
    this.http.get('https://localhost:44339/api/Evento').subscribe(
      response => this.eventos = response,
      error =>  console.log(error)
    );
  }

  public MudarStatusDeExibicaoDasImagens(): void {
    this.showImagens = !this.showImagens;
    let botaoImagem = document.getElementById("botaoMudarVisualizacaoImagem") as HTMLButtonElement;
    if(this.showImagens == false){
      botaoImagem.classList.remove("btn-primary");
      botaoImagem.classList.add("btn-danger");
    }else{
      botaoImagem.classList.remove("btn-danger");
      botaoImagem.classList.add("btn-primary");
    }

  }

}

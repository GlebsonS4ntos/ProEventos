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
  eventosFiltrados : any = [];

  private _filtroEvento : string = "";

  public get filtroEvento() : string{
    return this._filtroEvento;
  }

  public set filtroEvento(filtro : string){
    this._filtroEvento = filtro;
    this.eventosFiltrados = this.filtroEvento ? this.FiltrarEventos(this.filtroEvento.toLocaleLowerCase()) : this.eventos;
  }

  public FiltrarEventos(filtro : string) : void{
    return this.eventos.filter(
      (evento : {tema : string, local : string}) =>
        evento.tema.toLocaleLowerCase().indexOf(filtro) !== -1 ||
        evento.local.toLocaleLowerCase().indexOf(filtro) !== -1
    );
  }

  constructor(private http : HttpClient) { }

  ngOnInit(): void {
    this.GetEventos();
  }

  public GetEventos() : void {
    this.http.get('https://localhost:44339/api/Evento').subscribe(
      response => {
        this.eventos = response;
        this.eventosFiltrados = this.eventos;
      },
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

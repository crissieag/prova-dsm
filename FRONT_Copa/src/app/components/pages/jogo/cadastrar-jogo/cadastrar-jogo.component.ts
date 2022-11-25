import { Component, ElementRef, OnInit, QueryList, ViewChild, ViewChildren } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Router } from "@angular/router";
import { Selecao } from "src/app/models/selecao.model";
import { Jogo } from 'src/app/models/jogo.model';

@Component({
  selector: "app-cadastrar-jogo",
  templateUrl: "./cadastrar-jogo.component.html",
  styleUrls: ["./cadastrar-jogo.component.css"],
})
export class CadastrarJogoComponent implements OnInit {

  selecoes!: Selecao[];
  jogos: Jogo[] = [];
  id?: number;
  nome?: string;
  selecaoA?: string;
  selecaoB?: string;
  placarA?: number = 0;
  placarB?: number = 0;
  
  constructor(private http: HttpClient, private router: Router) {}

  ngOnInit(): void {
    		this.http.get<Selecao[]>("https://localhost:5001/api/selecao/listar").subscribe({
			next: (selecoes) => {
				this.selecoes = selecoes;
			},
		});
  }

  cadastrar(): void {

    let jogo: Jogo = {
			selecaoA: {id: this.selecaoA},
      selecaoB:{ id: this.selecaoB}
		};
console.log(jogo)
		this.http
			.post<Jogo>("https://localhost:5001/api/jogo/cadastrar", jogo)
			.subscribe({ next: (jogo) => this.jogos.push(jogo) });
    this.router.navigate(["pages/jogo/listar"])
  }
}

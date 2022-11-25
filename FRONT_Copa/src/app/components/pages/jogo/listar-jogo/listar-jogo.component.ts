import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Jogo } from "src/app/models/jogo.model";
import { Palpite } from "src/app/models/palpite.model";

@Component({
  selector: "app-listar-jogo",
  templateUrl: "./listar-jogo.component.html",
  styleUrls: ["./listar-jogo.component.css"],
})
export class ListarJogoComponent implements OnInit {

  palpites!: Palpite[]
  jogos!: Jogo[]
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get<Jogo[]>("https://localhost:5001/api/jogo/listar").subscribe({
			next: (jogos) => {
				this.jogos = jogos;
			},
		});
  }
}

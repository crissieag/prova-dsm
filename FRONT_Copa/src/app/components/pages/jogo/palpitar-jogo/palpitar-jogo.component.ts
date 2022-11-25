import { Component, OnInit } from "@angular/core";
import { Jogo } from "src/app/models/jogo.model";
import { HttpClient } from "@angular/common/http";
import { ActivatedRoute, Router } from "@angular/router";
import { Palpite } from "src/app/models/palpite.model";

@Component({
	selector: "app-palpitar-jogo",
	templateUrl: "./palpitar-jogo.component.html",
	styleUrls: ["./palpitar-jogo.component.css"],
})
export class PalpitarJogoComponent implements OnInit {
	constructor(
		private http: HttpClient,
		private router: Router,
		private route: ActivatedRoute
	) {}
	jogo!: Jogo;
	placarA?: number;
	placarB?: number;

	ngOnInit(): void {
		this.route.params.subscribe({
			next: (params) => {
				let { id } = params;
				if (id !== undefined) {
					this.http
						.get<Jogo>(`https://localhost:5001/api/jogo/listar/${id}`)
						.subscribe({
							next: (jogo) => {
								this.jogo = jogo;
							},
						});
				}
			},
		});
	}

    palpitar(): void {

      console.log(this.placarA, this.placarB);

    let palpite: Palpite = {
			selecaoA: {id: this.jogo.selecaoA.iD},
			selecaoB: {id: this.jogo.selecaoB.iD},
      placarA: this.placarA,
      placarB: this.placarB,
      
		};
		this.http
			.post<Jogo>("https://localhost:5001/api/palpite/cadastrar", palpite)
			.subscribe({ next: (palpite) => this.router.navigate(["pages/jogo/listar"]) });
  }
}

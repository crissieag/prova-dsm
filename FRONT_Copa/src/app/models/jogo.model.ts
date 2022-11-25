import { Selecao } from "./selecao.model";

export interface Jogo {
  id?: number;
  selecaoA?: any;
  selecaoB?: any;
  criadoEm?: string;
  placarA?: number;
  placarB?: number;
}

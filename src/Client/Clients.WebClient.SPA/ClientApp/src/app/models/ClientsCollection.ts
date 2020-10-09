import { Clients } from "./clients";

export interface ClientsCollection {
  hasItems: boolean,
  items: Clients[],
  total: number,
  page: number,
  pages: number,
}

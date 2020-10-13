import { Orders } from "./orders";

export interface OrdersCollection {
  hasItems: boolean,
  items: Orders[],
  total: number,
  page: number,
  pages: number,
}

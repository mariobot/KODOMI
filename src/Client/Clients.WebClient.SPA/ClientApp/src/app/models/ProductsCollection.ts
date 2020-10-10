import { Products } from "./product";

export interface ProductsCollection {
  hasItems: boolean,
  items: Products[],
  total: number,
  page: number,
  pages: number,
}

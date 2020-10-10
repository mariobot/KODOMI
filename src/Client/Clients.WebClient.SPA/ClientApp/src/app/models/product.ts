export interface Products {
  productId: number,
  name: string,
  description: string,
  price: number
  stock: ProductStock
}

export interface ProductStock {
  productInStockId: number,
  productId: number,
  stock: number
}

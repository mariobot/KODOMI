import { Component, OnInit } from '@angular/core';
import { ProductsCollection } from '../models/ProductsCollection';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products: ProductsCollection;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get<ProductsCollection>("/products?page=1&take=100").subscribe(result =>
      this.products = result
      , error => console.log(error));
  }
}

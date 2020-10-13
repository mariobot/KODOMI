import { Component, OnInit } from '@angular/core';
import { OrdersCollection } from '../models/orders-collection';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {

  orders: OrdersCollection

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get<OrdersCollection>("/orders?take=100&page=1").subscribe(result => {
      this.orders = result
    }, error => console.log(error))
  }

}

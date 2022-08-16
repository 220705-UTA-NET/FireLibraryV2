import { Component, OnInit } from '@angular/core';
import { Order } from "../Models/order";
import { MyBooksService } from '../services/my-books.service';

@Component({
  selector: 'app-my-books',
  templateUrl: './my-books.component.html',
  styleUrls: ['./my-books.component.css']
})
export class MyBooksComponent implements OnInit {

  myOrders : Order[] = []
  private url:string = "https://firelirbraryv2.azurewebsites.net/api/Customer/Orders?customerId=1"; // TODO: dynamically populate customerId here
  constructor(private myBooksService:MyBooksService) { 
  }

  ngOnInit(): void {
    this.myBooksService.getAllOrders(this.url).subscribe((Res) => {
      this.myOrders = Res;
    });
  }

}

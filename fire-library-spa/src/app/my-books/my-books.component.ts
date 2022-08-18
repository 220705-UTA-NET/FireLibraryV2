import { Component, OnDestroy, OnInit } from '@angular/core';
import { Order } from "../Models/order";
import { MyBooksService } from '../services/my-books.service';
import { AuthService } from '../auth/auth.service';
import { Subscription } from 'rxjs';
import { Book } from '../Models/book';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-my-books',
  templateUrl: './my-books.component.html',
  styleUrls: ['./my-books.component.css']
})
export class MyBooksComponent implements OnInit {

  myOrders : Order[] = [];
  customerId = 0;
  private url:string = "https://firelirbraryv2.azurewebsites.net/api/Customer/Orders?customerId=";
  constructor(private myBooksService:MyBooksService,
    private activatedRoute: ActivatedRoute) { 
      this.activatedRoute.queryParams.subscribe(params => {
        this.customerId = params['customerId'];
        console.log(this.customerId); // Print the parameter to the console. 
        });
  }

  ngOnInit(): void {
    let searchUrl = this.url + this.customerId;
    this.myBooksService.getBooksFromOrder(searchUrl).subscribe((Res) => {
      this.myOrders = Res;
    });
  }

}

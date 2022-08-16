import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Order } from "../Models/order";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class MyBooksService {
  constructor(private http:HttpClient){}
  getBooksFromOrder(url:string): Observable<Order[]>{
    return this.http.get<Order[]>(url);
}
  
}

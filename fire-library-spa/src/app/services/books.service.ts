// The angular way to make an http call is to use a service 
// notice the keyword injectable
// read the docs here: https://angular.io/guide/dependency-injection
// basically it provides injectable class and other component will need to know about it by providing it inside app-module.ts or here where it says providedIn:'root'
// ... and root means it is known app wide

import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Book } from "../Models/book";
import { Observable } from "rxjs";

@Injectable({providedIn: 'root'})//known app wide by saying providedIn root
export class BooksService{
    constructor(private http:HttpClient){}//http is our variable name (instance) of HttpClient
    getAllBooks(url:string): Observable<Book[]>{//observable I Think Richard said that it lets other components know of any changes
        return this.http.get<Book[]>(url);
    }
}
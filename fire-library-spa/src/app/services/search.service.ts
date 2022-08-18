import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from "@angular/common/http";
import { Observable } from "rxjs";
import { Book } from "../Models/book";

@Injectable({providedIn: 'root'})
export class SearchService{

    constructor(private http:HttpClient){}
    getSearchedBooks(url:string): Observable<Book[]>{
        return this.http.get<Book[]>(url);
    }
}
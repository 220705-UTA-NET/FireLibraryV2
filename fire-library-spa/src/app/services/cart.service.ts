import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Book } from "../Models/book";
import { BehaviorSubject, Observable, Subject } from "rxjs";


@Injectable({providedIn: 'root'})
export class CartService{
    private books:Book[]=[];
    private bookListener = new BehaviorSubject<Book[]>([]);
    getBooksInCart():Book[]{
        return this.books;
    }
    addToCart(book:Book){
        this.books.push(book);
    }
    getBooksListener(){
        return this.bookListener.asObservable();
    }
}
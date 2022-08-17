import { Component, OnDestroy, OnInit } from '@angular/core';
import { Book } from '../Models/book';
import { BooksService } from '../services/books.service';
import { AuthService } from '../auth/auth.service';
import { Subscription } from 'rxjs';
@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit, OnDestroy {
  books : Book[] = []
  //private url:string = "https://firelibraryapi.azurewebsites.net/api/books";
  private url:string = "https://firelibrarydocker.azurewebsites.net/api/Books";
  public loggedIn = false;
  private authListener: Subscription|null = null; 

  constructor(private mybooksService:BooksService, private auth:AuthService) { 
    this.authListener = this.auth.getAuthStatusListener().subscribe(value=>{
      this.loggedIn = value;
    })
  }

  ngOnInit(): void {
    this.mybooksService.getAllBooks(this.url).subscribe((Res) => {
      this.books = Res;
    });
  }
  ngOnDestroy(): void {
    this.authListener?.unsubscribe();
  }

}

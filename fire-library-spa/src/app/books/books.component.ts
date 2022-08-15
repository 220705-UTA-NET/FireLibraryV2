import { Component, OnInit } from '@angular/core';
import { Book } from '../Models/book';
import { BooksService } from '../services/books.service';
@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  books : Book[] = []
  //private url:string = "https://firelibraryapi.azurewebsites.net/api/books";
  private url:string = "https://firelirbraryv2.azurewebsites.net/api/Books";
  constructor(private mybooksService:BooksService) { 
  }

  ngOnInit(): void {
    this.mybooksService.getAllBooks(this.url).subscribe((Res) => {
      this.books = Res;
    });
  }

}

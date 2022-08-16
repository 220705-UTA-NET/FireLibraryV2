import { Component, OnInit } from '@angular/core';
import { Book } from '../Models/book';
import { BooksService } from '../services/books.service';
@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  books : Book[] = [] //variable books type array of Book
  //private url:string = "https://firelibraryapi.azurewebsites.net/api/books";
  private url:string = "https://firelirbraryv2.azurewebsites.net/api/Books";
  constructor(private mybooksService:BooksService) { //instance of obeservable done in the constructor
  }

  ngOnInit(): void {
    this.mybooksService.getAllBooks(this.url).subscribe((Res) => {//subscribe means we are listening for changes from the service pretty sure all this is done as a way to provide async
      this.books = Res;//we set the return to this.books
    });
  }

}

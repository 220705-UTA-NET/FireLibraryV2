import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Book } from '../Models/book';
import { SearchBooksService } from '../services/search-books.service';

@Component({
  selector: 'app-search-books-result',
  templateUrl: './search-books-result.component.html',
  styleUrls: ['./search-books-result.component.css']
})
export class SearchBooksResultComponent implements OnInit {

  books : Book[] = []
  // https://firelirbraryv2.azurewebsites.net/api/Books/search/genre?genre=fiction
  private url:string = "https://firelirbraryv2.azurewebsites.net/api/Books/search/";
  searchBy = "";
  searchFor = "";

  constructor(private activatedRoute: ActivatedRoute,
    private searchBooksService:SearchBooksService) {
    this.activatedRoute.queryParams.subscribe(params => {
      this.searchFor = params['searchFor'];
      this.searchBy = params['searchBy'];
      console.log(this.searchFor + ", " + this.searchBy); // Print the parameter to the console. 
      });
  }

  ngOnInit(): void {
    let searchUrl = this.url + this.searchBy + "?" + this.searchBy + "=" + this.searchFor;
    this.searchBooksService.getAllBooks(searchUrl).subscribe((Res) => {
      this.books = Res;
    });
  }

}
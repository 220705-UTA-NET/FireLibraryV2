import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

import { Book } from '../Models/book';
import { SearchBooksService } from '../services/search-books-result.service';

@Component({
  selector: 'app-search-books',
  templateUrl: './search-books.component.html',
  styleUrls: ['./search-books.component.css']
})
export class SearchBooksComponent implements OnInit {

  searchUrl ="http://localhost:4200/searchBooksResult";

  searchForm = this.formBuilder.group({
    searchBy: '',
    searchFor: ''
  });
  books : Book[] = [];
  private url:string = "https://firelibrarydocker.azurewebsites.net/api/Books/search/"
 //"https://firelirbraryv2.azurewebsites.net/api/Books/search/";
  constructor(private formBuilder: FormBuilder, private searchBooksService:SearchBooksService) { }
  // constructor() { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    // Process search data here

    console.log('Your request will be submitted', this.searchForm.value);
    let formData = this.searchForm.value;
    let searchBy = formData['searchBy'];
    let searchFor = formData['searchFor'];
    let searchUrl = this.url + searchBy + "?" + searchBy + "=" + searchFor;
    console.log('URL to find books: ', searchUrl);
    if (searchBy == "isbn") {
      this.searchBooksService.getSingleBook(searchUrl).subscribe((Res) => {
        this.books = [Res];
      });
    } else {
      this.searchBooksService.getAllBooks(searchUrl).subscribe((Res) => {
        this.books = Res;
      });
    }
    this.searchForm.reset();
  }
}

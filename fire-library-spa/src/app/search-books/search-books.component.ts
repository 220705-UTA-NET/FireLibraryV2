import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-search-books',
  templateUrl: './search-books.component.html',
  styleUrls: ['./search-books.component.css']
})
export class SearchBooksComponent implements OnInit {

  // searchUrl ="http://localhost:4200/searchBooksResult";

  searchForm = this.formBuilder.group({
    searchBy: '',
    searchFor: ''
  });

  constructor(private formBuilder: FormBuilder) { }
  // constructor() { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    // Process search data here

    console.warn('Your request will be submitted', this.searchForm.value);
    this.searchForm.reset();
  }
}

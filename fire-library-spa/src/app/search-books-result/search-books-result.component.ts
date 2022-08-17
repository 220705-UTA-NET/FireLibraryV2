import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-search-books-result',
  templateUrl: './search-books-result.component.html',
  styleUrls: ['./search-books-result.component.css']
})
export class SearchBooksResultComponent implements OnInit {

  searchBy = "";
  searchFor = "";

  // constructor() { }
  constructor(private activatedRoute: ActivatedRoute) {
    this.activatedRoute.queryParams.subscribe(params => {
      this.searchFor = params['searchFor'];
      this.searchBy = params['searchBy'];
          console.log(this.searchFor + ", " + this.searchBy); // Print the parameter to the console. 
      });
  }

  ngOnInit(): void {
  }

}

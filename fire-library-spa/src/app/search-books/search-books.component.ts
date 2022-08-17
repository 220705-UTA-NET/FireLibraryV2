import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

// import { CartService } from '../cart.service';

@Component({
  selector: 'app-search-books',
  templateUrl: './search-books.component.html',
  styleUrls: ['./search-books.component.css']
})
export class SearchBooksComponent implements OnInit {

  // searchForm = this.formBuilder.group({
  //   searchBy: '',
  //   searchFor: ''
  // });

  // constructor(private formBuilder: FormBuilder) { }
  constructor() { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    // Process search data here
    // console.warn('Your order has been submitted', this.searchForm.value);
    // this.searchForm.reset();
  }
}

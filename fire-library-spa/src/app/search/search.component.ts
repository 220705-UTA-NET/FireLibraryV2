import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { AuthService } from '../auth/auth.service';
import { Book } from '../Models/book';
import { CartService } from '../services/cart.service';
import { SearchService } from '../services/search.service';


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  public loggedIn = false;
  private authListener: Subscription|null = null;
  private uri:string = "https://firelibrarydocker.azurewebsites.net/api/Books/search/";
  private newuri:string =''
  searchResults : Book[] = []
  term : string = ''
  type : string = ''
  searchTypes : string[] = ['isbn', 
  'title', 
  'author', 
  'genre']

  
  
  constructor(private searchService:SearchService,
    private auth:AuthService, private cart:CartService) {
      this.authListener = this.auth.getAuthStatusListener().subscribe(value => {
        this.loggedIn = value;
      })
     }

  ngOnInit(): void {
  }

  onClickSearch(search: string) {
    this.term = search;
    console.log(this.term)
    let uri = this.newuri 
    console.log(uri)
    uri += '?' + this.term

    this.searchService.getSearchedBooks(uri).subscribe((Res) => {
      this.searchResults = Res;
    })
    
    console.log(this.searchResults)
  }

  radioChangeHandler (event: any) {
    this.newuri = ''
    this.type = event.target.value;
    this.newuri = this.uri + this.type;
    console.log(this.newuri);
  }

  addBook(book:Book){
    
    var index = this.cart.getBooksInCart().findIndex(a => a.isbn == book.isbn);
    if(index < 0){//only add if book does not exists | basically look for book and get the index | findIndex returns -1 when not found
      this.cart.addToCart(book);
      console.log(this.cart.getBooksInCart());
    }
  }
}

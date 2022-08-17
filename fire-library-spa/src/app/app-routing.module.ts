import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MyBooksComponent } from './my-books/my-books.component';
import { SearchBooksComponent } from './search-books/search-books.component';
import { SearchBooksResultComponent } from './search-books-result/search-books-result.component';
import { TemplateComponent } from './template/template.component';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'myBooks', component: MyBooksComponent},
  {path: 'searchBooks', component: SearchBooksComponent},
  {path: 'searchBooksResult', component: SearchBooksResultComponent},
  {path: 'template', component: TemplateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

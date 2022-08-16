import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { TopComponent } from './top/top.component';
import { BooksComponent } from './books/books.component';
import { TemplateComponent } from './template/template.component';
import { MyBooksComponent } from './my-books/my-books.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TopComponent,
    BooksComponent,
    TemplateComponent,
    MyBooksComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  exports:[AppRoutingModule],
  bootstrap: [AppComponent]
})
export class AppModule { }

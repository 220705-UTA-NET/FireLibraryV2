import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { TopComponent } from './top/top.component';
import { BooksComponent } from './books/books.component';
import { TemplateComponent } from './template/template.component';
//module imports are done here and in component | for example AppRoutingModule and HttpClientModule
//also declarations qre done here | every component is defined here so it will be known to other compontents
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TopComponent,
    BooksComponent,
    TemplateComponent
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

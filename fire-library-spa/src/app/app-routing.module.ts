import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MyBooksComponent } from './my-books/my-books.component';
import { TemplateComponent } from './template/template.component';
import { LoginComponent } from './auth/login/login.component';
import { SearchComponent } from './search/search.component';

const routes: Routes = [
  {path: '',pathMatch:'full', redirectTo:'home'},
  {path: 'home', component: HomeComponent},
  {path: 'myBooks', component: MyBooksComponent},
  {path: 'template', component: TemplateComponent},
  {path: 'login', component: LoginComponent},
  {path: 'search', component: SearchComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

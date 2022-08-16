import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TemplateComponent } from './template/template.component';
import { LoginComponent } from './auth/login/login.component';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'template', component: TemplateComponent},
  {path: 'login', component: LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

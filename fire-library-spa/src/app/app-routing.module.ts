import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TemplateComponent } from './template/template.component';

const routes: Routes = [//we define which url path to which component
//if you look at home.component file class is named HomeComponent
//home, top, and book components were created using ng generate component {name}
// example: home was generated using: ng generate component home
  {path: 'home', component: HomeComponent},
  {path: 'template', component: TemplateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

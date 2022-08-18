import {Component} from "@angular/core";
import { NgForm } from "@angular/forms";
import { AuthService } from "../auth.service";

@Component({
  templateUrl: './login.component.html'
})
export class LoginComponent{
  
  constructor(public authService: AuthService) {}

  onLogin(form: NgForm){
    //console.log("on login component");
    //console.log(form.value.email);
    this.authService.login(form.value.email, form.value.password);
  }
}
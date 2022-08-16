import { Component } from '@angular/core';
//the app component usually is together with html and css files of the same name
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'fire-library-spa';
}

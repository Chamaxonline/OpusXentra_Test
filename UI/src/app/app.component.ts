import { Component } from '@angular/core';
import { ActivatedRoute, NavigationStart, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Trivet-ERP';
  showMenu:boolean = false;
  constructor(private router:Router){
    router.events.forEach((event) => {
      if(event instanceof NavigationStart){
        this.showMenu = event.url !=="/login"
      }
    });
  }
  
 }
import { Component } from '@angular/core';
import { NavbarComponent } from './common/navbar/navbar.component';
import { Router } from '@angular/router';

import menuItems from './common/menuItems';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent {
  private menuItems = menuItems();

  constructor(private router: Router) {
    router.events.subscribe(event => {
      this.menuItems = menuItems();
    });
  }
}

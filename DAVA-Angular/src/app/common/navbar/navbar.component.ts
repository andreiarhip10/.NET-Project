import { Component, Input } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import menuItems from '../menuItems';

@Component({
    selector: 'navbar',
    templateUrl: './navbar.component.html',
    styleUrls: ["./navbar.component.less"]
})

export class NavbarComponent {
    @Input() private menuItems;
    
    constructor(private router : Router) {

    }

    private logout() {
        localStorage.removeItem('isAuth') ;
        this.router.navigateByUrl('/login');
    }
}
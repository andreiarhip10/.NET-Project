import { Component } from '@angular/core';
import { Router } from '@angular/router';


@Component({
    selector: 'homepage',
    templateUrl: './homepage.component.html',
    styleUrls: []
})

export class HomePageComponent {
    constructor(private router: Router) {
        if (!localStorage.getItem("isAuth")) {
            router.navigateByUrl('/login');
        }
    }
}

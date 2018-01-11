import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'login',
    templateUrl: './login.component.html',
    styleUrls: ["./login.component.css"]
})

export class LoginComponent {
    private username: string = "";
    private password: string = "";

    constructor(private router: Router) {
        if (localStorage.getItem("isAuth")) {
            router.navigateByUrl('/');
        }
    }

    private login() {
        // this.http.post(this.credentials, this.url).then(response => {
        //     if (response.ok) {
        //         localStorage.setItem('isAuth', 'true');
        //     }
        // });
        if (this.username != 'admin' && this.password != 'admin') {
            return;
        }
        else {
            localStorage.setItem("isAuth", "true");
            this.router.navigateByUrl('/');
        }
    }
}
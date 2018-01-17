import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders} from '@angular/common/http' ;

@Component({
    selector: 'homepage',
    templateUrl: './homepage.component.html',
    styleUrls: []
})

export class HomePageComponent {
    constructor(private router: Router, private Http: HttpClient) {
        if (!localStorage.getItem("isAuth")) {
            router.navigateByUrl('/login');
        }
    }
    private getUsers() {
        this.Http.get('http://localhost:5000/api/getUsers').subscribe(function(resp){
            console.log(resp);
        })
    }
}




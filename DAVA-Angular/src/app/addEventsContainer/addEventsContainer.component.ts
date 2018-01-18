import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'addEventsContainer',
    templateUrl: './addEventsContainer.component.html',
    styleUrls: []
})

export class addEventsContainerComponent{
    constructor(private router: Router) {
        
    }
    private add(){
        this.router.navigateByUrl('/addEvent') ;
    }
}
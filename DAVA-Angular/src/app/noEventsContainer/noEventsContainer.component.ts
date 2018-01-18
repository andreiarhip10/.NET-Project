import { Component } from '@angular/core' ;
import { Router } from '@angular/router';

@Component ({
    selector: 'noEventsContainer' ,
    templateUrl : './noEventsContainer.component.html',
    styleUrls: []
})

export class noEventsContainerComponent {

    constructor(private router: Router) {
        
    }
    private addEvent(year, month, day){
       this.router.navigateByUrl(`/addEvent?year=${year}&month=${month}&day=${day}`)
    }
}
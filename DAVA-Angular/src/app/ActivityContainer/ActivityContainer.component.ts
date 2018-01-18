import { Component, Input, OnInit } from '@angular/core';
import { editEventsContainerComponent} from '../editEventsContainer/editEventsContainer.component';
import { Router } from '@angular/router';

@Component({
    selector: 'ActivityContainer',
    templateUrl: './ActivityContainer.component.html',
    styleUrls: ['./ActivityContainer.component.less']
})

export class ActivityContainerComponent implements OnInit {
    @Input() private data;
    @Input() private events;
    
    constructor(private router: Router) {
        
    }
    private edit(){
        this.router.navigateByUrl('/editEvent') ;
    }

    ngOnInit() {
        console.log(this.data);
    }
}
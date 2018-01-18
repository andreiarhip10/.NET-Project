import { Component, Input, OnInit } from '@angular/core';

import { Router } from '@angular/router';


@Component({
    selector: 'ActivityContainer',
    templateUrl: './ActivityContainer.component.html',
    styleUrls: []
})

export class ActivityContainerComponent implements OnInit{
    @Input() private type;
    @Input() private events;
    
    constructor() {
        
    }
    ngOnInit() {
        console.log(this.type) ;
    }
}
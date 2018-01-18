import { Component, Input, OnInit } from '@angular/core';

import { Router } from '@angular/router';

@Component({
    selector: 'ActivityContainer',
    templateUrl: './ActivityContainer.component.html',
    styleUrls: ['./ActivityContainer.component.less']
})

export class ActivityContainerComponent implements OnInit {
    @Input() private data;
    @Input() private events;
    
    constructor() {
        
    }

    ngOnInit() {
        console.log(this.data);
    }
}
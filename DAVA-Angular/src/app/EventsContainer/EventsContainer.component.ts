import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ActivityContainerComponent } from '../ActivityContainer/ActivityContainer.component';

@Component({
    selector: 'EventsContainer',
    templateUrl: './EventsContainer.component.html',
    styleUrls: []
})


export class EventsContainerComponent {

    private data = [ {
        type: 'Work',
        events : [{
            eventName : 'Do .NET homework',
            capacity: 15
        }]
    }, {
        type: 'Leisure',
        events : [{
            eventName : 'Play guitar',
            capacity: 15
        }]
    }, {
        type: 'Housework',
        events : [{
            eventName : 'Buy a new pc',
            capacity: 15
        }]
    },
    ]
    constructor() {
    }
}
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ActivityContainerComponent } from '../ActivityContainer/ActivityContainer.component';

@Component({
    selector: 'EventsContainer',
    templateUrl: './EventsContainer.component.html',
    styleUrls: []
})


export class EventsContainerComponent {
    private types = ['Work', 'Leisure', 'Housework'];
    private events = [];
    private data = [ {
        type: 'Work',
        events : [{
            eventName : 'eveniment',
            capacity: 15
        }]
    }, {
        type: 'Leisure',
        events : [{
            eventName : 'eveniment',
            capacity: 15
        }]
    }, {
        type: 'Housework',
        events : [{
            eventName : 'eveniment',
            capacity: 15
        }]
    },
    ]
    constructor() {
    }
}
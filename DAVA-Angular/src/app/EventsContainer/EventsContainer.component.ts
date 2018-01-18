import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ActivityContainerComponent } from '../ActivityContainer/ActivityContainer.component';

@Component({
    selector: 'EventsContainer',
    templateUrl: './EventsContainer.component.html',
    styleUrls: []
})

export class EventsContainerComponent implements OnInit {
    @Input() private activities;
    @Input() private showTitle: boolean;

    constructor() {

    }

    ngOnInit() {

    }
}
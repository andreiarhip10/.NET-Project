import { Component, Input, OnInit } from '@angular/core';

@Component({
    selector: 'calendarcell',
    templateUrl: './calendarCell.component.html',
    styleUrls: ['./calendarCell.component.less']
})

export class CalendarCellComponent implements OnInit {
    @Input() private dateObject;

    constructor() {

    }

    ngOnInit() {
        console.log(this.dateObject);
    }
}
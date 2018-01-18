import { Component } from '@angular/core';

import { CalendarCellComponent } from './calendarCell/calendarCell.component';

@Component({
    selector: 'calendar',
    templateUrl: './calendar.component.html',
    styleUrls: []
})

export class CalendarComponent {
    private weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
    private monthNames = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    private selectedYear = new Date().getFullYear();
    private selectedMonth = this.monthNames[new Date().getMonth()];
    private selectedMonthNumber = new Date().getMonth() + 1;
    private days = this.getDaysNamesAndValue(this.selectedYear, this.selectedMonthNumber);
    private dayNames = this.getTableRows(this.days);

    constructor() {

    }

    private getDaysNamesAndValue(selectedYear, selectedMonth) {
        console.log(selectedYear, selectedMonth);
        let daysArray = [], l;
        const numDaysInMonth = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        const daysInWeek = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
        const daysIndex = { 'Sun': 0, 'Mon': 1, 'Tue': 2, 'Wed': 3, 'Thu': 4, 'Fri': 5, 'Sat': 6 };
        let index = daysIndex[(new Date(selectedYear, selectedMonth - 1, 1)).toString().split(' ')[0]];

        for (let i = 0, l = numDaysInMonth[selectedMonth - 1]; i < l; i++) {
            daysArray.push({
                dayNumber: i + 1,
                dayName: daysInWeek[index++]
            });
            if (index == 7) index = 0;
        }
        return daysArray;
    }

    private getTableRows(days) {
        let counter = 1;
        let daysArray = [];
        let arrayToReturn = [];
        for (let index = 0; index <= 28; index++) {
            if (index < 7 * counter) {
                daysArray.push(days[index]);
            } else {
                arrayToReturn.push({
                    weekNumber: counter,
                    weekItems: daysArray
                });
                counter++;
                index--;
                daysArray = [];
            }
        }

        if (days.length > 28) {
            let fifthWeek = [];

            for (let index = 28; index < days.length; index++) {
                fifthWeek.push(days[index]);
            }

            arrayToReturn.push({
                weekNumber: 5,
                weekItems: fifthWeek
            });
        }

        return arrayToReturn;
    }
}
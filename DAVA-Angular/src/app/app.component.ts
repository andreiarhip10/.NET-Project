import { Component } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  private _nextId=1
  private createAcc(usernameEl:string, emailEl:string)
  {
    // this._accounts.push(new Account(this._nextId,usernameEl,emailEl))
    // this._selected.push(false) //default not selected
    // this._nextId++
    usernameEl=""
    emailEl=""
  }
}

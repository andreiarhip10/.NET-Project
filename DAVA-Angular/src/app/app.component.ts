import { Component } from '@angular/core';
import { Account } from './account.model'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  private _selected:Array<boolean> = []
  private _accounts:Array<Account> = [
    // {
    //   id:1,
    //   username:"user1",
    //   email:"user1@gmail.com"
    // },
    // new Account(2,"user2","user2@gmail.com")
  ]
  private _nextId=1
  private isEmpty=true
  private createAcc(usernameEl:string, emailEl:string)
  {
    this._accounts.push(new Account(this._nextId,usernameEl,emailEl))
    this._selected.push(false) //default not selected
    this._nextId++
    usernameEl=""
    emailEl=""
  }
  private removeAcc(index:number){
    this._accounts.splice(index,1)
    this._selected.splice(index,1)
  }
  private select(index:number)
  {
    this._selected[index]=!this._selected[index]
  }
  private isaccountsempty():boolean
  {
    if(this._accounts.length==0)
    {
      this.isEmpty=false
    }
    else
    {
      this.isEmpty=true
    }
    return this.isEmpty
  }
}

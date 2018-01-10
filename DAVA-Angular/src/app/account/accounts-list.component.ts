import {Component} from '@angular/core';
import {Account} from './account.model';

@Component(
  {
    selector: 'accounts-list',
    templateUrl: './accounts-list.component.html',
    styleUrls: ['./accounts-list.component.css']
  }
)

export class AccountsList{
  private _selected:Array<boolean> = []
  private _accounts:Array<Account> = [
    // {
    //   id:1,
    //   username:"user1",
    //   email:"user1@gmail.com"
    // },
    // new Account(2,"user2","user2@gmail.com")
  ];
  private isEmpty=true
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

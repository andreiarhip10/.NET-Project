import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms' ;
import { RouterModule, Routes} from '@angular/router' ;
import { AppComponent } from './app.component';
import { AccountsList} from './account/accounts-list.component';
import { DashboardComponent} from './dashboard/dashboard.component';
import { HomePageComponent} from './homepage/homepage.component' ;
import { LoginComponent} from './login/login.component' ;
import { SignupComponent } from './signup/signup.component';



const appRoutes : Routes = [
  { path: 'addDashboard', component: DashboardComponent},
  { path: 'login', component: LoginComponent},
  { path: 'signup', component: SignupComponent},
  { path: '', component: HomePageComponent},
  {
    path: '**', redirectTo :'/'
  }

];


@NgModule({
  declarations: [
    AppComponent,
    AccountsList,
    DashboardComponent,
    HomePageComponent,
    LoginComponent,
    SignupComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot (
      appRoutes,{enableTracing:false}
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

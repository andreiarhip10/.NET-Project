import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms' ;
import { RouterModule, Routes} from '@angular/router' ;
import { HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { DashboardComponent} from './dashboard/dashboard.component';
import { HomePageComponent} from './homepage/homepage.component' ;
import { LoginComponent} from './login/login.component' ;
import { SignupComponent } from './signup/signup.component';
import { NavbarComponent } from './common/navbar/navbar.component';
import { CalendarComponent} from './calendar/calendar.component';
import { CalendarCellComponent } from './calendar/calendarCell/calendarCell.component';


const appRoutes : Routes = [
  { path: 'addDashboard', component: DashboardComponent},
  { path: 'login', component: LoginComponent},
  { path: 'signup', component: SignupComponent},
  { path: '', component: HomePageComponent},
  { path: '**', redirectTo :'/' }
];


@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    HomePageComponent,
    LoginComponent,
    SignupComponent,
    NavbarComponent,
    CalendarComponent,
    CalendarCellComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot (
      appRoutes,{enableTracing:false}
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

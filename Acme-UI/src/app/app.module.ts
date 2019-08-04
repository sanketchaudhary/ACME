import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { InvestorComponent } from './investor/investor.component';
import { InvestorService } from './investor/investor.service';
import { AppRoutingModule } from './app-routing.module';
import { SuccessComponent } from './success/success.component';

@NgModule({
  declarations: [
    AppComponent,
    InvestorComponent,
    SuccessComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    ReactiveFormsModule,
    AppRoutingModule
  ],
  providers: [
    InvestorService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

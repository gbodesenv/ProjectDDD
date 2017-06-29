import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { MeuPrimeiroComponent } from '../App/Index/app.component' ;

@NgModule({
    declarations: [        
        MeuPrimeiroComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule
    ],
    providers: [],
    bootstrap: [MeuPrimeiroComponent]
})
export class AppModule { }